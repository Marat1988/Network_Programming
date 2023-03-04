using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Task1_4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            foreach (var item in this.Controls)
            {
                if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
                }
            }
            textBoxSearchLine.TextChanged += TextBoxSearchLine_TextChanged;
            buttonSearch.Click += ButtonSearch_Click;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchSystem search = new SearchSystem(comboBoxSearchSystem.Text, textBoxSearchLine.Text, comboBoxContentSearch.SelectedIndex);
            Process.Start(search.LineSearch());
        }

        private void TextBoxSearchLine_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = textBoxSearchLine.Text.Length > 0;
        }

    }
}
