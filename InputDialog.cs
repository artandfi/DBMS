using System;
using System.Windows.Forms;

namespace DBMS {
    public partial class InputDialog : Form {
        public string Input { get; private set; }

        public InputDialog(string message, string title) {
            InitializeComponent();
            messageLabel.Text = message;
            Text = title;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            Input = textBox.Text;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnOk.PerformClick();
            }
        }
    }
}
