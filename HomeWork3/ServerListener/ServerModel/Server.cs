using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerListener.ServerModel
{
    public class Server
    {
        private TcpListener tcpListener; //слушатель подключений от TCP-клиентов
        private string ipAddress; //Ip-адрес
        private int port; //Номер порта
        private int maxRequestsUser; //Максимальное количество запросов
        private delegate void SendMessageUser(string message);
        private List<User> clients; //Подключенные клиенты

        public Server(string ipAddress, int port, int maxRequestsUser)
        {
            this.ipAddress = ipAddress;
            this.port = port;
            this.maxRequestsUser = maxRequestsUser;
            clients = new List<User>();
        }

        //Запуск сервера
        public void StartServer()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Parse(ipAddress),port); //Создание зкземпляра слушателя
                tcpListener.Start(); //Начало прослушивания клиентов
                //Создаем отдельный поток для мониторинга подключений
                Thread thread = new Thread(WatchConnection);
                thread.IsBackground = true; //Устанавливаем поток формы для синхронизации с фоном
                thread.Start(); //Запускаем поток
                InfoMessage("Сервер запущен!");
            }
            catch (SocketException sockEx)
            {
                InfoMessage("Ошибка сокета: " + sockEx.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }
        /// <summary>
        /// Мониторинг подключений клиентов
        /// </summary>
        private void WatchConnection()
        {
            try
            {
                while (true)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    SendMessage("Hello", client);
                    InfoMessage("Сервер: В " + DateTime.Now + " к нам подключился " + client.Client.RemoteEndPoint);
                    clients.Add(new User(client, 0)); //Добавляем клиентов в массив
                    //Создаем поток для принятия и отправки сообщений
                    ParameterizedThreadStart pts = new ParameterizedThreadStart(ThreadMessage);
                    Thread thread = new Thread(pts);
                    thread.IsBackground = true;
                    thread.Start(client);
                }
            }
            catch (SocketException sockEx)
            {
                InfoMessage("Ошибка сокета: " + sockEx.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }
        /// <summary>
        /// Поток, отвечающий за связь с клиентои
        /// </summary>
        /// <param name="socketClientPara">Клиент</param>
        private void ThreadMessage(object socketClientPara)
        {
            TcpClient client = socketClientPara as TcpClient;
            try
            {
                while (true)
                {
                    // буфер для получения данных
                    byte[] responseData = new byte[1024];
                    //Получаем информацию от клиента
                    NetworkStream stream = client.GetStream();
                    //Считываем длину данных
                    int length = stream.Read(responseData, 0, responseData.Length);
                    var findClient = clients.Find(user => user.TcpClient.Client.RemoteEndPoint == client.Client.RemoteEndPoint);
                    findClient.CountRequests++;
                    //Если полученный пакет данных равен нулю, то значит клиент оборвался или отключился
                    if (client.Available == 0 && client.Client.Poll(1, SelectMode.SelectRead))
                    {
                        InfoMessage("Клиент " + client.Client.RemoteEndPoint + " отключился от сети или связь оборвана");
                        stream.Close();
                        client.Close();
                        clients.Remove(findClient);
                        break;
                    }
                    //Преобразуем данные в понятную людям кодировку
                    string clientInfo = Encoding.UTF8.GetString(responseData, 0, length);
                    InfoMessage("От клиента " + client.Client.RemoteEndPoint + " получен запрос " + clientInfo);
                    if (findClient.CountRequests > maxRequestsUser)
                    {
                        SendMessage("Вы превысили максимальное количество запросов. Вы будете отключены", client);
                        InfoMessage("Сервер: В " + DateTime.Now + " отключил клиента " + client.Client.RemoteEndPoint);
                        stream.Close();
                        client.Close();
                        clients.Remove(findClient);
                        break;
                    }
                    else
                    {
                        //Узнаем курс
                        string kursInfo = InfoKurs.getInfoKurs(clientInfo);
                        if (kursInfo != null)
                        {
                            SendMessage(kursInfo, client);
                        }
                    }
                }
            }
            catch (SocketException sockEx)
            {
                InfoMessage("Ошибка сокета: " + sockEx.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }
        /// <summary>
        /// Иетод отправки клиенту сообщения
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="tcpClient">TCP-клиент</param>
        private void SendMessage(string message, TcpClient tcpClient)
        {
            //Преобразуем данные по курсу в массив байт
            byte[] msg = Encoding.UTF8.GetBytes(message);
            //Отправляем данные обратно клиенту (ответ)
            tcpClient.GetStream().Write(msg, 0, msg.Length);
            InfoMessage("Сервер: В " + DateTime.Now + " отправил " + tcpClient.Client.RemoteEndPoint + " " + message);
        }

        public void CloseServer()
        {
            if (tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }
        }

        public event Action<string> InfoMessage;
    }
}
