
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
            this.groupBoxUserPassword = new System.Windows.Forms.GroupBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSendLoginPassword = new System.Windows.Forms.Button();
            this.groupBoxKurs.SuspendLayout();
            this.groupBoxUserPassword.SuspendLayout();
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
            this.buttonConnectToServer.Size = new System.Drawing.Size(102, 73);
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
            this.groupBoxKurs.Location = new System.Drawing.Point(16, 421);
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
            this.buttonDicconectFromServer.Location = new System.Drawing.Point(16, 351);
            this.buttonDicconectFromServer.Name = "buttonDicconectFromServer";
            this.buttonDicconectFromServer.Size = new System.Drawing.Size(102, 60);
            this.buttonDicconectFromServer.TabIndex = 8;
            this.buttonDicconectFromServer.Text = "Отключиться от сервера";
            this.buttonDicconectFromServer.UseVisualStyleBackColor = true;
            // 
            // groupBoxUserPassword
            // 
            this.groupBoxUserPassword.Controls.Add(this.buttonSendLoginPassword);
            this.groupBoxUserPassword.Controls.Add(this.labelPassword);
            this.groupBoxUserPassword.Controls.Add(this.labelLogin);
            this.groupBoxUserPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxUserPassword.Controls.Add(this.textBoxLogin);
            this.groupBoxUserPassword.Location = new System.Drawing.Point(144, 257);
            this.groupBoxUserPassword.Name = "groupBoxUserPassword";
            this.groupBoxUserPassword.Size = new System.Drawing.Size(200, 158);
            this.groupBoxUserPassword.TabIndex = 9;
            this.groupBoxUserPassword.TabStop = false;
            this.groupBoxUserPassword.Text = "Логин и пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(66, 19);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(119, 20);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "Admin";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(66, 57);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(119, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "1234";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(7, 22);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 13);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(7, 60);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль:";
            // 
            // buttonSendLoginPassword
            // 
            this.buttonSendLoginPassword.Location = new System.Drawing.Point(6, 102);
            this.buttonSendLoginPassword.Name = "buttonSendLoginPassword";
            this.buttonSendLoginPassword.Size = new System.Drawing.Size(175, 44);
            this.buttonSendLoginPassword.TabIndex = 4;
            this.buttonSendLoginPassword.Text = "Отправить логин и пароль";
            this.buttonSendLoginPassword.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 599);
            this.Controls.Add(this.groupBoxUserPassword);
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
            this.groupBoxUserPassword.ResumeLayout(false);
            this.groupBoxUserPassword.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxUserPassword;
        private System.Windows.Forms.Button buttonSendLoginPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}

