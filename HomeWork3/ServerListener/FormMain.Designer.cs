
namespace ServerListener
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
            this.labelIPAddr = new System.Windows.Forms.Label();
            this.textBoxIPAddr = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.buttonStopServer = new System.Windows.Forms.Button();
            this.labelMaxRequestsUser = new System.Windows.Forms.Label();
            this.numericUpDownMaxRequestsUser = new System.Windows.Forms.NumericUpDown();
            this.labelMaxCountConnectClient = new System.Windows.Forms.Label();
            this.numericUpDownMaxCountConnectClient = new System.Windows.Forms.NumericUpDown();
            this.buttonLoginPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRequestsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCountConnectClient)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIPAddr
            // 
            this.labelIPAddr.AutoSize = true;
            this.labelIPAddr.Location = new System.Drawing.Point(12, 22);
            this.labelIPAddr.Name = "labelIPAddr";
            this.labelIPAddr.Size = new System.Drawing.Size(53, 13);
            this.labelIPAddr.TabIndex = 0;
            this.labelIPAddr.Text = "IP-адрес:";
            // 
            // textBoxIPAddr
            // 
            this.textBoxIPAddr.Location = new System.Drawing.Point(71, 19);
            this.textBoxIPAddr.Name = "textBoxIPAddr";
            this.textBoxIPAddr.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPAddr.TabIndex = 1;
            this.textBoxIPAddr.Text = "127.0.0.1";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(238, 22);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 13);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Порт:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(295, 19);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "1234";
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 218);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(383, 173);
            this.listBoxLog.TabIndex = 4;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.Location = new System.Drawing.Point(12, 191);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(87, 13);
            this.labelLog.TabIndex = 5;
            this.labelLog.Text = "Лог событий:";
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Location = new System.Drawing.Point(12, 406);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(137, 50);
            this.buttonStartServer.TabIndex = 6;
            this.buttonStartServer.Text = "Запустить сервер";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            // 
            // buttonStopServer
            // 
            this.buttonStopServer.Location = new System.Drawing.Point(241, 406);
            this.buttonStopServer.Name = "buttonStopServer";
            this.buttonStopServer.Size = new System.Drawing.Size(138, 50);
            this.buttonStopServer.TabIndex = 7;
            this.buttonStopServer.Text = "Остановить сервер";
            this.buttonStopServer.UseVisualStyleBackColor = true;
            // 
            // labelMaxRequestsUser
            // 
            this.labelMaxRequestsUser.AutoSize = true;
            this.labelMaxRequestsUser.Location = new System.Drawing.Point(12, 58);
            this.labelMaxRequestsUser.Name = "labelMaxRequestsUser";
            this.labelMaxRequestsUser.Size = new System.Drawing.Size(273, 13);
            this.labelMaxRequestsUser.TabIndex = 8;
            this.labelMaxRequestsUser.Text = "Максимальное количество запросов пользователя:";
            // 
            // numericUpDownMaxRequestsUser
            // 
            this.numericUpDownMaxRequestsUser.Location = new System.Drawing.Point(298, 56);
            this.numericUpDownMaxRequestsUser.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMaxRequestsUser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxRequestsUser.Name = "numericUpDownMaxRequestsUser";
            this.numericUpDownMaxRequestsUser.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownMaxRequestsUser.TabIndex = 9;
            this.numericUpDownMaxRequestsUser.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelMaxCountConnectClient
            // 
            this.labelMaxCountConnectClient.AutoSize = true;
            this.labelMaxCountConnectClient.Location = new System.Drawing.Point(87, 92);
            this.labelMaxCountConnectClient.Name = "labelMaxCountConnectClient";
            this.labelMaxCountConnectClient.Size = new System.Drawing.Size(198, 13);
            this.labelMaxCountConnectClient.TabIndex = 10;
            this.labelMaxCountConnectClient.Text = "Максимальное количество клиентов:";
            // 
            // numericUpDownMaxCountConnectClient
            // 
            this.numericUpDownMaxCountConnectClient.Location = new System.Drawing.Point(295, 90);
            this.numericUpDownMaxCountConnectClient.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMaxCountConnectClient.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxCountConnectClient.Name = "numericUpDownMaxCountConnectClient";
            this.numericUpDownMaxCountConnectClient.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownMaxCountConnectClient.TabIndex = 11;
            this.numericUpDownMaxCountConnectClient.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonLoginPassword
            // 
            this.buttonLoginPassword.Location = new System.Drawing.Point(12, 126);
            this.buttonLoginPassword.Name = "buttonLoginPassword";
            this.buttonLoginPassword.Size = new System.Drawing.Size(137, 49);
            this.buttonLoginPassword.TabIndex = 12;
            this.buttonLoginPassword.Text = "Логины и пароли";
            this.buttonLoginPassword.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 513);
            this.Controls.Add(this.buttonLoginPassword);
            this.Controls.Add(this.numericUpDownMaxCountConnectClient);
            this.Controls.Add(this.labelMaxCountConnectClient);
            this.Controls.Add(this.numericUpDownMaxRequestsUser);
            this.Controls.Add(this.labelMaxRequestsUser);
            this.Controls.Add(this.buttonStopServer);
            this.Controls.Add(this.buttonStartServer);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIPAddr);
            this.Controls.Add(this.labelIPAddr);
            this.Name = "FormMain";
            this.Text = "Сервер. Слушатель клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRequestsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCountConnectClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIPAddr;
        private System.Windows.Forms.TextBox textBoxIPAddr;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Button buttonStopServer;
        private System.Windows.Forms.Label labelMaxRequestsUser;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRequestsUser;
        private System.Windows.Forms.Label labelMaxCountConnectClient;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCountConnectClient;
        private System.Windows.Forms.Button buttonLoginPassword;
    }
}

