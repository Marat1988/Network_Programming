
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
            this.textBoxLogMsg = new System.Windows.Forms.TextBox();
            this.labelLogMsg = new System.Windows.Forms.Label();
            this.buttonBeginListen = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxIPAdress = new System.Windows.Forms.TextBox();
            this.labelIPAdress = new System.Windows.Forms.Label();
            this.groupBoxChooseMsg = new System.Windows.Forms.GroupBox();
            this.radioButtonGetTime = new System.Windows.Forms.RadioButton();
            this.radioButtonGetDATE = new System.Windows.Forms.RadioButton();
            this.groupBoxChooseMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSengMsg
            // 
            this.buttonSengMsg.Location = new System.Drawing.Point(229, 237);
            this.buttonSengMsg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSengMsg.Name = "buttonSengMsg";
            this.buttonSengMsg.Size = new System.Drawing.Size(110, 43);
            this.buttonSengMsg.TabIndex = 29;
            this.buttonSengMsg.Text = "Отправить запрос";
            this.buttonSengMsg.UseVisualStyleBackColor = true;
            // 
            // textBoxLogMsg
            // 
            this.textBoxLogMsg.Location = new System.Drawing.Point(122, 54);
            this.textBoxLogMsg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogMsg.Multiline = true;
            this.textBoxLogMsg.Name = "textBoxLogMsg";
            this.textBoxLogMsg.Size = new System.Drawing.Size(313, 173);
            this.textBoxLogMsg.TabIndex = 26;
            // 
            // labelLogMsg
            // 
            this.labelLogMsg.AutoSize = true;
            this.labelLogMsg.Location = new System.Drawing.Point(24, 56);
            this.labelLogMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogMsg.Name = "labelLogMsg";
            this.labelLogMsg.Size = new System.Drawing.Size(89, 13);
            this.labelLogMsg.TabIndex = 25;
            this.labelLogMsg.Text = "Лог сообщений:";
            // 
            // buttonBeginListen
            // 
            this.buttonBeginListen.Location = new System.Drawing.Point(277, 15);
            this.buttonBeginListen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBeginListen.Name = "buttonBeginListen";
            this.buttonBeginListen.Size = new System.Drawing.Size(158, 31);
            this.buttonBeginListen.TabIndex = 24;
            this.buttonBeginListen.Text = "Подключиться к серверу";
            this.buttonBeginListen.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(185, 21);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(76, 20);
            this.textBoxPort.TabIndex = 23;
            this.textBoxPort.Text = "1234";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(135, 23);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 13);
            this.labelPort.TabIndex = 22;
            this.labelPort.Text = "PORT:";
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.Location = new System.Drawing.Point(47, 21);
            this.textBoxIPAdress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(76, 20);
            this.textBoxIPAdress.TabIndex = 21;
            this.textBoxIPAdress.Text = "127.0.0.1";
            // 
            // labelIPAdress
            // 
            this.labelIPAdress.AutoSize = true;
            this.labelIPAdress.Location = new System.Drawing.Point(24, 23);
            this.labelIPAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIPAdress.Name = "labelIPAdress";
            this.labelIPAdress.Size = new System.Drawing.Size(20, 13);
            this.labelIPAdress.TabIndex = 20;
            this.labelIPAdress.Text = "IP:";
            // 
            // groupBoxChooseMsg
            // 
            this.groupBoxChooseMsg.Controls.Add(this.radioButtonGetDATE);
            this.groupBoxChooseMsg.Controls.Add(this.radioButtonGetTime);
            this.groupBoxChooseMsg.Location = new System.Drawing.Point(12, 237);
            this.groupBoxChooseMsg.Name = "groupBoxChooseMsg";
            this.groupBoxChooseMsg.Size = new System.Drawing.Size(200, 128);
            this.groupBoxChooseMsg.TabIndex = 30;
            this.groupBoxChooseMsg.TabStop = false;
            this.groupBoxChooseMsg.Text = "Выберите тип сообщения:";
            // 
            // radioButtonGetTime
            // 
            this.radioButtonGetTime.AutoSize = true;
            this.radioButtonGetTime.Checked = true;
            this.radioButtonGetTime.Location = new System.Drawing.Point(6, 26);
            this.radioButtonGetTime.Name = "radioButtonGetTime";
            this.radioButtonGetTime.Size = new System.Drawing.Size(76, 17);
            this.radioButtonGetTime.TabIndex = 0;
            this.radioButtonGetTime.TabStop = true;
            this.radioButtonGetTime.Text = "GET TIME";
            this.radioButtonGetTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetDATE
            // 
            this.radioButtonGetDATE.AutoSize = true;
            this.radioButtonGetDATE.Location = new System.Drawing.Point(6, 61);
            this.radioButtonGetDATE.Name = "radioButtonGetDATE";
            this.radioButtonGetDATE.Size = new System.Drawing.Size(79, 17);
            this.radioButtonGetDATE.TabIndex = 1;
            this.radioButtonGetDATE.TabStop = true;
            this.radioButtonGetDATE.Text = "GET DATE";
            this.radioButtonGetDATE.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 377);
            this.Controls.Add(this.groupBoxChooseMsg);
            this.Controls.Add(this.buttonSengMsg);
            this.Controls.Add(this.textBoxLogMsg);
            this.Controls.Add(this.labelLogMsg);
            this.Controls.Add(this.buttonBeginListen);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIPAdress);
            this.Controls.Add(this.labelIPAdress);
            this.Name = "FormMain";
            this.Text = "Клиент";
            this.groupBoxChooseMsg.ResumeLayout(false);
            this.groupBoxChooseMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSengMsg;
        private System.Windows.Forms.TextBox textBoxLogMsg;
        private System.Windows.Forms.Label labelLogMsg;
        private System.Windows.Forms.Button buttonBeginListen;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxIPAdress;
        private System.Windows.Forms.Label labelIPAdress;
        private System.Windows.Forms.GroupBox groupBoxChooseMsg;
        private System.Windows.Forms.RadioButton radioButtonGetDATE;
        private System.Windows.Forms.RadioButton radioButtonGetTime;
    }
}

