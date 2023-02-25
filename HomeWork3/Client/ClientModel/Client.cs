using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client.ClientModel
{
    public class Client
    {
        private string ipAddress;
        private int port;
        private TcpClient client;
        private NetworkStream stream;

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
                    //Подключаем поток для чтения и записи
                    stream = client.GetStream();
                }
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
            //Получаем ответ от сервера
            //Буфер для хранения принятого массива bytes.
            byte[] data1 = new byte[1024];
            //Читаем сообщение
            Int32 bytes = stream.Read(data1, 0, data1.Length);
            string responseData = Encoding.UTF8.GetString(data1, 0, bytes);
            InfoMessage("От сервера получено в " + DateTime.Now + " сообщение " + responseData);
        }

        public event Action<string> InfoMessage;
    }
}
