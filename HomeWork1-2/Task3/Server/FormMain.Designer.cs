
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
            this.checkBoxMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSengMsg
            // 
            this.buttonSengMsg.Location = new System.Drawing.Point(311, 299);
            this.buttonSengMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSengMsg.Name = "buttonSengMsg";
            this.buttonSengMsg.Size = new System.Drawing.Size(208, 32);
            this.buttonSengMsg.TabIndex = 29;
            this.buttonSengMsg.Text = "Отправить сообщение";
            this.buttonSengMsg.UseVisualStyleBackColor = true;
            // 
            // textBoxSendMsg
            // 
            this.textBoxSendMsg.Location = new System.Drawing.Point(123, 306);
            this.textBoxSendMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSendMsg.Name = "textBoxSendMsg";
            this.textBoxSendMsg.Size = new System.Drawing.Size(175, 20);
            this.textBoxSendMsg.TabIndex = 28;
            // 
            // labelSendMsg
            // 
            this.labelSendMsg.AutoSize = true;
            this.labelSendMsg.Location = new System.Drawing.Point(7, 309);
            this.labelSendMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSendMsg.Name = "labelSendMsg";
            this.labelSendMsg.Size = new System.Drawing.Size(112, 13);
            this.labelSendMsg.TabIndex = 27;
            this.labelSendMsg.Text = "Введите сообщение:";
            // 
            // textBoxLogMsg
            // 
            this.textBoxLogMsg.Location = new System.Drawing.Point(108, 111);
            this.textBoxLogMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLogMsg.Multiline = true;
            this.textBoxLogMsg.Name = "textBoxLogMsg";
            this.textBoxLogMsg.Size = new System.Drawing.Size(411, 173);
            this.textBoxLogMsg.TabIndex = 26;
            // 
            // labelLogMsg
            // 
            this.labelLogMsg.AutoSize = true;
            this.labelLogMsg.Location = new System.Drawing.Point(10, 113);
            this.labelLogMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogMsg.Name = "labelLogMsg";
            this.labelLogMsg.Size = new System.Drawing.Size(89, 13);
            this.labelLogMsg.TabIndex = 25;
            this.labelLogMsg.Text = "Лог сообщений:";
            // 
            // buttonBeginStartServer
            // 
            this.buttonBeginStartServer.Location = new System.Drawing.Point(10, 54);
            this.buttonBeginStartServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBeginStartServer.Name = "buttonBeginStartServer";
            this.buttonBeginStartServer.Size = new System.Drawing.Size(121, 31);
            this.buttonBeginStartServer.TabIndex = 24;
            this.buttonBeginStartServer.Text = "Запустить службу";
            this.buttonBeginStartServer.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(172, 21);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(76, 20);
            this.textBoxPort.TabIndex = 23;
            this.textBoxPort.Text = "1234";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(122, 23);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 13);
            this.labelPort.TabIndex = 22;
            this.labelPort.Text = "PORT:";
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.Location = new System.Drawing.Point(34, 21);
            this.textBoxIPAdress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(76, 20);
            this.textBoxIPAdress.TabIndex = 21;
            this.textBoxIPAdress.Text = "127.0.0.1";
            // 
            // labelIPAdress
            // 
            this.labelIPAdress.AutoSize = true;
            this.labelIPAdress.Location = new System.Drawing.Point(11, 23);
            this.labelIPAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIPAdress.Name = "labelIPAdress";
            this.labelIPAdress.Size = new System.Drawing.Size(20, 13);
            this.labelIPAdress.TabIndex = 20;
            this.labelIPAdress.Text = "IP:";
            // 
            // buttonStopService
            // 
            this.buttonStopService.Location = new System.Drawing.Point(147, 54);
            this.buttonStopService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStopService.Name = "buttonStopService";
            this.buttonStopService.Size = new System.Drawing.Size(121, 31);
            this.buttonStopService.TabIndex = 30;
            this.buttonStopService.Text = "Остановить службу";
            this.buttonStopService.UseVisualStyleBackColor = true;
            // 
            // checkBoxMode
            // 
            this.checkBoxMode.AutoSize = true;
            this.checkBoxMode.Checked = true;
            this.checkBoxMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMode.Location = new System.Drawing.Point(272, 24);
            this.checkBoxMode.Name = "checkBoxMode";
            this.checkBoxMode.Size = new System.Drawing.Size(118, 17);
            this.checkBoxMode.TabIndex = 31;
            this.checkBoxMode.Text = "Режим \"Человек\"";
            this.checkBoxMode.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 392);
            this.Controls.Add(this.checkBoxMode);
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
        private System.Windows.Forms.CheckBox checkBoxMode;
    }
}

