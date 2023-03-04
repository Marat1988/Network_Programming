
namespace Task1_4
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxContentSearch = new System.Windows.Forms.ComboBox();
            this.labelSearchLine = new System.Windows.Forms.Label();
            this.labelContentSearch = new System.Windows.Forms.Label();
            this.textBoxSearchLine = new System.Windows.Forms.TextBox();
            this.comboBoxSearchSystem = new System.Windows.Forms.ComboBox();
            this.labelSearchSystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(321, 73);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 32);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Поиск в браузере";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxContentSearch
            // 
            this.comboBoxContentSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContentSearch.FormattingEnabled = true;
            this.comboBoxContentSearch.Items.AddRange(new object[] {
            "Общий поиск",
            "Поиск изображений"});
            this.comboBoxContentSearch.Location = new System.Drawing.Point(414, 31);
            this.comboBoxContentSearch.Name = "comboBoxContentSearch";
            this.comboBoxContentSearch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContentSearch.TabIndex = 4;
            // 
            // labelSearchLine
            // 
            this.labelSearchLine.AutoSize = true;
            this.labelSearchLine.Location = new System.Drawing.Point(12, 83);
            this.labelSearchLine.Name = "labelSearchLine";
            this.labelSearchLine.Size = new System.Drawing.Size(85, 13);
            this.labelSearchLine.TabIndex = 6;
            this.labelSearchLine.Text = "Строка поиска:";
            // 
            // labelContentSearch
            // 
            this.labelContentSearch.AutoSize = true;
            this.labelContentSearch.Location = new System.Drawing.Point(318, 34);
            this.labelContentSearch.Name = "labelContentSearch";
            this.labelContentSearch.Size = new System.Drawing.Size(90, 13);
            this.labelContentSearch.TabIndex = 3;
            this.labelContentSearch.Text = "Контент поиска:";
            // 
            // textBoxSearchLine
            // 
            this.textBoxSearchLine.Location = new System.Drawing.Point(110, 80);
            this.textBoxSearchLine.Name = "textBoxSearchLine";
            this.textBoxSearchLine.Size = new System.Drawing.Size(205, 20);
            this.textBoxSearchLine.TabIndex = 5;
            // 
            // comboBoxSearchSystem
            // 
            this.comboBoxSearchSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchSystem.FormattingEnabled = true;
            this.comboBoxSearchSystem.Items.AddRange(new object[] {
            "https://www.google.com/",
            "https://yandex.ru/"});
            this.comboBoxSearchSystem.Location = new System.Drawing.Point(130, 31);
            this.comboBoxSearchSystem.Name = "comboBoxSearchSystem";
            this.comboBoxSearchSystem.Size = new System.Drawing.Size(168, 21);
            this.comboBoxSearchSystem.TabIndex = 1;
            // 
            // labelSearchSystem
            // 
            this.labelSearchSystem.AutoSize = true;
            this.labelSearchSystem.Location = new System.Drawing.Point(12, 34);
            this.labelSearchSystem.Name = "labelSearchSystem";
            this.labelSearchSystem.Size = new System.Drawing.Size(112, 13);
            this.labelSearchSystem.TabIndex = 2;
            this.labelSearchSystem.Text = "Поисковая система:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 165);
            this.Controls.Add(this.labelContentSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchLine);
            this.Controls.Add(this.comboBoxContentSearch);
            this.Controls.Add(this.labelSearchSystem);
            this.Controls.Add(this.labelSearchLine);
            this.Controls.Add(this.comboBoxSearchSystem);
            this.Name = "FormMain";
            this.Text = "SearchTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxContentSearch;
        private System.Windows.Forms.Label labelSearchLine;
        private System.Windows.Forms.Label labelContentSearch;
        private System.Windows.Forms.TextBox textBoxSearchLine;
        private System.Windows.Forms.ComboBox comboBoxSearchSystem;
        private System.Windows.Forms.Label labelSearchSystem;
    }
}

