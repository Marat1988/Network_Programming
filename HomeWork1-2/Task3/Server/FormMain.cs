using Server.ModelServer;
using System;
using System.Windows.Forms;

namespace Server
{
    public partial class FormMain : Form
    {
        ModelServer.Server server;
        public FormMain()
        {
            InitializeComponent();
            //Закрываем проверку на недопустимую операцию потока в текстовом поле
            TextBox.CheckForIllegalCrossThreadCalls = false;
            buttonBeginStartServer.Click += ButtonBeginStartServer_Click;
            buttonSengMsg.Click += ButtonSengMsg_Click;
            buttonStopService.Click += ButtonStopService_Click;
            server = new ModelServer.Server(textBoxIPAdress.Text, int.Parse(textBoxPort.Text), checkBoxMode.Checked ? WhoIsConnect.people : WhoIsConnect.computer);
            server.InfoMessage += Server_InfoMessage;
        }

        private void ButtonStopService_Click(object sender, EventArgs e)
        {
            server?.StopServer();
        }

        private void Server_InfoMessage(string info)
        {
            textBoxLogMsg.AppendText(info);
        }

        private void ButtonBeginStartServer_Click(object sender, EventArgs e)
        {
            server?.StartServer();
        }
        private void ButtonSengMsg_Click(object sender, EventArgs e)
        {
            server?.ServerSendMsg(textBoxSendMsg.Text.Trim());
        }
    }
}
