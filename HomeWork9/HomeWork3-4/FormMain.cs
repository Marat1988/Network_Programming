using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeWork3_4
{
    public partial class FormMain : Form
    {
        string url = "http://www.omdbapi.com/?t=YouNameFilm&apikey=YouApiKey&r=xml";
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGetWeather_Click(object sender, EventArgs e)
        {
            try
            {
                string tempUrl = url;
                tempUrl = tempUrl.Replace("YouNameFilm", textBoxNameFilm.Text);
                tempUrl = tempUrl.Replace("YouApiKey", textBoxAPIKEY.Text);
                XDocument xDocument = XDocument.Load(tempUrl);
                var sql = (from p in xDocument.Elements("root")
                           select new
                           {
                               Название_фильма = p.Element("movie").Attribute("title").Value,
                               Год = p.Element("movie").Attribute("year").Value,
                               Релиз = p.Element("movie").Attribute("released").Value,
                               Продолжительность = p.Element("movie").Attribute("runtime").Value,
                               Жанр = p.Element("movie").Attribute("genre").Value,
                               Описание = p.Element("movie").Attribute("plot").Value,
                               Ссылка_на_постер = p.Element("movie").Attribute("poster").Value,
                           }).ToList();
                dataGridViewInfo.DataSource = null;
                dataGridViewInfo.DataSource = sql;
                StreamWriter streamWriter = new StreamWriter("Результаты.txt");
                streamWriter.Write(sql[0].ToString());
                streamWriter.Close();

                try
                {
                    var root = xDocument.Elements("root").Elements("movie").Attributes() ;
                    string urlPoster = root.FirstOrDefault(p => p.Name == "poster").Value;
                    pictureBoxPoster.Load(urlPoster);
                }
                catch (Exception){}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("pirat03071988@mail.ru", "17RFCn8QvET2sGRzzwcm");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("pirat03071988@mail.ru");
                mail.To.Add(textBoxRecipient.Text);
                mail.Subject = "Домашнее залание";
                mail.Body = "Тестирование API http://www.omdbapi.com";
                string file = "Результаты.txt";
                Attachment attach = new Attachment(file);
                mail.Attachments.Add(attach);
                smtp.Send(mail);
                MessageBox.Show("Письмо успешно отправлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
