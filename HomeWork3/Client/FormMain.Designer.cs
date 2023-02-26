
namespace Client
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
            this.textBoxIPAddr = new System.Windows.Forms.TextBox();
            this.labelIPAddr = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonConnectToServer = new System.Windows.Forms.Button();
            this.groupBoxKurs = new System.Windows.Forms.GroupBox();
            this.buttonGetKursFromServer = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonDicconectFromServer = new System.Windows.Forms.Button();
            this.groupBoxKurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIPAddr
            // 
            this.textBoxIPAddr.Location = new System.Drawing.Point(72, 22);
            this.textBoxIPAddr.Name = "textBoxIPAddr";
            this.textBoxIPAddr.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPAddr.TabIndex = 0;
            this.textBoxIPAddr.Text = "127.0.0.1";
            // 
            // labelIPAddr
            // 
            this.labelIPAddr.AutoSize = true;
            this.labelIPAddr.Location = new System.Drawing.Point(13, 25);
            this.labelIPAddr.Name = "labelIPAddr";
            this.labelIPAddr.Size = new System.Drawing.Size(53, 13);
            this.labelIPAddr.TabIndex = 1;
            this.labelIPAddr.Text = "IP-адрес:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(203, 25);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 13);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Порт:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(244, 22);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "1234";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(16, 82);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(328, 160);
            this.listBoxLog.TabIndex = 4;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(13, 57);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(89, 13);
            this.labelLog.TabIndex = 5;
            this.labelLog.Text = "Лог сообщений:";
            // 
            // buttonConnectToServer
            // 
            this.buttonConnectToServer.Location = new System.Drawing.Point(16, 257);
            this.buttonConnectToServer.Name = "buttonConnectToServer";
            this.buttonConnectToServer.Size = new System.Drawing.Size(161, 51);
            this.buttonConnectToServer.TabIndex = 6;
            this.buttonConnectToServer.Text = "Подключиться к серверу";
            this.buttonConnectToServer.UseVisualStyleBackColor = true;
            // 
            // groupBoxKurs
            // 
            this.groupBoxKurs.Controls.Add(this.buttonGetKursFromServer);
            this.groupBoxKurs.Controls.Add(this.radioButton4);
            this.groupBoxKurs.Controls.Add(this.radioButton3);
            this.groupBoxKurs.Controls.Add(this.radioButton2);
            this.groupBoxKurs.Controls.Add(this.radioButton1);
            this.groupBoxKurs.Location = new System.Drawing.Point(16, 332);
            this.groupBoxKurs.Name = "groupBoxKurs";
            this.groupBoxKurs.Size = new System.Drawing.Size(328, 166);
            this.groupBoxKurs.TabIndex = 7;
            this.groupBoxKurs.TabStop = false;
            this.groupBoxKurs.Text = "Выберите курс для запроса к серверу:";
            // 
            // buttonGetKursFromServer
            // 
            this.buttonGetKursFromServer.Location = new System.Drawing.Point(138, 30);
            this.buttonGetKursFromServer.Name = "buttonGetKursFromServer";
            this.buttonGetKursFromServer.Size = new System.Drawing.Size(143, 51);
            this.buttonGetKursFromServer.TabIndex = 4;
            this.buttonGetKursFromServer.Text = "Запросить курс";
            this.buttonGetKursFromServer.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 132);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "USD RUB";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "EURO RUB";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "EURO USD";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "USD EURO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonDicconectFromServer
            // 
            this.buttonDicconectFromServer.Location = new System.Drawing.Point(183, 257);
            this.buttonDicconectFromServer.Name = "buttonDicconectFromServer";
            this.buttonDicconectFromServer.Size = new System.Drawing.Size(161, 51);
            this.buttonDicconectFromServer.TabIndex = 8;
            this.buttonDicconectFromServer.Text = "Отключиться от сервера";
            this.buttonDicconectFromServer.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 510);
            this.Controls.Add(this.buttonDicconectFromServer);
            this.Controls.Add(this.groupBoxKurs);
            this.Controls.Add(this.buttonConnectToServer);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIPAddr);
            this.Controls.Add(this.textBoxIPAddr);
            this.Name = "FormMain";
            this.Text = "Клиент";
            this.groupBoxKurs.ResumeLayout(false);
            this.groupBoxKurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIPAddr;
        private System.Windows.Forms.Label labelIPAddr;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonConnectToServer;
        private System.Windows.Forms.GroupBox groupBoxKurs;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonGetKursFromServer;
        private System.Windows.Forms.Button buttonDicconectFromServer;
    }
}

