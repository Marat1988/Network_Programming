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

namespace Server
{
    public partial class FormMain : Form
    {
        Thread threadWatch = null; //Поток, отвечающий за мониторинг клиента
        Socket socketWatch = null; //Сокет, отвечающий за мониторинг клиента
        Socket socConnection = null; //Создаем сокет, отвечющий за связь с клиентом

        public FormMain()
        {
            InitializeComponent();
            //Закрываем проверку на недопустимую операцию потока в текстовом поле
            TextBox.CheckForIllegalCrossThreadCalls = false;
            buttonServerConn.Click += ButtonServerConn_Click;
        }

        private void ButtonServerConn_Click(object sender, EventArgs e)
        {
            //Определяем сокет для отслеживание информации, отправляемой клиентом, включая 3 параметра (протокол адресации IP4, потоковое соединение, протокол TCP)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Серверу нужен IP-адрес и номер порта для отправки информации
            IPAddress iPAddress = IPAddress.Parse(textBoxIPAdress.Text.Trim()); //Получить IP-адрес, введенный в текстовое поле
            //Привязываем IP-адрес и номер порта к конечной точке сетевого узла
            IPEndPoint endPoint = new IPEndPoint(iPAddress, int.Parse(textBoxPort.Text.Trim())); //Получить номер порта, введенный в текстовое поле
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
            //После запуска потока в текстовое поле 
            textBoxLogMsg.AppendText("Слушаю информацию от клиентов: " + "\r\n");
        }
        /// <summary>
        /// Слушаем запрос от клиента
        /// </summary>
        private void WatchConnecting()
        {
            while (true) //Постоянно отслеживать запросы от клиента
            {
                socConnection = socketWatch.Accept();
                textBoxLogMsg.AppendText("Клиентское соединение от " + socConnection.RemoteEndPoint.ToString() + "\r\n");
                //Создаем коммуникационный поток
                ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                Thread thr = new Thread(pts);
                thr.IsBackground = true;
                thr.Start(socConnection); //Запускаем поток
            }
        }

        /// <summary>
        /// Получание информации от клиента
        /// </summary>
        /// <param name="socketClientPara">Объект клиентского сокета</param>
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;
            while (true)
            {
                //Создаем буфер памяти размером 1024 * 1024 байта, что составляет 1М
                byte[] arrServerRecMsg = new byte[1024 * 1024];
                //Сохраняем полученную информацию в буфер памяти и возвращаем длину ее байтового массива
                int length = socketServer.Receive(arrServerRecMsg);
                //Преобразуем байтовый массив, полученной машиной, в строку, которая может быть прочитана людьми
                string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);
                //Присоединяем отправленную строковую информацию к текстовому полю textBoxLogMsg
                textBoxLogMsg.AppendText("Клиент:\r\nВ " + GetCurrentTime().ToLongTimeString() + " от " + socketServer.RemoteEndPoint.ToString() + " получена строка: " + strSRecMsg + "\r\n");
                //Сервер на все запросы тупо отвечает: "Привет, клиент!"
                ServerSendMsg("Привет, клиент!");
            }
        }

        /// <summary>
        /// Способ отправки инофрмации клиенту
        /// </summary>
        /// <param name="sendMsg">Информация об отправленной строке</param>
        private void ServerSendMsg(string sendMsg)
        {
            //Преобразуем входную строку в массив байтов, который может распознать машина
            byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //Отправляем клиенту инофрмацию о байтовом массиве
            socConnection.Send(arrSendMsg);
            //Присоединяем отправленную строковую информацию к текстовому полю textBoxLogMsg
            textBoxLogMsg.AppendText("Сервер:\r\nВ " + GetCurrentTime().ToLongTimeString() + " отправил сообщение: " + sendMsg + "\r\n");
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
