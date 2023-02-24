using Client.ClientModel;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client.ClientModel
{

    public class Client
    {
        private Socket socketClient = null;
        private Thread threadClient = null;
        private string ipAddr;
        private int port;
        private WhoIsConnect whoIsConnect;
        public Client(string ipAddr, int port, WhoIsConnect whoIsConnect)
        {
            this.ipAddr = ipAddr;
            this.port = port;
            this.whoIsConnect = whoIsConnect;
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
                InfoMessage(ex.Message + "\r\n");
            }
        }
        /// <summary>
        /// Способ получения информации от сервера
        /// </summary>
        private void RecMsg()
        {
            try
            {
                AutoAnswer();
                while (socketClient!=null) //Постоянно отслеживать сообщения с сервера
                {
                    //Определяем буфер памяти 1М для временного хранения полученной информации
                    byte[] arrRecMsg = new byte[1024 * 1024];
                    //Созраняем данные, полученные клиентским сокетом в буфер памяти и получаем их длину
                    int length = socketClient.Receive(arrRecMsg);
                    if (length==0 || socketClient.Connected == false)
                    {
                        InfoMessage("Связь с сервером потеряна" + "\r\n");
                        break;
                    }
                    //Преобразуем байтовый массив, полученной сокетом в строку, понятную людям
                    string strRecMsg = Encoding.UTF8.GetString(arrRecMsg, 0, length);
                    //Добавляем отправленную информацию в текстовое поле
                    InfoMessage("Сервер: В " + DateTime.Now + " отправил " + strRecMsg + "\r\n");
                    AutoAnswer();
                }
            }
            catch (SocketException ex)
            {
                InfoMessage(ex.Message + "\r\n");
            }
        }
        /// <summary>
        /// Метод отправки строковой информации на сервер
        /// </summary>
        /// <param name="sendMsg">Информация об отправленной строке</param>
        public void ClientSendMsg(string sendMsg)
        {
            if (whoIsConnect == WhoIsConnect.computer)
            {
                InfoMessage("Включен режим компьютера" + "\r\n");
            }
            else
            {
                try
                {
                    //Преобразуем входную строку в массив байтов, которая может распознать машина
                    byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                    //Вызов клиентского сокета для отправки байтового массива
                    socketClient.Send(arrClientSendMsg);
                    //Добавляем отправленную информацию в текстовое поле содержимого чата
                    InfoMessage("Марат: В " + DateTime.Now.ToString() + " отправил " + sendMsg + "\r\n");
                    if (sendMsg == "bye")
                        CloseClient();
                }
                catch (Exception ex)
                {
                    InfoMessage(ex.Message + "\r\n");
                }
            }
        }

        private void AutoAnswer()
        {
            //Если компьютер, то тупо отвечаем
            if (whoIsConnect == WhoIsConnect.computer)
            {
                Thread.Sleep(1500);
                int answer = new Random().Next(Word.words.Length);
                byte[] arrSendMsg = Encoding.UTF8.GetBytes(Word.words[answer]);
                socketClient?.Send(arrSendMsg);
                InfoMessage("Марат: В " + DateTime.Now + " отправил " + Word.words[answer] + "\r\n");
                if (Word.words[answer] == "bye")
                    CloseClient();

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

        public event Action<string> InfoMessage;
    }
}
