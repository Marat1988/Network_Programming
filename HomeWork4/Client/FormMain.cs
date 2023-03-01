using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        UdpClient uclient = new UdpClient();
        public FormMain()
        {
            InitializeComponent();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            buttonSendMessage.Click += ButtonSendMessage_Click;
        }

        private void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(textBoxIPAddress.Text), Convert.ToInt32(textBoxPort.Text));
            try
            {
                              byte[] bytes = Encoding.UTF8.GetBytes(textBoxSendMessage.Text);
                                uclient.Send(bytes, bytes.Length,iPEndPoint);

            }
            catch (SocketException ex)
            {
                listBoxLog.Items.Add(ex.Message);
            }
            catch (Exception ex)
            {
                listBoxLog.Items.Add(ex.Message);
            }
        }

        private void buttonSendMessage_Click_1(object sender, EventArgs e)
        {

        }
    }
}
