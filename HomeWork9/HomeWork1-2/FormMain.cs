using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace HomeWork1_2
{
    public partial class FormMain : Form
    {
        string url = "https://api.openweathermap.org/data/2.5/weather?q=YouCity&lang=ru&units=metric&appid=YouAPIKEY&mode=xml";
        string urlForecast = "https://api.openweathermap.org/data/2.5/forecast?q=YouCity&lang=ru&units=metric&mode=xml&appid=YouAPIKEY";
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tempUrl = url;
                tempUrl = tempUrl.Replace("YouCity", textBoxCity.Text);
                tempUrl = tempUrl.Replace("YouAPIKEY", textBoxAPIKEY.Text);
                /*HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string responce;
                using(StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    responce = streamReader.ReadToEnd();
                }*/
                XDocument xDocument = XDocument.Load(tempUrl);
                var sql = (from p in xDocument.Elements("current")
                           select new
                           {
                               Название_города = p.Element("city").Attribute("name").Value,
                               Минимальная_температура_в_цельциях = p.Element("temperature").Attribute("min").Value,
                               Максимальная_температура_в_цельциях = p.Element("temperature").Attribute("max").Value,
                               Описание = p.Element("weather").Attribute("value").Value,
                               Последнее_обновление = p.Element("lastupdate").Attribute("value").Value
                           }).ToList();
                dataGridViewInfo.DataSource = null;
                dataGridViewInfo.DataSource = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonForecast_Click(object sender, EventArgs e)
        {
            try
            {
                string tempUrl = urlForecast;
                tempUrl = tempUrl.Replace("YouCity", textBoxCity.Text);
                tempUrl = tempUrl.Replace("YouAPIKEY", textBoxAPIKEY.Text);
                XDocument xDocument = XDocument.Load(tempUrl);
                var sql = (from p in xDocument.Elements("weatherdata").Elements("forecast").Elements("time")
                           select new
                           {
                               Дата_начала = p.Attribute("from").Value,
                               Дата_кконца = p.Attribute("to").Value,
                               Минимальная_температура_в_цельциях = p.Element("temperature").Attribute("min").Value,
                               Максимальная_температура_в_цельциях = p.Element("temperature").Attribute("max").Value,
                               Описание = p.Element("symbol").Attribute("name").Value
                           }).ToList();
                dataGridViewInfo.DataSource = null;
                dataGridViewInfo.DataSource = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
