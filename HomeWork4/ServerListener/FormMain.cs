using ServerListener.ServerModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerListener
{
    public partial class FormMain : Form
    {
        Server server;
        public FormMain()
        {
            InitializeComponent();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            dataGridViewProduct.DataSource = (from p in Products.listProduct
                                              select new
                                              {
                                                  Наименование_товара = p.Key,
                                                  Цена_товара = p.Value
                                              }).ToList();
            buttonStartServer.Click += ButtonStartServer_Click;

        }

        private void ButtonStartServer_Click(object sender, EventArgs e)
        {
            server = new Server(textBoxIPAddress.Text, Convert.ToInt32(textBoxPort.Text));
            server.InfoMessage += Server_InfoMessage;
            server.caesarSalad = pictureBox1.Image;
            server.StartServer();
        }

        private void Server_InfoMessage(string infoMessage)
        {
            listBoxLog.Items.Add(infoMessage);
        }
    }
}
