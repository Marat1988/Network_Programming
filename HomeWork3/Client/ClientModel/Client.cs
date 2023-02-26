using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client.ClientModel
{
    public class Client
    {
        private string ipAddress;
        private int port;
        private TcpClient client;

        public Client(string ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;
        }
        /// <summary>
        /// Подключение к серверу
        /// </summary>
        public void ConnectToServer()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
                client = new TcpClient();
                //Установка соединения с использованием данных IP и номера порта
                client.Connect(endPoint);
                if (client.Connected)
                {
                    InfoMessage("Клиент " + DateTime.Now + " успешно подключился к серверу ");
                }
                GetInfoMessageServer();
            }
            catch (SocketException sockEx)
            {
                InfoMessage("Ошибка сокета: " + sockEx?.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }
        /// <summary>
        /// Отправка сообщений
        /// </summary>
        /// <param name="message">текстовая строка</param>
        public void SendMessage(string message)
        {
            try
            {
                //Переводим наше сообщение в массив байтов, который сможет распознать машина
                byte[] data = Encoding.UTF8.GetBytes(message);
                //Подключаем поток для чтения и записи
                NetworkStream stream = client.GetStream();
                //Отправляем сообщение серверу
                stream.Write(data, 0, data.Length);
                InfoMessage("Клиент: В " + DateTime.Now + " отправил " + message);
                //Создаем отдельный поток для получения сообщений
                Thread thread = new Thread(GetInfoMessageServer);
                thread.Start();
            }
            catch (SocketException sockEx)
            {
                InfoMessage("Ошибка сокета: " + sockEx?.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }
        /// <summary>
        /// Получение сообщений с сервера
        /// </summary>
        private void GetInfoMessageServer()
        {
            try
            {
                //Получаем ответ от сервера
                //Буфер для хранения принятого массива bytes.
                byte[] dataFromServer = new byte[1024];
                //Читаем сообщение
                Int32 bytes = client.GetStream().Read(dataFromServer, 0, dataFromServer.Length);
                string responseData = Encoding.UTF8.GetString(dataFromServer, 0, bytes);
                InfoMessage("От сервера получено в " + DateTime.Now + " сообщение " + responseData);
            }
            catch (SocketException sockEx)
            {
                InfoMessage("Ошибка сокета: " + sockEx?.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }

        }
        /// <summary>
        /// Отключение от сервера
        /// </summary>
        public void DicconectFromServer()
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }
        }

        public event Action<string> InfoMessage;
    }
}
