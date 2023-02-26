﻿using ServerListener.ServerModel;
using System;
using System.Windows.Forms;

namespace ServerListener
{
    public partial class FormMain : Form
    {
        Server server;
        public FormMain()
        {
            InitializeComponent();
            //Закрываем проверку на недопустимую операцию потока в ListBox
            ListBox.CheckForIllegalCrossThreadCalls = false;
            buttonStartServer.Click += ButtonStartServer_Click;
            buttonStopServer.Click += ButtonStopServer_Click;
        }

        private void ButtonStartServer_Click(object sender, EventArgs e)
        {
            server = new Server(textBoxIPAddr.Text, Convert.ToInt32(textBoxPort.Text));
            server.InfoMessage += Server_InfoMessage;
            server.StartServer();
        }

        private void ButtonStopServer_Click(object sender, EventArgs e)
        {
            server?.CloseServer();
        }

        private void Server_InfoMessage(string info)
        {
            listBoxLog.Items.Add(info);
        }

    }
}