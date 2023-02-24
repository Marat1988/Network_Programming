using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client
{
    public class Client
    {
        private Socket socketClient = null;
        private Thread threadClient = null;
        private string ipAddr;
        private int port;

        public Client(string ipAddr, int port)
        {
            this.ipAddr = ipAddr;
            this.port = port;
        }

        public void Start()
        {
            try
            {
                //Определяем набор байтового мониторинга, включая 3 параметра (протокол адресации IP4, потоковое соединение, протокол TCP)
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //Нужно получить IP-адрес в текстовое поле
                IPAddress iPAddress = IPAddress.Parse(ipAddr);
                //Привязываем полученный IP-адрес и номер порта к конечной точке сетевого узла
                IPEndPoint endPoint = new IPEndPoint(iPAddress, port);
                //Здесь метод, используемый клиентским сокетом для подключения к сетевому узну (серверу), - это Connect вместо Bind
                socketClient.Connect(endPoint);
                //Создаем поток для отслеживания сообщений, отправляемых сервером
                threadClient = new Thread(RecMsg);
                //Устанавливаем поток формы для синхронизации с фоном
                threadClient.IsBackground = true;
                //Запускаем поток
                threadClient.Start();
            }
            catch (SocketException ex)
            {
                infoMessage(ex.Message + "\r\n");
            }
        }
        /// <summary>
        /// Способ получения информации от сервера
        /// </summary>
        private void RecMsg()
        {
            try
            {
                while (true) //Постоянно отслеживать сообщения с сервера
                {
                    //Определяем буфер памяти 1М для временного хранения полученной информации
                    byte[] arrRecMsg = new byte[1024 * 1024];
                    //Созраняем данные, полученные клиентским сокетом в буфер памяти и получаем их длину
                    int length = socketClient.Receive(arrRecMsg);
                    if (length==0 || socketClient.Connected == false)
                    {
                        infoMessage("Связь с сервером потеряна" + "\r\n");
                        break;
                    }
                    //Преобразуем байтовый массив, полученной сокетом в строку, понятную людям
                    string strRecMsg = Encoding.UTF8.GetString(arrRecMsg, 0, length);
                    //Добавляем отправленную информацию в текстовое поле
                    infoMessage("Сервер: В " + DateTime.Now + " отправил " + strRecMsg + "\r\n");
                }
            }
            catch (SocketException ex)
            {
                infoMessage(ex.Message + "\r\n");
            }
        }
        /// <summary>
        /// Метод отправки строковой информации на сервер
        /// </summary>
        /// <param name="sendMsg">Информация об отправленной строке</param>
        public void ClientSendMsg(string sendMsg)
        {
            try
            {
                //Преобразуем входную строку в массив байтов, которая может распознать машина
                byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                //Вызов клиентского сокета для отправки байтового массива
                socketClient.Send(arrClientSendMsg);
                //Добавляем отправленную информацию в текстовое поле содержимого чата
                infoMessage("Марат: В " + DateTime.Now.ToString() + " отправил " + sendMsg + "\r\n");
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message + "\r\n");
            }
        }

        public void CloseClient()
        {
            if (socketClient != null)
            {
                socketClient.Close();
                socketClient = null;
            }
        }

        public event Action<string> infoMessage;
    }
}
