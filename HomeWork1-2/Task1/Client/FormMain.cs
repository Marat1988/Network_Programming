using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        //Создаем клиентский сокет и поток, отвечающий за мониторинг запросов к севреру
        Socket socketClient = null;
        Thread threadClient = null;

        public FormMain()
        {
            InitializeComponent();
            //Закрываем проверку на недопустимую опеерацию потока в текстовом поле
            TextBox.CheckForIllegalCrossThreadCalls = false;
            buttonBeginListen.Click += ButtonBeginListen_Click;
            buttonSengMsg.Click += ButtonSengMsg_Click;
            textBoxSendMsg.KeyDown += TextBoxSendMsg_KeyDown;
        }

        private void ButtonBeginListen_Click(object sender, EventArgs e)
        {
            //Определчем набор байтового мониторинга, включая 3 параметра (протокол адресации IP4, потоковое соединение, протокол TCP)
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Нужно получить IP-адрес в текстовое поле
            IPAddress iPAddress = IPAddress.Parse(textBoxIPAdress.Text.Trim());
            //Привязываем полученный IP-адрес и номер порта к конечной точке сетевого узла
            IPEndPoint endPoint = new IPEndPoint(iPAddress, int.Parse(textBoxPort.Text.Trim()));
            //Здесь метод, используемый клиентским сокетом для подключения к сетевому узлу (серверу), - это Connect вместо Bind
            socketClient.Connect(endPoint);
            //Создаем поток для отслеживания сообщений, отправляемый сервером
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
                //Определяем буфер памяти 1M для временного хранения полученной информации
                byte[] arrRecMgs = new byte[1024 * 1024];
                //Сохраняем данные, полученные клиентским сокетом, в буфер памяти и получаем их длину
                int length = socketClient.Receive(arrRecMgs);
                //Преобразуем байтовый массив, полученный сокетом, в строку, понятную людям
                string strRecMsg = Encoding.UTF8.GetString(arrRecMgs, 0, length);
                //Добавляем отправленную информацию в текстовое поле содержимого чата
                textBoxLogMsg.AppendText($"Сервер:\r\nВ " + GetCurrentTime().ToLongTimeString() + " от " + socketClient.RemoteEndPoint.ToString() + " получена строка: " + strRecMsg + "\r\n");
            }
        }

        /// <summary>
        /// Метод отправки строковой информации на сервер
        /// </summary>
        /// <param name="sendMsg">Информация об отправленной строке</param>
        private void ClientSendMsg(string sendMsg)
        {
            //Преобразуем входнуюб строку в массив байтов, который может распознать машина
            byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //Вызов клиентского сокета для отправки байтового массива
            socketClient.Send(arrClientSendMsg);
            //Добавляем отправленную информацию в текстовое поле содержимого чата
            textBoxLogMsg.AppendText("Марат:\r\nВ " + GetCurrentTime().ToLongTimeString() + " отправил сообщение: " + sendMsg + "\r\n");
        }
        //Кнопка для отправки информации на сервер
        private void ButtonSengMsg_Click(object sender, EventArgs e)
        {
            //Вызов метода ClientSendMsg для отправки информации, введенной в текстовое поле, на сервер
            ClientSendMsg(textBoxSendMsg.Text.Trim());
        }

        //Сочетание клавиши Enter для отправки информации
        private void TextBoxSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            //Когда курсор находится в текстовом поле, если пользователь нажимает клавишу Enter на клавиатуре
            if (e.KeyCode == Keys.Enter)
            {
                //Вызываем клиента для отправки информации на сервер
                ClientSendMsg(textBoxSendMsg.Text.Trim());
            }
        }

        /// <summary>
        /// Как получить текущее системное время
        /// </summary>
        /// <returns>текущее время</returns>
        private DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }
    }
}
