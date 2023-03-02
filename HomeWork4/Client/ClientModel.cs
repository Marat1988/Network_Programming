using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientModel
    {
        private string ipAddress;
        private int port;
        UdpClient uclient;

        public ClientModel(string ipAddress, int port, UdpClient uclient)
        {
            this.ipAddress = ipAddress;
            this.port = port;
            this.uclient = uclient;
        }

        public void sendMessage(string message)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                uclient.Send(bytes, bytes.Length, iPEndPoint);

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
