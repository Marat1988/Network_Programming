using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public class Server
    {
        private Thread threadWatch = null; //Поток, отвечающий за мониторинг клиента
        private Socket socketWatch = null; //Сокет, отвечающий за пониторинг клиента
        private Socket socConnection = null; //Создаем сокет, отвечающий за связь с клиентом
        private string strAddr;
        private int port;

        public Server(string strAddr, int port)
        {
            this.strAddr = strAddr;
            this.port = port;
        }

        public void StartServer()
        {
            //Определяем сокет для отслеживания информации, отправляемой клиентом, включая 3 параметра (протокол адресации IP4, потоковое соединение, протокол TCP)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Серверу нужен IP-адрес и номер порта для отправки информации
            IPAddress iPAddress = IPAddress.Parse(strAddr); //Получить IP-адрес, введенный в текстовое поле
            //Привязываем ip-адрес и номер порта к конечной точке сетевого узла
            IPEndPoint endPoint = new IPEndPoint(iPAddress, port);
            //Отслеживаем привязанный сетевой узел
            socketWatch.Bind(endPoint);
            //Ограничиваем длину очереди прослушивания сокета до 20
            socketWatch.Listen(20);
            //Создаем поток слушателя
            threadWatch = new Thread(WatchConnection);
            //Устанавливаем поток формы для синхронизации с фоном
            threadWatch.IsBackground = true;
            //Запускаем поток
            threadWatch.Start();
            //После запуска потока отображаем информацию
            InfoMessage("Начать слушать информацию от клиента!" + "\r\n");
        }
        /// <summary>
        /// Слушаем запрос от клиента
        /// </summary>
        private void WatchConnection()
        {
            try
            {
                while (true) //Постоянно отслеживать запросы от клиента
                {
                    socConnection = socketWatch.Accept();
                    InfoMessage("Клиентское соединение " + socConnection.RemoteEndPoint + " успешно " + "\r\n");
                    //Создаем коммуникационный поток
                    ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                    Thread thr = new Thread(pts);
                    thr.IsBackground = true;
                    thr.Start(socConnection);
                }
            }
            catch (SocketException ex)
            {
                InfoMessage(ex.Message + "\r\n");
            }
        }
        /// <summary>
        /// Способ отправки информации клиенту
        /// </summary>
        /// <param name="sendMsg">Информация об отправленной строке</param>
        public void ServerSendMsg(string sendMsg)
        {
            if (socConnection == null)
            {
                InfoMessage("Клиент не определен" + "\r\n");
            }
            else
            {
                try
                {
                    //Преобразуем входную строку в массив байтов, который может распознать машина
                    byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                    //Отправляем клиенту информацию о байтовом массиве
                    socConnection.Send(arrSendMsg);
                    //Присоединяем отправленную строковую информацию
                    InfoMessage("Сервер: В " + DateTime.Now + " отправил " + sendMsg + "\r\n");
                }
                catch (SocketException ex)
                {
                    InfoMessage(ex.Message + "\r\n");
                }
            }
        }
        /// <summary>
        /// Получение информации от клиента
        /// </summary>
        /// <param name="socketClientPara">Объект клиентского сокета</param>
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //Создаем буфер памяти размером 1024X1024 байта, что составляет 1М
                    byte[] arrServerRecMsg = new byte[1024 * 1024];
                    int length = socketServer.Receive(arrServerRecMsg);
                    if (length==0 || socketServer.Connected == false)
                    {
                        InfoMessage("Связь с клиентов потеряна" + "\r\n");
                        break;
                    }
                    string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);
                    //Присоединяем отправленную строковую информацию
                    InfoMessage("Клиент: В " + DateTime.Now + " от " + socketServer.RemoteEndPoint + " получено: " + strSRecMsg + "\r\n");
                }
            }
            catch (SocketException ex)
            {
                InfoMessage(ex.Message + "\r\n");
            }
        }

        public void StopServer()
        {
            if (socConnection != null)
            {
                socConnection.Close();
                socConnection = null;
            }
            if (socketWatch != null)
            {
                socketWatch.Close();
                socketWatch = null;
            }
        }

        public event Action<string> InfoMessage;
    }
}
