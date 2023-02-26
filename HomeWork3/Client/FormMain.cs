using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        ClientModel.Client client;
        public FormMain()
        {
            InitializeComponent();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            buttonConnectToServer.Click += ButtonConnectToServer_Click;
            buttonGetKursFromServer.Click += ButtonGetKursFromServer_Click;
            buttonDicconectFromServer.Click += ButtonDicconectFromServer_Click;
        }

        private void ButtonDicconectFromServer_Click(object sender, EventArgs e)
        {
            client?.DicconectFromServer();
        }

        private void ButtonConnectToServer_Click(object sender, EventArgs e)
        {
            client = new ClientModel.Client(textBoxIPAddr.Text, int.Parse(textBoxPort.Text));
            client.InfoMessage += Client_InfoMessage;
            client.ConnectToServer();
        }

        private void ButtonGetKursFromServer_Click(object sender, EventArgs e)
        {
            List<RadioButton> radioButtons = groupBoxKurs.Controls.OfType<RadioButton>().ToList();
            string text = radioButtons.SingleOrDefault(radioButton => radioButton.Checked).Text;
            client?.SendMessage(text);
        }

        private void Client_InfoMessage(string info)
        {
            listBoxLog.Items.Add(info);
        }
    }
}
