using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerListener.ServerModel
{
    public class Server
    {
        private Socket udpSocket;
        private string ipAdress;
        private int port;
        public Image caesarSalad { get; set; }
        public Server(string ipAdress, int port)
        {
            this.ipAdress = ipAdress;
            this.port = port;
        }
        /// <summary>
        /// Запуск UPD-сервера
        /// </summary>
        public void StartServer()
        {
            try
            {
                udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                udpSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, true);
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ipAdress), port);
                udpSocket.Bind(iPEndPoint);
                Thread thread = new Thread(WatchConnection);
                thread.IsBackground = true;
                thread.Start();
                InfoMessage("UPD-сервер запущен");
            }
            catch (SocketException ex)
            {
                InfoMessage("Ошибка сокета: " + ex.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }
        /// <summary>
        /// Метод, отвечающий за прием клиентов
        /// </summary>
        /// <param name="udpClientServer"></param>
        private void WatchConnection()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                    EndPoint Remote = (EndPoint)(sender);
                    int length = udpSocket.ReceiveFrom(data, ref Remote);
                    string messageClient = Encoding.UTF8.GetString(data, 0, length);
                    InfoMessage("Сервер: В " + DateTime.Now + " от " + Remote.ToString() + " получена строка: " + messageClient);
                    UdpClient client = new UdpClient();
                    sendMessage(client, (IPEndPoint)Remote, Products.getRecipe(messageClient));
                    if (messageClient == "Салат Цезарь") //Отправка изображения
                    {
                        sendImage((IPEndPoint)Remote);
                    }

                }
            }
            catch (SocketException ex)
            {
                InfoMessage("Ошибка сокета: " + ex.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }

        private void sendImage(IPEndPoint iPEndPoint)
        {
            try
            {
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                MemoryStream ms = new MemoryStream();
                Bitmap bmp = new Bitmap(caesarSalad);
                bmp.Save(ms, ImageFormat.Jpeg);
                byte[] byteArray = ms.ToArray();
                int n = server.Available;
                server.Connect(iPEndPoint);
                server.SendTo(byteArray, iPEndPoint);
            }
            catch (SocketException ex)
            {
                InfoMessage("Ошибка сокета: " + ex.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }

        /// <summary>
        /// Метод отправки сообщения клиенту
        /// </summary>
        /// <param name="udpClient">UdpClient для отправки сообщения</param>
        /// <param name=iPEndPoint">Удаоенный порт клиента</param>
        /// <param name="message">Сообщение</param>
        private void sendMessage(UdpClient udpClient, IPEndPoint iPEndPoint, string message)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                udpClient.Send(bytes, bytes.Length, iPEndPoint);
                InfoMessage("Сервер: В " + DateTime.Now + iPEndPoint.ToString() + " отправил сообщение: " + message);
            }
            catch (SocketException ex)
            {
                InfoMessage("Ошибка сокета: " + ex.Message);
            }
            catch (Exception ex)
            {
                InfoMessage("Ошибка: " + ex.Message);
            }
        }

        public event Action<string> InfoMessage;
    }
}
