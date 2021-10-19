using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS {
    public partial class ColumnInputDialog : Form {
        public string ColumnName { get; private set; }
        public string ColumnType { get; private set; }

        public ColumnInputDialog() {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            ColumnName = textBox.Text;
            ColumnType = columnTypes.Text;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnOk.PerformClick();
            }
        }

        private void ColumnInputDialog_Load(object sender, EventArgs e) {
            columnTypes.SelectedIndex = 0;
        }
    }
}
