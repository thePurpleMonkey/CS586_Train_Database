using System;
using System.Windows.Forms;

namespace CS586_Train_Database
{
    public partial class AlertDialog : Form
    {
        public string Type;
        public int Minutes;

        public AlertDialog()
        {
            InitializeComponent();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Type = email_radioButton.Checked ? "Email" : "Text";
            Minutes = (int)minutes_before.Value;
        }
    }
}
