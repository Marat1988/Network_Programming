using System;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        Client client;
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
            client.CloseClient();
        }

        private void ButtonBeginListen_Click(object sender, EventArgs e)
        {
            client = new Client(textBoxIPAdress.Text, int.Parse(textBoxPort.Text));
            client.Start();
        }

        private void ButtonSengMsg_Click(object sender, EventArgs e)
        {
            client.ClientSendMsg(textBoxSendMsg.Text);
        }
    }
}
