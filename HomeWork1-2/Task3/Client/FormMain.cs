using System;
using System.Windows.Forms;
using Client.ClientModel;

namespace Client
{
    public partial class FormMain : Form
    {
        ClientModel.Client client;
        public FormMain()
        {
            InitializeComponent();
            //Закрываем проверку на недопустимую операцию потока в текстовое поле
            TextBox.CheckForIllegalCrossThreadCalls = false;
            buttonBeginListen.Click += ButtonBeginListen_Click;
            buttonSengMsg.Click += ButtonSengMsg_Click;
            buttonStopClient.Click += ButtonStopClient_Click;           
        }

        private void ButtonStopClient_Click(object sender, EventArgs e)
        {
            client?.CloseClient();
        }

        private void ButtonBeginListen_Click(object sender, EventArgs e)
        {

            client = new ClientModel.Client(textBoxIPAdress.Text, int.Parse(textBoxPort.Text), checkBoxMode.Checked ? WhoIsConnect.people : WhoIsConnect.computer);
            client.InfoMessage += Client_infoMessage;
            client?.Start();
        }

        private void Client_infoMessage(string info)
        {
            textBoxLogMsg.AppendText(info);
        }

        private void ButtonSengMsg_Click(object sender, EventArgs e)
        {
            client?.ClientSendMsg(textBoxSendMsg.Text);
        }
    }
}
