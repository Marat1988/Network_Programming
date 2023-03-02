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
        UdpClient uclient = new UdpClient(new Random().Next(65536));
        public FormMain()
        {
            InitializeComponent();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            buttonSendMessage.Click += ButtonSendMessage_Click;
        }

        private void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            ClientModel clientModel = new ClientModel(textBoxIPAddress.Text, int.Parse(textBoxPort.Text), uclient);
            clientModel.InfoMessage += ClientModel_InfoMessage;
            clientModel.SetImages += ClientModel_SetImages;
            clientModel.sendMessage(textBoxSendMessage.Text);
        }

        private void ClientModel_SetImages(Image image)
        {
            pictureBox1.Image = image;
        }

        private void ClientModel_InfoMessage(string infoMessage)
        {
            listBoxLog.Items.Add(infoMessage);
        }

    }
}
