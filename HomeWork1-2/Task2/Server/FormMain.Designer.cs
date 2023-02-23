
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
            this.textBoxLogMsg = new System.Windows.Forms.TextBox();
            this.labelLogMsg = new System.Windows.Forms.Label();
            this.buttonServerStart = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxIPAdress = new System.Windows.Forms.TextBox();
            this.labelIPAdress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogMsg
            // 
            this.textBoxLogMsg.Location = new System.Drawing.Point(109, 39);
            this.textBoxLogMsg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogMsg.Multiline = true;
            this.textBoxLogMsg.Name = "textBoxLogMsg";
            this.textBoxLogMsg.Size = new System.Drawing.Size(269, 173);
            this.textBoxLogMsg.TabIndex = 13;
            // 
            // labelLogMsg
            // 
            this.labelLogMsg.AutoSize = true;
            this.labelLogMsg.Location = new System.Drawing.Point(11, 42);
            this.labelLogMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogMsg.Name = "labelLogMsg";
            this.labelLogMsg.Size = new System.Drawing.Size(89, 13);
            this.labelLogMsg.TabIndex = 12;
            this.labelLogMsg.Text = "Лог сообщений:";
            // 
            // buttonServerStart
            // 
            this.buttonServerStart.Location = new System.Drawing.Point(264, 1);
            this.buttonServerStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonServerStart.Name = "buttonServerStart";
            this.buttonServerStart.Size = new System.Drawing.Size(113, 31);
            this.buttonServerStart.TabIndex = 11;
            this.buttonServerStart.Text = "Запустить службу";
            this.buttonServerStart.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(172, 7);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(76, 20);
            this.textBoxPort.TabIndex = 10;
            this.textBoxPort.Text = "1234";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(122, 9);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 13);
            this.labelPort.TabIndex = 9;
            this.labelPort.Text = "PORT:";
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.Location = new System.Drawing.Point(34, 7);
            this.textBoxIPAdress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(76, 20);
            this.textBoxIPAdress.TabIndex = 8;
            this.textBoxIPAdress.Text = "127.0.0.1";
            // 
            // labelIPAdress
            // 
            this.labelIPAdress.AutoSize = true;
            this.labelIPAdress.Location = new System.Drawing.Point(11, 9);
            this.labelIPAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIPAdress.Name = "labelIPAdress";
            this.labelIPAdress.Size = new System.Drawing.Size(20, 13);
            this.labelIPAdress.TabIndex = 7;
            this.labelIPAdress.Text = "IP:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 262);
            this.Controls.Add(this.textBoxLogMsg);
            this.Controls.Add(this.labelLogMsg);
            this.Controls.Add(this.buttonServerStart);
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

        private System.Windows.Forms.TextBox textBoxLogMsg;
        private System.Windows.Forms.Label labelLogMsg;
        private System.Windows.Forms.Button buttonServerStart;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxIPAdress;
        private System.Windows.Forms.Label labelIPAdress;
    }
}

