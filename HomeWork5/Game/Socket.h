#pragma once
#include <iostream>
#include <string>
#include "WinSock2.h" //здесь находятся объявления, необходимые
//для Winsock 2 API.
#include <ws2tcpip.h> //содержит функции для работы с адресами
//напр. inet_pton
#pragma comment(lib, "Ws2_32.lib") //линкуем библиотеку Windows Sockets

using namespace std;

const int MAXSTRLEN = 255;

class Socket
{
protected:
	WSADATA wsaData;//структура для хранения информацию
					//о инициализации сокетов
	SOCKET _socket; //дескриптор слушающего сокета
	SOCKET acceptSocket;//дескриптор сокета, который связан с клиентом 
	sockaddr_in addr; //локальный адрес и порт
public:
	Socket();
	~Socket();
	bool SendData(char*); //метод для отправки данных в сеть
	bool ReceiveData(char*, int);//метод для получения данных
	void CloseConnection(); //метод для закрытия соединения
	void SendDataMessage(bool isComputer, char* autoMessage);//метод для отправки сообщения пользователя
};

class ServerSocket : public Socket
{
public:
	void Listen(); //метод для активации "слушающего" сокета
	void Bind(int port); //метод для привязки сокета к порту
	void StartHosting(int port); //объединяет вызов двух предыдущих методов
};

class ClientSocket : public Socket
{
public:
	//метод для подключения к серверу
	void ConnectToServer(const char* ip, int port);
};