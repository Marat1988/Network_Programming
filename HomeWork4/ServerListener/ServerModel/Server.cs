using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerListener.ServerModel
{
    public class Server
    {
        private Socket udpSocket;
        private string ipAdress;
        private int port;

        public Server(string ipAdress, int port)
        {
            this.ipAdress = ipAdress;
            this.port = port;
        }

        public void StartServer()
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
                    InfoMessage("Сервер: В " + DateTime.Now + " от " + Remote.ToString() + " получена строка: " + Encoding.UTF8.GetString(data, 0, length));
                    UdpClient client = new UdpClient((IPEndPoint)Remote);
 






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

        private void sendMessage(UdpClient udpClient, string message)
        {

        }

        public event Action<string> InfoMessage;
    }
}
