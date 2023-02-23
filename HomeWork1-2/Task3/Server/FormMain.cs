using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class FormMain : Form
    {
        Thread threadWatch = null; //Поток, отвечающий за мониторинг клиента
        Socket socketWatch = null; //Сокет, отвечающий за пониторинг клиента
        Socket socConnection = null; //Создаем сокет, отвечающий за связь с клиентом

        public FormMain()
        {
            InitializeComponent();
            //Закрываем проверку на недопустимую операцию потока в текстовом поле
            TextBox.CheckForIllegalCrossThreadCalls = false;
            buttonBeginStartServer.Click += ButtonBeginStartServer_Click;
            buttonSengMsg.Click += ButtonSengMsg_Click;
        }

        private void ButtonBeginStartServer_Click(object sender, EventArgs e)
        {
            //Определяем сокет для отслеживания информации, отправляемой клиентом, включая 3 параметра (протокол адресации IP4, потоковое соединение, протокол TCP)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Серверу нужен IP-адрес и номер порта для отправки информации
            IPAddress iPAddress = IPAddress.Parse(textBoxIPAdress.Text.Trim()); //Получить IP-адрес, введенный в текстовое поле
            //Привязываем ip-адрес и номер порта к конечной точке сетевого узла
            IPEndPoint endPoint = new IPEndPoint(iPAddress, int.Parse(textBoxPort.Text.Trim())); //получить номер порта, введенный в текстовое поле
            //Отслеживаем привязанный сетевой узел
            socketWatch.Bind(endPoint);
            //Ограничиваем длину очереди прослушивания сокета до 20
            socketWatch.Listen(20);
            //Создаем поток слушателя
            threadWatch = new Thread(WatchConnecting);
            //Устанавливаем поток формы для синхронизации с фоном
            threadWatch.IsBackground = true;
            //Запускаем поток
            threadWatch.Start();
            //После запуска потока в текстовое поле отображаем соответствующее приглашение
            textBoxLogMsg.AppendText("Начать слушать информацию от клиента!" + "\r\n");
        }
        /// <summary>
        /// Слушаем запрос от клиента
        /// </summary>
        private void WatchConnecting()
        {
            while (true) //Постоянно отслеживать запросы от клиента
            {
                socConnection = socketWatch.Accept();
                textBoxLogMsg.AppendText("Клиентское соединение успешно" + "\r\n");
                //Создаем коммуникационный поток
                ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                Thread thr = new Thread(pts);
                thr.IsBackground = true;
                thr.Start(socConnection); //Запускаем поток
            }
        }
        /// <summary>
        /// Способ отправки информации клиенту
        /// </summary>
        /// <param name="sendMsg">Информация об отправленной строке</param>
        private void ServerSendMsg(string sendMsg)
        {
            //Преобразуем входную строку в массив байтов, который может распознать машина
            byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //Отправляем клиенту информацию о байтовом массиве
            socConnection.Send(arrSendMsg);
            //Присоединяем отправленную строковую информацию к текстовому полю
            textBoxLogMsg.AppendText("Сервер:\nВ " + DateTime.Now + " отправил " + sendMsg + "\r\n");
        }

        /// <summary>
        /// Получение инофрмации от клиента
        /// </summary>
        /// <param name="socketClientPara">Объект клиентского сокета</param>
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;
            while (true)
            {
                //Создаем буфер памяти размером 1024X1024 байта, что составляет 1М
                byte[] arrServerRecMsg = new byte[1024 * 1024];
                int length = socketServer.Receive(arrServerRecMsg);
                //Преобразуем байтовый массив, полученный машиной в строку, которая может быть прочитана людьми
                string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);
                //Присоединяем отправленную строковую информаци к текстовому полю
                textBoxLogMsg.AppendText("Клиент:\nВ " + DateTime.Now + " отправил " + strSRecMsg + "\r\n");
            }
        }
        //Отправляем информацию клиенту
        private void ButtonSengMsg_Click(object sender, EventArgs e)
        {
            //Вызов метода для отправки инофрмации клиенту
            ServerSendMsg(textBoxSendMsg.Text.Trim());
        }
    }
}
