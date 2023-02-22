
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
            this.buttonSengMsg = new System.Windows.Forms.Button();
            this.textBoxSendMsg = new System.Windows.Forms.TextBox();
            this.labelSendMsg = new System.Windows.Forms.Label();
            this.textBoxLogMsg = new System.Windows.Forms.TextBox();
            this.labelLogMsg = new System.Windows.Forms.Label();
            this.buttonBeginListen = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxIPAdress = new System.Windows.Forms.TextBox();
            this.labelIPAdress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSengMsg
            // 
            this.buttonSengMsg.Location = new System.Drawing.Point(383, 282);
            this.buttonSengMsg.Name = "buttonSengMsg";
            this.buttonSengMsg.Size = new System.Drawing.Size(146, 53);
            this.buttonSengMsg.TabIndex = 19;
            this.buttonSengMsg.Text = "Отправить сообщение";
            this.buttonSengMsg.UseVisualStyleBackColor = true;
            // 
            // textBoxSendMsg
            // 
            this.textBoxSendMsg.Location = new System.Drawing.Point(163, 297);
            this.textBoxSendMsg.Name = "textBoxSendMsg";
            this.textBoxSendMsg.Size = new System.Drawing.Size(214, 22);
            this.textBoxSendMsg.TabIndex = 18;
            // 
            // labelSendMsg
            // 
            this.labelSendMsg.AutoSize = true;
            this.labelSendMsg.Location = new System.Drawing.Point(12, 297);
            this.labelSendMsg.Name = "labelSendMsg";
            this.labelSendMsg.Size = new System.Drawing.Size(145, 17);
            this.labelSendMsg.TabIndex = 17;
            this.labelSendMsg.Text = "Введите сообщение:";
            // 
            // textBoxLogMsg
            // 
            this.textBoxLogMsg.Location = new System.Drawing.Point(143, 56);
            this.textBoxLogMsg.Multiline = true;
            this.textBoxLogMsg.Name = "textBoxLogMsg";
            this.textBoxLogMsg.Size = new System.Drawing.Size(386, 212);
            this.textBoxLogMsg.TabIndex = 16;
            // 
            // labelLogMsg
            // 
            this.labelLogMsg.AutoSize = true;
            this.labelLogMsg.Location = new System.Drawing.Point(12, 59);
            this.labelLogMsg.Name = "labelLogMsg";
            this.labelLogMsg.Size = new System.Drawing.Size(113, 17);
            this.labelLogMsg.TabIndex = 15;
            this.labelLogMsg.Text = "Лог сообщений:";
            // 
            // buttonBeginListen
            // 
            this.buttonBeginListen.Location = new System.Drawing.Point(349, 9);
            this.buttonBeginListen.Name = "buttonBeginListen";
            this.buttonBeginListen.Size = new System.Drawing.Size(180, 38);
            this.buttonBeginListen.TabIndex = 14;
            this.buttonBeginListen.Text = "Подключиться к серверу";
            this.buttonBeginListen.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(227, 16);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 22);
            this.textBoxPort.TabIndex = 13;
            this.textBoxPort.Text = "1234";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(160, 19);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(51, 17);
            this.labelPort.TabIndex = 12;
            this.labelPort.Text = "PORT:";
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.Location = new System.Drawing.Point(42, 16);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(100, 22);
            this.textBoxIPAdress.TabIndex = 11;
            this.textBoxIPAdress.Text = "127.0.0.1";
            // 
            // labelIPAdress
            // 
            this.labelIPAdress.AutoSize = true;
            this.labelIPAdress.Location = new System.Drawing.Point(12, 19);
            this.labelIPAdress.Name = "labelIPAdress";
            this.labelIPAdress.Size = new System.Drawing.Size(24, 17);
            this.labelIPAdress.TabIndex = 10;
            this.labelIPAdress.Text = "IP:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 351);
            this.Controls.Add(this.buttonSengMsg);
            this.Controls.Add(this.textBoxSendMsg);
            this.Controls.Add(this.labelSendMsg);
            this.Controls.Add(this.textBoxLogMsg);
            this.Controls.Add(this.labelLogMsg);
            this.Controls.Add(this.buttonBeginListen);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIPAdress);
            this.Controls.Add(this.labelIPAdress);
            this.Name = "FormMain";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSengMsg;
        private System.Windows.Forms.TextBox textBoxSendMsg;
        private System.Windows.Forms.Label labelSendMsg;
        private System.Windows.Forms.TextBox textBoxLogMsg;
        private System.Windows.Forms.Label labelLogMsg;
        private System.Windows.Forms.Button buttonBeginListen;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxIPAdress;
        private System.Windows.Forms.Label labelIPAdress;
    }
}

