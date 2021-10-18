using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static DBMS.DatabaseManager;

namespace DBMS {
    public partial class Form1 : Form {
        private const string _fileTypesFilter = "TDB files (*.tdb)|*.tdb)";

        private string _cellOldValue = "";
        private string _cellNewValue = "";
        private DatabaseManager _dbManager = DatabaseManager.Instance;


        public Form1() {
            InitializeComponent();
            cbTypes.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            _dbManager.CreateDatabase(tbCreateDBName.Text);
            tabControl.TabPages.Clear();
            ClearTableView();
        }

        private void btnAddTable_Click(object sender, EventArgs e) {
            if (_dbManager.AddTable(tbAddTableName.Text)) {
                tabControl.TabPages.Add(tbAddTableName.Text);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            int tableIndex = tabControl.SelectedIndex;

            if (tableIndex != -1) {
                RenderTable(_dbManager.GetTable(tableIndex));
            }
        }

        private void RenderTable(Table table) {
            try {
                ClearTableView();
                RenderColumns(table);
                RenderRows(table);
            }
            catch { }
        }


        private void ClearTableView() {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }

        private void RenderColumns(Table table) {
            foreach (var column in table.Columns) {
                var viewColumn = new DataGridViewTextBoxColumn {
                    Name = column.Name,
                    HeaderText = column.Name
                };
                dataGridView.Columns.Add(viewColumn);
            }
        }

        private void RenderRows(Table table) {
            foreach (var row in table.Rows) {
                var viewRow = new DataGridViewRow();

                foreach (string value in row.Values) {
                    var cell = new DataGridViewTextBoxCell {
                        Value = value
                    };
                    viewRow.Cells.Add(cell);
                }

                dataGridView.Rows.Add(viewRow);
            }
        }

        private void btnAddColumn_Click(object sender, EventArgs e) {
            var column = ColumnFromString(tbAddColumnName.Text, cbTypes.Text);
            
            if (_dbManager.AddColumn(tabControl.SelectedIndex, column)) {
                int tableIndex = tabControl.SelectedIndex;

                if (tableIndex != -1) {
                    RenderTable(_dbManager.GetTable(tableIndex));
                }
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e) {
            int tableIndex = tabControl.SelectedIndex;
            
            if (_dbManager.AddRow(tableIndex)) {
                if (tableIndex != -1) {
                    RenderTable(_dbManager.GetTable(tableIndex));
                }
            }
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            _cellOldValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            _cellNewValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int tableIndex = tabControl.SelectedIndex;

            if (!_dbManager.ChangeCellValue(_cellNewValue, tableIndex, e.ColumnIndex, e.RowIndex)) {
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _cellOldValue;
            }

            if (tableIndex != -1) {
                RenderTable(_dbManager.GetTable(tableIndex));
            }
        }

        private void btnChooseFilePath_Click(object sender, EventArgs e) {
            if (ofdChooseFilePath.ShowDialog() == DialogResult.OK) {
                tbFilePath.Text = ofdChooseFilePath.FileName;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e) {
            if (dataGridView.RowCount == 0) {
                return;
            }

            int tableIndex = tabControl.SelectedIndex;

            if (tableIndex != -1) {
                _dbManager.DeleteRow(tableIndex, dataGridView.CurrentCell.RowIndex);
                RenderTable(_dbManager.GetTable(tableIndex));
            }
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e) {
            if (dataGridView.ColumnCount == 0) {
                return;
            }

            int tableIndex = tabControl.SelectedIndex;

            if (tableIndex != -1) {
                _dbManager.DeleteColumn(tableIndex, dataGridView.CurrentCell.ColumnIndex);
                RenderTable(_dbManager.GetTable(tableIndex));
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e) {
            if (tabControl.TabCount == 0) {
                return;
            }

            int tableIndex = tabControl.SelectedIndex;

            if (tableIndex != -1) {
                _dbManager.DeleteTable(tableIndex);
                tabControl.TabPages.RemoveAt(tableIndex);
                tableIndex = tabControl.SelectedIndex;
                
                if (tableIndex != -1) {
                    RenderTable(_dbManager.GetTable(tableIndex));
                }
            }
        }

        private void btnSaveDB_Click(object sender, EventArgs e) {
            Stream stream;

            sfdSaveDB.Filter = _fileTypesFilter;
            sfdSaveDB.FilterIndex = 1;
            sfdSaveDB.RestoreDirectory = true;

            if (sfdSaveDB.ShowDialog() == DialogResult.OK) {
                if ((stream = sfdSaveDB.OpenFile()) != null) {
                    stream.Close();
                    _dbManager.SaveDatabase(sfdSaveDB.FileName);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            ofdOpenDB.Filter = _fileTypesFilter;
            ofdOpenDB.FilterIndex = 1;
            ofdOpenDB.RestoreDirectory = true;

            if (ofdChooseFilePath.ShowDialog() == DialogResult.OK) {
                _dbManager.OpenDatabase(ofdOpenDB.FileName);
            }

            tabControl.TabPages.Clear();
            
            List<string> tableNames = _dbManager.GetTableNames();

            foreach (string name in tableNames) {
                tabControl.TabPages.Add(name);
            }

            int tableIndex = tabControl.SelectedIndex;
            
            if (tableIndex != -1) {
                RenderTable(_dbManager.GetTable(tableIndex));
            }
        }
    }
}
