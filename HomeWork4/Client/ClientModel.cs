using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

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
            Thread thread = new Thread(ServerMessageListener);
            thread.IsBackground = true;
            thread.Start();
        }
        /// <summary>
        /// Слушатель сообщений от сервера
        /// </summary>
        public void ServerMessageListener()
        {
            try
            {
                while (true)
                {
                    IPEndPoint iPEnd = null;
                    //получание дейтаграммы
                    byte[] responce = uclient.Receive(ref iPEnd);
                    InfoMessage("От сервера в " + DateTime.Now + " получена строка: " + Encoding.UTF8.GetString(responce));
                    try
                    {
                        ImageConverter convertData = new ImageConverter();
                        Image image = (Image)convertData.ConvertFrom(responce);
                        SetImages(image);
                    }
                    catch (Exception ex){}
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
        /// <summary>
        /// Отправка сообщение серверу
        /// </summary>
        /// <param name="message"></param>
        public void sendMessage(string message)
        {
            try
            {
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
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

        public event Action<Image> SetImages;
    }
}
