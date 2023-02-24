
namespace Server
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
            this.buttonSengMsg = new System.Windows.Forms.Button();
            this.textBoxSendMsg = new System.Windows.Forms.TextBox();
            this.labelSendMsg = new System.Windows.Forms.Label();
            this.textBoxLogMsg = new System.Windows.Forms.TextBox();
            this.labelLogMsg = new System.Windows.Forms.Label();
            this.buttonBeginStartServer = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxIPAdress = new System.Windows.Forms.TextBox();
            this.labelIPAdress = new System.Windows.Forms.Label();
            this.buttonStopService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSengMsg
            // 
            this.buttonSengMsg.Location = new System.Drawing.Point(416, 286);
            this.buttonSengMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSengMsg.Name = "buttonSengMsg";
            this.buttonSengMsg.Size = new System.Drawing.Size(147, 53);
            this.buttonSengMsg.TabIndex = 29;
            this.buttonSengMsg.Text = "Отправить сообщение";
            this.buttonSengMsg.UseVisualStyleBackColor = true;
            // 
            // textBoxSendMsg
            // 
            this.textBoxSendMsg.Location = new System.Drawing.Point(165, 300);
            this.textBoxSendMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSendMsg.Name = "textBoxSendMsg";
            this.textBoxSendMsg.Size = new System.Drawing.Size(232, 22);
            this.textBoxSendMsg.TabIndex = 28;
            // 
            // labelSendMsg
            // 
            this.labelSendMsg.AutoSize = true;
            this.labelSendMsg.Location = new System.Drawing.Point(11, 304);
            this.labelSendMsg.Name = "labelSendMsg";
            this.labelSendMsg.Size = new System.Drawing.Size(145, 17);
            this.labelSendMsg.TabIndex = 27;
            this.labelSendMsg.Text = "Введите сообщение:";
            // 
            // textBoxLogMsg
            // 
            this.textBoxLogMsg.Location = new System.Drawing.Point(145, 60);
            this.textBoxLogMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogMsg.Multiline = true;
            this.textBoxLogMsg.Name = "textBoxLogMsg";
            this.textBoxLogMsg.Size = new System.Drawing.Size(547, 212);
            this.textBoxLogMsg.TabIndex = 26;
            // 
            // labelLogMsg
            // 
            this.labelLogMsg.AutoSize = true;
            this.labelLogMsg.Location = new System.Drawing.Point(15, 63);
            this.labelLogMsg.Name = "labelLogMsg";
            this.labelLogMsg.Size = new System.Drawing.Size(113, 17);
            this.labelLogMsg.TabIndex = 25;
            this.labelLogMsg.Text = "Лог сообщений:";
            // 
            // buttonBeginStartServer
            // 
            this.buttonBeginStartServer.Location = new System.Drawing.Point(352, 12);
            this.buttonBeginStartServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBeginStartServer.Name = "buttonBeginStartServer";
            this.buttonBeginStartServer.Size = new System.Drawing.Size(161, 38);
            this.buttonBeginStartServer.TabIndex = 24;
            this.buttonBeginStartServer.Text = "Запустить службу";
            this.buttonBeginStartServer.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(229, 20);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 22);
            this.textBoxPort.TabIndex = 23;
            this.textBoxPort.Text = "1234";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(163, 22);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(51, 17);
            this.labelPort.TabIndex = 22;
            this.labelPort.Text = "PORT:";
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.Location = new System.Drawing.Point(45, 20);
            this.textBoxIPAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(100, 22);
            this.textBoxIPAdress.TabIndex = 21;
            this.textBoxIPAdress.Text = "127.0.0.1";
            // 
            // labelIPAdress
            // 
            this.labelIPAdress.AutoSize = true;
            this.labelIPAdress.Location = new System.Drawing.Point(15, 22);
            this.labelIPAdress.Name = "labelIPAdress";
            this.labelIPAdress.Size = new System.Drawing.Size(24, 17);
            this.labelIPAdress.TabIndex = 20;
            this.labelIPAdress.Text = "IP:";
            // 
            // buttonStopService
            // 
            this.buttonStopService.Location = new System.Drawing.Point(531, 12);
            this.buttonStopService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStopService.Name = "buttonStopService";
            this.buttonStopService.Size = new System.Drawing.Size(161, 38);
            this.buttonStopService.TabIndex = 30;
            this.buttonStopService.Text = "Остановить службу";
            this.buttonStopService.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 383);
            this.Controls.Add(this.buttonStopService);
            this.Controls.Add(this.buttonSengMsg);
            this.Controls.Add(this.textBoxSendMsg);
            this.Controls.Add(this.labelSendMsg);
            this.Controls.Add(this.textBoxLogMsg);
            this.Controls.Add(this.labelLogMsg);
            this.Controls.Add(this.buttonBeginStartServer);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIPAdress);
            this.Controls.Add(this.labelIPAdress);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Сервер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSengMsg;
        private System.Windows.Forms.TextBox textBoxSendMsg;
        private System.Windows.Forms.Label labelSendMsg;
        private System.Windows.Forms.TextBox textBoxLogMsg;
        private System.Windows.Forms.Label labelLogMsg;
        private System.Windows.Forms.Button buttonBeginStartServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxIPAdress;
        private System.Windows.Forms.Label labelIPAdress;
        private System.Windows.Forms.Button buttonStopService;
    }
}

