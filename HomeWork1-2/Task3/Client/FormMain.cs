using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        //Создаем клиентский сокет и поток, отвечающий за мониторинг запросов к серверу
        Socket socketClient = null;
        Thread threadClient = null;

        public FormMain()
        {
            InitializeComponent();
            //Закрываем проверку на недопустимую операцию потока в текстовое поле
            TextBox.CheckForIllegalCrossThreadCalls = false;
            buttonBeginListen.Click += ButtonBeginListen_Click;
            buttonSengMsg.Click += ButtonSengMsg_Click;
        }

        private void ButtonBeginListen_Click(object sender, EventArgs e)
        {
            //Определякем набор байтового мониторинга, включая 3 параметра (протокол адресации IP4, потоковое соединение, протокол TCP)
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Нужно получить IP-адрес в текстовом поле
            IPAddress iPAddress = IPAddress.Parse(textBoxIPAdress.Text.Trim());
            //Привязывваем полученный IP-адрес и номер порта к конечной точке сетевого узла
            IPEndPoint endPoint = new IPEndPoint(iPAddress, int.Parse(textBoxPort.Text.Trim()));
            //Здесь метод, используемый клиентским сокетом для подключения к сетевому узлу (серверу), - это Connect вместо Bind
            socketClient.Connect(endPoint);
            //Создаем поток для отслеживания сообщений, отправляемых сервером
            threadClient = new Thread(RecMsg);
            //Устанавливаем поток формы для синхронизации с фоном
            threadClient.IsBackground = true;
            //Запускаем поток
            threadClient.Start();
        }
        /// <summary>
        /// Способ получения информации от сервера
        /// </summary>
        private void RecMsg()
        {
            while (true) //Постоянно отслеживать сообщения с сервера
            {
                //Определяем буфер памяти 1М для временного хранения полученной информации
                byte[] arrRecMsg = new byte[1024 * 1024];
                //Сохраняем данные, полученные клиентским сокетом в буфер памяти и получаем их длину
                int length = socketClient.Receive(arrRecMsg);
                //Преобразуем байтовый массив, полученный сокетом в строку, понятную людям
                string strRecMsg = Encoding.UTF8.GetString(arrRecMsg, 0, length);
                //Добавляем отправленную информацию в текстовое полу содержимого чата
                textBoxLogMsg.AppendText("Сервер:\nВ " + DateTime.Now + " отправил " + strRecMsg + "\r\n");
            }
        }
        /// <summary>
        /// Метод отпавки строковой информации на сервер
        /// </summary>
        /// <param name="sendMsg">Информация от отправленной строке</param>
        private void ClientSendMsg(string sendMsg)
        {
            //Преобразуем входную строку в массив байтов, который может распознать машина
            byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //Вызов клиентского сокета для отправки байтового массива
            socketClient.Send(arrClientSendMsg);
            //Добавляем отправленную информацию в текстовое поле содежимого чата
            textBoxLogMsg.AppendText("Марат:\nВ " + DateTime.Now.ToString() + " отправил " + sendMsg + "\r\n");
        }
        //Кнопка отправки информации на сервер
        private void ButtonSengMsg_Click(object sender, EventArgs e)
        {
            //Вызов метода для отправки информации, введенный в текстовое поле, на сервер
            ClientSendMsg(textBoxSendMsg.Text.Trim());
        }
    }
}
