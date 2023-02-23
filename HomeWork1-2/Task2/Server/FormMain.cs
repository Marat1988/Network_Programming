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
        Socket socketWatch = null; //Сокет, отвечающий за мониторинг клиента
        Socket socConnection = null; //Создаем сокет, отвечающий за связь с клиентом

        public FormMain()
        {
            InitializeComponent();
            //Закрыввем проверку на недопустимую операцию потока в текстовом поле
            TextBox.CheckForIllegalCrossThreadCalls = false;
            buttonServerStart.Click += ButtonServerStart_Click;
        }

        private void ButtonServerStart_Click(object sender, EventArgs e)
        {
            //Определяем сокет для отслеживания информации, отправляемой клиентом, включая 3 параметра (протокол адресации IP4, потоковое соединение, протокол TCP)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Серверу нужен IP-адрес и номер порта для отправки информации
            IPAddress iPAddress = IPAddress.Parse(textBoxIPAdress.Text.Trim()); //Получить IP-адрес, введенный в текстовое поле
            //Привязываем IP-адрес и номер порта к конечной точке сетевого узла
            IPEndPoint endPoint = new IPEndPoint(iPAddress, int.Parse(textBoxPort.Text.Trim())); //Получить номер порта, введенный в текстовое поле
            //Отслеживаем привязанный сетевой узел
            socketWatch.Bind(endPoint);
            //Органичиваем длину очереди прослушивания сокета до 20
            socketWatch.Listen(20);
            //Создаем поток слушателя
            threadWatch = new Thread(WatchConnection);
            //Устанавливаем поток формы для синхронизации с фоном
            threadWatch.IsBackground = true;
            //Запускаем поток
            threadWatch.Start();
            //После запуска потока в текстовое поле вводим информацию
            textBoxLogMsg.AppendText("Начать слушать информацию от клиента!" + "\r\n");
        }
        /// <summary>
        /// Слушаем запрос от клиента
        /// </summary>
        private void WatchConnection()
        {
            socConnection = socketWatch.Accept();
            if (socConnection.Connected)
            {
                try
                {
                    textBoxLogMsg.AppendText("Клиентское соединение от " + socConnection.RemoteEndPoint.ToString() + "\r\n");
                    //Создаем буфер памяти размером 1024 * 1024 байта, что составляет 1М
                    byte[] arrServerRecMsg = new byte[1024 * 1024];
                    //Сохраняем полученную информацию в буфер памяти и возвращаем длину ее байтового массива
                    int length = socConnection.Receive(arrServerRecMsg);
                    //Преобразуем байтовый массив, полученной машиной, в строку памяти и возвращаем длину ее байтового массива
                    string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);
                    switch (strSRecMsg)
                    {
                        case "GET DATE":
                            socConnection.Send(Encoding.UTF8.GetBytes(DateTime.Now.ToLongDateString()));
                            textBoxLogMsg.AppendText("Клиент запросил текущую дату. Отправляю ему информацию." + "\r\n");
                            break;
                        case "GET TIME":
                            socConnection.Send(Encoding.UTF8.GetBytes(DateTime.Now.ToLongTimeString()));
                            textBoxLogMsg.AppendText("Клиент запросил текущее время. Отправляю ему информацию" + "\r\n");
                            break;
                    }
                    socConnection.Shutdown(SocketShutdown.Both);
                    socConnection.Close();
                    textBoxLogMsg.AppendText("Отключаюсь" + "\r\n");
                }
                catch (Exception ex)
                {
                    textBoxLogMsg.AppendText(ex.Message + "\r\n");
                }
                finally
                {
                    socketWatch.Close();
                }
            }        
        }
    }
}
