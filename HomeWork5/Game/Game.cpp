#include <iostream>
#include <random>
#include "Socket.h"
using namespace std;

void  DetermineWinner(string myFigure, string opponentFigure);

int main()
{
	setlocale(LC_ALL, 0);
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	srand(time(NULL));
	bool isComputer = false;
	system("title Камень, ножницы, бумага. Раз, два, три...");
	string figures[3]{ "Камень", "Ножницы", "Бумага" };
	int nChoice;
	int quantityRound = 0; //Количество раундов
	int port = 1234; //Выбираем порт
	string ipAddress; //Адрес сервера
	char receiveMessage[MAXSTRLEN];
	char sendMessage[MAXSTRLEN];
	cout << "1) Start server" << endl;
	cout << "2) Connect to server" << endl;
	cout << "3) Exit" << endl;
	cin >> nChoice;
	if (nChoice == 1) {
		isComputer = true;
		ServerSocket server;
		cout << "Starting serevr..." << endl;
		//Запускаем сервер
		server.StartHosting(port);
		while (true)
		{
			cout << "\tWaiting..." << endl;
			int choose = rand() % 3;
			//Получаем данные от клиента и сохраняем
			//в переменной receiveMessage
			server.ReceiveData(receiveMessage, MAXSTRLEN);
			cout << "Received " << receiveMessage << endl;
			//Отправляем данные клиенту
			server.SendDataMessage(isComputer, &figures[choose][0]);
			string myFigure = figures[choose];
			string opponentFigure(receiveMessage);
			DetermineWinner(myFigure,opponentFigure);
			//Если есть сообщение "end", завершаем работу
			if (strcmp(receiveMessage, "end") == 0 || strcmp(sendMessage, "end") == 0)
				break;
		}
	}
	else if (nChoice == 2) {
		cout << "Enter an IP address: " << endl;
		//Запрашиваем IP сервера
		cin >> ipAddress;
		ClientSocket client;
		client.ConnectToServer(ipAddress.c_str(), port);
		while (true)
		{
			int choose = rand() % 3;
			//Отправляем сообщение
			client.SendDataMessage(isComputer, sendMessage);
			cout << "\tWaiting" << endl;
			//Получаем ответ
			client.ReceiveData(receiveMessage, MAXSTRLEN);
			cout << "Received: " << receiveMessage << endl;
			string myFigure(sendMessage);
			string opponentFigure(receiveMessage);
			DetermineWinner(myFigure, opponentFigure);
			if (strcmp(receiveMessage, "end") == 0 || strcmp(sendMessage, "end") == 0)
				break;
		}
		//Закрываем соединение
		client.CloseConnection();
	}
	else if (nChoice == 3)
		return 0;

}

void DetermineWinner(string myFigure, string opponentFigure) {
	if (myFigure == "Камень") {
		if (opponentFigure == "Ножницы") {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Я выиграл. " << endl;
		}
		else if (opponentFigure == "Бумага") {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Я проиграл. " << endl;
		}
		else if (myFigure == opponentFigure) {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Ничья. " << endl;
		}
	}
	else if (myFigure == "Ножницы") {
		if (opponentFigure == "Камень") {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Я проиграл. " << endl;
		}
		else if (opponentFigure == "Бумага") {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Я выиграл. " << endl;
		}
		else if (myFigure == opponentFigure) {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Ничья. " << endl;
		}
	}
	else if (myFigure == "Бумага") {
		if (opponentFigure == "Камень") {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Я выиграл. " << endl;
		}
		else if (opponentFigure == "Ножницы") {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Я проиграл. " << endl;
		}
		else if (myFigure == opponentFigure) {
			cout << "У меня  " << myFigure << ". У оппонента " << opponentFigure << ". Ничья. " << endl;
		}
	}
}

