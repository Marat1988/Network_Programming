#include "Socket.h"
#include <string.h>

Socket::Socket()
{
	//если инициализация сокетов прошла неуспешно, выводим сообщение об
	//ошибке
	if (WSAStartup(MAKEWORD(2, 2), &wsaData) != NO_ERROR)
	{
		cout << "WSAStartup error\n";
		system("pause");
		WSACleanup();
		exit(10);
	}

	//создаем потоковый сокет, протокол TCP
	_socket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	//при неуспешном создании сокета выводим сообщение об ошибке
	if (_socket == INVALID_SOCKET)
	{
		cout << "Socket create error." << endl;
		system("pause");
		WSACleanup();
		exit(11);
	}


}

Socket::~Socket()
{
	WSACleanup();//очищаем ресурсы
}

bool Socket::SendData(char* buffer)
{
	/*Отправляем сообщение на указанный сокет*/
	send(_socket, buffer, strlen(buffer), 0);
	return true;
}

bool Socket::ReceiveData(char* buffer, int size)
{
	/*Получаем сообщение и сохраняем его в буфере.
	Метод является блокирующим!*/
	int i = recv(_socket, buffer, size, 0);
	buffer[i] = '\0';
	return true;
}

void Socket::CloseConnection()
{
	//Закрываем сокет
	closesocket(_socket);
}

void Socket::SendDataMessage(bool isComputer, char* automessage)
{
	if (isComputer) {
		SendData(automessage);
	}
	else {
		//Строка для сообщения пользователя
		char message[MAXSTRLEN];
		//Без этого метода из потока будет считан последний
		//ввод пользователя, выполняем сброс.
		cin.ignore();
		cout << "Input message: (Камень или Ножницы или Бумага) ";
		cin.get(message, MAXSTRLEN);
		strncpy_s(automessage, MAXSTRLEN, message, MAXSTRLEN);
		automessage = message;
		SendData(automessage);
	}

}

void ServerSocket::StartHosting(int port)
{
	Bind(port);
	Listen();
}

void ServerSocket::Listen()
{
	cout << "Waiting for client..." << endl;

	//При ошибке активации сокета в режиме прослушивания
	//выводим ошибку
	if (listen(_socket, 1) == SOCKET_ERROR)
	{
		cout << "Listening error\n";
		system("pause");
		WSACleanup();
		exit(15);
	}
	/*
	Метод является блокирующим. Ожидаем подключение клиента.
	Как только клиент подключился, функция accept возвращает
	новый сокет, через который происходит обмен данными.
	*/
	acceptSocket = accept(_socket, NULL, NULL);
	while (acceptSocket == SOCKET_ERROR)
	{
		acceptSocket = accept(_socket, NULL, NULL);
	}
	_socket = acceptSocket;
}

void ServerSocket::Bind(int port)
{
	//Указываем семейство адресов IPv4
	addr.sin_family = AF_INET;
	/*Преобразуем адрес "0.0.0.0"в правильную
	структуру хранения адресов, результат сохраняем в поле sin_addr */
	inet_pton(AF_INET, "0.0.0.0", &addr.sin_addr);
	//Указываем порт. 
	//Функиця htons выполняет преобразование числа в
	//сетевой порядок байт
	addr.sin_port = htons(port);

	cout << "Binding to port:  " << port << endl;
	//При неудачном биндинге к порту, выводим сообщение про ошибку
	if (bind(_socket, (SOCKADDR*)&addr, sizeof(addr)) == SOCKET_ERROR)
	{
		cout << "Failed to bind to port\n";
		system("pause");
		WSACleanup();
		exit(14);
	}
}

void ClientSocket::ConnectToServer(const char* ipAddress, int port)
{
	addr.sin_family = AF_INET;
	inet_pton(AF_INET, ipAddress, &addr.sin_addr);
	addr.sin_port = htons(port);
	//при неудачном подключении к серверу выводим сообщение про ошибку
	if (connect(_socket, (SOCKADDR*)&addr, sizeof(addr)) == SOCKET_ERROR)
	{
		cout << "Failed to connect to server\n";
		system("pause");
		WSACleanup();
		exit(13);
	}
}