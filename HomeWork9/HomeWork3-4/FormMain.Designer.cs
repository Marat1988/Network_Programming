
namespace HomeWork3_4
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxAPIKEY = new System.Windows.Forms.TextBox();
            this.labelApIKEY = new System.Windows.Forms.Label();
            this.labelNameFilm = new System.Windows.Forms.Label();
            this.textBoxNameFilm = new System.Windows.Forms.TextBox();
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(171, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(342, 33);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.omdbapi.com/";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(15, 256);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.Size = new System.Drawing.Size(353, 150);
            this.dataGridViewInfo.TabIndex = 16;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(12, 69);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(518, 18);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Получите свой API key на данном сайте http://www.omdbapi.com/";
            // 
            // textBoxAPIKEY
            // 
            this.textBoxAPIKEY.Location = new System.Drawing.Point(167, 163);
            this.textBoxAPIKEY.Name = "textBoxAPIKEY";
            this.textBoxAPIKEY.Size = new System.Drawing.Size(201, 20);
            this.textBoxAPIKEY.TabIndex = 14;
            this.textBoxAPIKEY.Text = "1234";
            // 
            // labelApIKEY
            // 
            this.labelApIKEY.AutoSize = true;
            this.labelApIKEY.Location = new System.Drawing.Point(12, 166);
            this.labelApIKEY.Name = "labelApIKEY";
            this.labelApIKEY.Size = new System.Drawing.Size(92, 13);
            this.labelApIKEY.TabIndex = 13;
            this.labelApIKEY.Text = "Введите API key:";
            // 
            // labelNameFilm
            // 
            this.labelNameFilm.AutoSize = true;
            this.labelNameFilm.Location = new System.Drawing.Point(12, 126);
            this.labelNameFilm.Name = "labelNameFilm";
            this.labelNameFilm.Size = new System.Drawing.Size(146, 13);
            this.labelNameFilm.TabIndex = 12;
            this.labelNameFilm.Text = "Введите название фильма:";
            // 
            // textBoxNameFilm
            // 
            this.textBoxNameFilm.Location = new System.Drawing.Point(167, 123);
            this.textBoxNameFilm.Name = "textBoxNameFilm";
            this.textBoxNameFilm.Size = new System.Drawing.Size(201, 20);
            this.textBoxNameFilm.TabIndex = 11;
            this.textBoxNameFilm.Text = "Van Helsing";
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Location = new System.Drawing.Point(12, 203);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(356, 38);
            this.buttonGetWeather.TabIndex = 10;
            this.buttonGetWeather.Text = "Узнать информацию о фильме";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(388, 123);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(273, 283);
            this.pictureBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPoster.TabIndex = 19;
            this.pictureBoxPoster.TabStop = false;
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(12, 457);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(196, 38);
            this.buttonSendMail.TabIndex = 20;
            this.buttonSendMail.Text = "Отправить письмо";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введите адрес получателя:";
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Location = new System.Drawing.Point(167, 425);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(201, 20);
            this.textBoxRecipient.TabIndex = 22;
            this.textBoxRecipient.Text = "pirat03071988@mail.ru";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 512);
            this.Controls.Add(this.textBoxRecipient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.pictureBoxPoster);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxAPIKEY);
            this.Controls.Add(this.labelApIKEY);
            this.Controls.Add(this.labelNameFilm);
            this.Controls.Add(this.textBoxNameFilm);
            this.Controls.Add(this.buttonGetWeather);
            this.Name = "FormMain";
            this.Text = "Поиск фильма";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxAPIKEY;
        private System.Windows.Forms.Label labelApIKEY;
        private System.Windows.Forms.Label labelNameFilm;
        private System.Windows.Forms.TextBox textBoxNameFilm;
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRecipient;
    }
}

