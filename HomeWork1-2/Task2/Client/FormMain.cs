using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        //Создаем клиентский сокет, отвечающий за мониторинг запросов к серверу
        Socket socketClient = null;
        public FormMain()
        {
            InitializeComponent();
            //Закрываем проверку на недопустимую операцию потока в текстовом поле
            TextBox.CheckForIllegalCrossThreadCalls = false;
            buttonBeginListen.Click += ButtonBeginListen_Click;
            buttonSengMsg.Click += ButtonSengMsg_Click;
        }

        private void ButtonBeginListen_Click(object sender, EventArgs e)
        {
            try
            {
                //Определяем набор байтового мониторинга, включая 3 папаметра (прокотол адресации IP4, потоковое соединение, протокол TCP)
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //Нужно получить IP-адрес в текстовое поле
                IPAddress iPAddress = IPAddress.Parse(textBoxIPAdress.Text.Trim());
                //Привязываем полученный IP-адрес и номер порта к конечной точке сетевого узла
                IPEndPoint endPoint = new IPEndPoint(iPAddress, int.Parse(textBoxPort.Text.Trim()));
                //Здесь метод, используемый клиентским сокетом для подключения к сетевому узлу (серверу), - это Connect вместо Bind
                socketClient.Connect(endPoint);
            }
            catch (SocketException ex)
            {
                textBoxLogMsg.AppendText(ex.Message + "\r\n");
            }
        }
        /// <summary>
        /// Способ получения информации от сервера
        /// </summary>
        private void RecMsg()
        {
            try
            {
                //Определяем буфер папяти 1М для временного хранения полученной информации
                byte[] arrRecMsg = new byte[1024 * 1024];
                //Сохраняем данные, полученные клиентским сокетом, в буфер памяти и получаем их длину 
                int length = socketClient.Receive(arrRecMsg);
                //Преобразуем байтовый массив, полученный сокетом, в строке, понятную людям
                string strRecMsg = Encoding.UTF8.GetString(arrRecMsg, 0, length);
                //добавляем отправленную информацию в текстовое поле содержимого чата
                textBoxLogMsg.AppendText($"Сервер:\r\nОт " + socketClient.RemoteEndPoint.ToString() + " получена строка: " + strRecMsg + "\r\n");

            }
            catch (SocketException ex)
            {
                textBoxLogMsg.AppendText(ex.Message + "\r\n");
            }
        }

        private void ButtonSengMsg_Click(object sender, EventArgs e)
        {
            try
            {
                //Получаем все radioButton
                List<RadioButton> radioButtons = groupBoxChooseMsg.Controls.OfType<RadioButton>().ToList();
                //Получаем текстовку сообщения
                string msg = radioButtons.SingleOrDefault(radioButton => radioButton.Checked).Text;
                //Преобразуем входную строку в массив байтов, который может распознать машина
                byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(msg);
                //Вывоз клиентского сокета для отправки байтового массива
                socketClient.Send(arrClientSendMsg);
                //Добавляем отправленную информацию в текстовое поле содержимого чата
                textBoxLogMsg.AppendText("Марат:\r\nВ " + DateTime.Now + " отправил сообщение: " + msg + "\r\n");
                RecMsg();
            }
            catch (Exception ex)
            {
                textBoxLogMsg.AppendText(ex.Message + "\r\n");
            }
        }
    }
}
