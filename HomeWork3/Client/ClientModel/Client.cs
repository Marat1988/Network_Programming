using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
                //Получаем ответ от сервера
                //Буфер для хранения принятого массива bytes.
                data = new byte[1024];
                //Строка для хранения полученных данных
                string responseData = String.Empty;
                //Читаем сообщение
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.UTF8.GetString(data, 0, bytes);
                InfoMessage("От сервера получено в " + DateTime.Now + " сообщение " + responseData);
                stream.Close();
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


        public event Action<string> InfoMessage;
    }
}
