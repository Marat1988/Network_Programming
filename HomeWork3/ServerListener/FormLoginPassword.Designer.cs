
namespace ServerListener
{
    partial class FormLoginPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewListLoginPassword = new System.Windows.Forms.DataGridView();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.buttonAddLoginPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListLoginPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListLoginPassword
            // 
            this.dataGridViewListLoginPassword.AllowUserToAddRows = false;
            this.dataGridViewListLoginPassword.AllowUserToDeleteRows = false;
            this.dataGridViewListLoginPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListLoginPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewListLoginPassword.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListLoginPassword.Name = "dataGridViewListLoginPassword";
            this.dataGridViewListLoginPassword.ReadOnly = true;
            this.dataGridViewListLoginPassword.Size = new System.Drawing.Size(800, 187);
            this.dataGridViewListLoginPassword.TabIndex = 0;
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.Location = new System.Drawing.Point(148, 291);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(114, 45);
            this.buttonUpdateInfo.TabIndex = 1;
            this.buttonUpdateInfo.Text = "Обновить информацию";
            this.buttonUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // buttonAddLoginPassword
            // 
            this.buttonAddLoginPassword.Enabled = false;
            this.buttonAddLoginPassword.Location = new System.Drawing.Point(16, 291);
            this.buttonAddLoginPassword.Name = "buttonAddLoginPassword";
            this.buttonAddLoginPassword.Size = new System.Drawing.Size(114, 45);
            this.buttonAddLoginPassword.TabIndex = 2;
            this.buttonAddLoginPassword.Text = "Добавить";
            this.buttonAddLoginPassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите новый логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(148, 214);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(114, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(148, 251);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(114, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // FormLoginPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddLoginPassword);
            this.Controls.Add(this.buttonUpdateInfo);
            this.Controls.Add(this.dataGridViewListLoginPassword);
            this.Name = "FormLoginPassword";
            this.Text = "Логины и пароли";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListLoginPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListLoginPassword;
        private System.Windows.Forms.Button buttonUpdateInfo;
        private System.Windows.Forms.Button buttonAddLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}