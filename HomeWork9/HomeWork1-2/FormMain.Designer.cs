
namespace HomeWork1_2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAPIKEY = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.buttonForecast = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Location = new System.Drawing.Point(12, 215);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(153, 38);
            this.buttonGetWeather.TabIndex = 0;
            this.buttonGetWeather.Text = "Узнать погоду";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(167, 118);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(201, 20);
            this.textBoxCity.TabIndex = 1;
            this.textBoxCity.Text = "Kaliningrad";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(12, 121);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(141, 13);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "Введите название города:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите API key:";
            // 
            // textBoxAPIKEY
            // 
            this.textBoxAPIKEY.Location = new System.Drawing.Point(167, 158);
            this.textBoxAPIKEY.Name = "textBoxAPIKEY";
            this.textBoxAPIKEY.Size = new System.Drawing.Size(201, 20);
            this.textBoxAPIKEY.TabIndex = 4;
            this.textBoxAPIKEY.Text = "1234";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(12, 64);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(537, 18);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Получите свой API key на данном сайте https://openweathermap.org";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(15, 274);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.Size = new System.Drawing.Size(353, 150);
            this.dataGridViewInfo.TabIndex = 7;
            // 
            // buttonForecast
            // 
            this.buttonForecast.Location = new System.Drawing.Point(218, 215);
            this.buttonForecast.Name = "buttonForecast";
            this.buttonForecast.Size = new System.Drawing.Size(150, 38);
            this.buttonForecast.TabIndex = 8;
            this.buttonForecast.Text = "Прогноз";
            this.buttonForecast.UseVisualStyleBackColor = true;
            this.buttonForecast.Click += new System.EventHandler(this.buttonForecast_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(40, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(475, 33);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://openweathermap.org/current";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonForecast);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxAPIKEY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.buttonGetWeather);
            this.Name = "FormMain";
            this.Text = "У природы нет плохой погоды......";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAPIKEY;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Button buttonForecast;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

