using System.Net.Sockets;

namespace ServerListener.ServerModel
{
    public class User
    {
        public TcpClient TcpClient { get; }
        public int CountRequests { get; set; }

        public User(TcpClient tcpClient, int countRequests)
        {
            this.TcpClient = tcpClient;
            this.CountRequests = countRequests;
        }
    }
}
