using ServerListener.ServerModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ServerListener
{
    public partial class FormLoginPassword : Form
    {
        public FormLoginPassword()
        {
            InitializeComponent();
            buttonUpdateInfo.Click += ButtonUpdateInfo_Click;
            buttonAddLoginPassword.Click += ButtonAddLoginPassword_Click;
            textBoxLogin.TextChanged += TextBoxLogin_TextChanged;
            textBoxPassword.TextChanged += TextBoxLogin_TextChanged;
            UpdateInfo();
        }

        private void TextBoxLogin_TextChanged(object sender, EventArgs e)
        {
            buttonAddLoginPassword.Enabled = textBoxLogin.Text.Length > 0 && textBoxPassword.Text.Length > 0;
        }

        private void ButtonAddLoginPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Info.logins.Add(textBoxLogin.Text, textBoxPassword.Text);
                UpdateInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            dataGridViewListLoginPassword.DataSource = null;
            dataGridViewListLoginPassword.DataSource = (from lst in Info.logins
                                                        select new
                                                        {
                                                            Логин = lst.Key,
                                                            Пароль = lst.Value
                                                        }).ToList();

        }
    }
}
