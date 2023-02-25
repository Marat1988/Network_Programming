using System;
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

        public Server(string ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;
        }

        //Запуск сервера
        public void StartServer()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Parse(ipAddress),port); //Создание зкземпляра слушателя
                tcpListener.Start(); //Начало прослушивания клиентов
                //Создаем отдельный поток для чтения сообщения
                Thread thread = new Thread(ThreadFun);
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

        private void ThreadFun()
        {          
            while (true)
            {
                //Сервер сообщает клиенту о готовности к соединению
                TcpClient client = tcpListener.AcceptTcpClient();
                InfoMessage("Сервер: В " + DateTime.Now + " к нам подключился " + client.Client.RemoteEndPoint);
                // буфер для получения данных
                byte[] responseData = new byte[1024];
                //Получаем информацию от клиента
                NetworkStream stream = client.GetStream();
                //Считываем длину данных
                int length = stream.Read(responseData, 0, responseData.Length);
                //Преобразуем данные в понятную людям кодировку
                string clientInfo = Encoding.UTF8.GetString(responseData, 0, length);
                InfoMessage("От клиента " + client.Client.RemoteEndPoint + " получен запрос " + clientInfo);
                //Узнаем курс
                string kursInfo = InfoKurs.getInfoKurs(clientInfo);
                if (kursInfo != null)
                {
                    //Преобразуем данные по курсу в массив байт
                    byte[] msg = Encoding.UTF8.GetBytes(kursInfo);
                    //Отправляем данные обратно клиенту (ответ)
                    stream.Write(msg, 0, msg.Length);
                    InfoMessage("Сервер: В " + DateTime.Now + " отправил " + client.Client.RemoteEndPoint + " " + kursInfo);
                }
            }

        }

        public event Action<string> InfoMessage;
    }
}
