
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
            this.labelIPAdress = new System.Windows.Forms.Label();
            this.textBoxIPAdress = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonServerConn = new System.Windows.Forms.Button();
            this.labelLogMsg = new System.Windows.Forms.Label();
            this.textBoxLogMsg = new System.Windows.Forms.TextBox();
            this.labelSendMsg = new System.Windows.Forms.Label();
            this.textBoxSendMsg = new System.Windows.Forms.TextBox();
            this.buttonSengMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIPAdress
            // 
            this.labelIPAdress.AutoSize = true;
            this.labelIPAdress.Location = new System.Drawing.Point(12, 21);
            this.labelIPAdress.Name = "labelIPAdress";
            this.labelIPAdress.Size = new System.Drawing.Size(24, 17);
            this.labelIPAdress.TabIndex = 0;
            this.labelIPAdress.Text = "IP:";
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.Location = new System.Drawing.Point(42, 18);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(100, 22);
            this.textBoxIPAdress.TabIndex = 1;
            this.textBoxIPAdress.Text = "127.0.0.1";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(160, 21);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(51, 17);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "PORT:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(227, 18);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 22);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "1234";
            // 
            // buttonServerConn
            // 
            this.buttonServerConn.Location = new System.Drawing.Point(349, 11);
            this.buttonServerConn.Name = "buttonServerConn";
            this.buttonServerConn.Size = new System.Drawing.Size(151, 38);
            this.buttonServerConn.TabIndex = 4;
            this.buttonServerConn.Text = "Запустить службу";
            this.buttonServerConn.UseVisualStyleBackColor = true;
            // 
            // labelLogMsg
            // 
            this.labelLogMsg.AutoSize = true;
            this.labelLogMsg.Location = new System.Drawing.Point(12, 61);
            this.labelLogMsg.Name = "labelLogMsg";
            this.labelLogMsg.Size = new System.Drawing.Size(113, 17);
            this.labelLogMsg.TabIndex = 5;
            this.labelLogMsg.Text = "Лог сообщений:";
            // 
            // textBoxLogMsg
            // 
            this.textBoxLogMsg.Location = new System.Drawing.Point(143, 58);
            this.textBoxLogMsg.Multiline = true;
            this.textBoxLogMsg.Name = "textBoxLogMsg";
            this.textBoxLogMsg.Size = new System.Drawing.Size(357, 212);
            this.textBoxLogMsg.TabIndex = 6;
            // 
            // labelSendMsg
            // 
            this.labelSendMsg.AutoSize = true;
            this.labelSendMsg.Location = new System.Drawing.Point(12, 299);
            this.labelSendMsg.Name = "labelSendMsg";
            this.labelSendMsg.Size = new System.Drawing.Size(145, 17);
            this.labelSendMsg.TabIndex = 7;
            this.labelSendMsg.Text = "Введите сообщение:";
            // 
            // textBoxSendMsg
            // 
            this.textBoxSendMsg.Location = new System.Drawing.Point(163, 299);
            this.textBoxSendMsg.Name = "textBoxSendMsg";
            this.textBoxSendMsg.Size = new System.Drawing.Size(194, 22);
            this.textBoxSendMsg.TabIndex = 8;
            // 
            // buttonSengMsg
            // 
            this.buttonSengMsg.Location = new System.Drawing.Point(368, 284);
            this.buttonSengMsg.Name = "buttonSengMsg";
            this.buttonSengMsg.Size = new System.Drawing.Size(132, 53);
            this.buttonSengMsg.TabIndex = 9;
            this.buttonSengMsg.Text = "Отправить сообщение";
            this.buttonSengMsg.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 369);
            this.Controls.Add(this.buttonSengMsg);
            this.Controls.Add(this.textBoxSendMsg);
            this.Controls.Add(this.labelSendMsg);
            this.Controls.Add(this.textBoxLogMsg);
            this.Controls.Add(this.labelLogMsg);
            this.Controls.Add(this.buttonServerConn);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIPAdress);
            this.Controls.Add(this.labelIPAdress);
            this.Name = "FormMain";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIPAdress;
        private System.Windows.Forms.TextBox textBoxIPAdress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonServerConn;
        private System.Windows.Forms.Label labelLogMsg;
        private System.Windows.Forms.TextBox textBoxLogMsg;
        private System.Windows.Forms.Label labelSendMsg;
        private System.Windows.Forms.TextBox textBoxSendMsg;
        private System.Windows.Forms.Button buttonSengMsg;
    }
}

