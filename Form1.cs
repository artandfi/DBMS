using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using static DBMS.DatabaseManager;

namespace DBMS {
    public partial class Form1 : Form {
        private const string _titleError = "Помилка";
        private const string _titleWarning = "Попередження";
        private const string _titleAddDatabase = "Додати базу даних";
        private const string _titleAddTable = "Додати таблицю";

        private const string _messageAddDatabase = "Назва бази даних";
        private const string _messageAddTable = "Назва таблиці";
        private const string _messageDeleteDatabase = "Ви впевнені, що хочете видалити цю базу даних?";
        private const string _messageDeleteTable = "Ви впевнені, що хочете видалити цю таблицю?";
        private const string _messageDeleteColumn = "Ви впевнені, що хочете видалити цей стовпчик?";
        private const string _messageDeleteRow = "Ви впевнені, що хочете видалити цей рядок?";

        private const string _errorEmptyDatabaseName = "Назву бази даних не задано";
        private const string _errorInvalidCharacters = "Назва бази даних містить неприпустимі символи";
        private const string _errorEmptyTableName = "Назву таблиці не задано";
        private const string _errorDuplicateTableName = "Таблиця з таким іменем вже існує";
        private const string _errorEmptyColumnName = "Назву стовпчика не задано";
        private const string _errorDuplicateColumnName = "Стовпчик з такою назвою вже існує";
        private const string _errorValidation = "Введіть значення типу ";

        private string _cellOldValue = "";
        private string _cellNewValue = "";

        private string _databasePath = "";
        private readonly DatabaseManager _dbManager = DatabaseManager.Instance;


        public Form1() {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        #region Database methods
        private void btnAddDatabase_Click(object sender, EventArgs e) {
            PromptDatabaseName();

            tabControl.TabPages.Clear();
            ClearTableView();
        }

        private void btnDeleteDatabase_Click(object sender, EventArgs e) {
            var dialogResult = MessageBox.Show(_messageDeleteDatabase, _titleWarning,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                _dbManager.DeleteDatabase(_databasePath);

                btnAddDatabase.Enabled = true;
                btnDeleteDatabase.Enabled = false;
                btnAddTable.Enabled = false;
                btnAddColumn.Enabled = false;
                btnDeleteColumn.Enabled = false;
                btnAddRow.Enabled = false;
                btnDeleteRow.Enabled = false;
                btnProject.Enabled = false;
            }
        }

        private void PromptDatabaseName() {
            string dbName = "";
            bool success = false;

            while (!success) {
                var inputDialog = new InputDialog(_messageAddDatabase, _titleAddDatabase);
                var dialogResult = inputDialog.ShowDialog();

                if (dialogResult == DialogResult.Cancel) {
                    return;
                }

                if (dialogResult == DialogResult.OK) {
                    dbName = inputDialog.Input;

                    if (dbName.Equals("")) {
                        MessageBox.Show(_errorEmptyDatabaseName, _titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(success = _dbManager.CreateDatabase(dbName))) {
                        MessageBox.Show(_errorInvalidCharacters, _titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            databaseNameLabel.Text = dbName;

            btnAddDatabase.Enabled = false;
            btnDeleteDatabase.Enabled = true;
            btnAddTable.Enabled = true;
        }
        #endregion

        #region Table methods
        private void btnAddTable_Click(object sender, EventArgs e) {
            PromptTableName();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e) {
            var dialogResult = MessageBox.Show(_messageDeleteTable, _titleWarning,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                int tableIndex = tabControl.SelectedIndex;

                _dbManager.DeleteTable(tableIndex);
                tabControl.TabPages.RemoveAt(tableIndex);

                if (tabControl.TabPages.Count == 0) {
                    btnDeleteTable.Enabled = false;
                    btnAddColumn.Enabled = false;
                    btnDeleteColumn.Enabled = false;
                    btnAddRow.Enabled = false;
                    btnDeleteRow.Enabled = false;
                    btnProject.Enabled = false;
                }
                else {
                    RenderTable(_dbManager.GetTable(tabControl.SelectedIndex));
                }
            }
        }

        private void PromptTableName() {
            string tableName = "";
            bool success = false;

            while (!success) {
                var inputDialog = new InputDialog(_messageAddTable, _titleAddTable);
                var dialogResult = inputDialog.ShowDialog();

                if (dialogResult == DialogResult.Cancel) {
                    return;
                }

                if (dialogResult == DialogResult.OK) {
                    tableName = inputDialog.Input;

                    if (tableName.Equals("")) {
                        MessageBox.Show(_errorEmptyTableName, _titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(success = _dbManager.AddTable(tableName))) {
                        MessageBox.Show(_errorDuplicateTableName, _titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            tabControl.TabPages.Add(tableName);
            btnDeleteTable.Enabled = true;
            btnAddColumn.Enabled = true;
        }
        #endregion

        #region Column methods
        private void btnAddColumn_Click(object sender, EventArgs e) {
            PromptColumnName();
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e) {
            var dialogResult = MessageBox.Show(_messageDeleteColumn, _titleWarning,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                _dbManager.DeleteColumn(tabControl.SelectedIndex, dataGridView.CurrentCell.ColumnIndex);
                RenderTable(_dbManager.GetTable(tabControl.SelectedIndex));

                if (dataGridView.ColumnCount == 0) {
                    btnDeleteColumn.Enabled = false;
                    btnAddRow.Enabled = false;
                    btnDeleteRow.Enabled = false;
                    btnProject.Enabled = false;
                }
            }
        }

        private void PromptColumnName() {
            int tableIndex = tabControl.SelectedIndex;
            bool success = false;

            while (!success) {
                var columnDialog = new ColumnInputDialog();
                var dialogResult = columnDialog.ShowDialog();

                if (dialogResult == DialogResult.Cancel) {
                    return;
                }

                if (dialogResult == DialogResult.OK) {
                    string columnName = columnDialog.ColumnName;
                    string columnType = columnDialog.ColumnType;

                    if (columnName.Equals("")) {
                        MessageBox.Show(_errorEmptyColumnName, _titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(success = _dbManager.AddColumn(tableIndex, ColumnFromString(columnName, columnType)))) {
                        MessageBox.Show(_errorDuplicateColumnName, _titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            RenderTable(_dbManager.GetTable(tableIndex));
            btnAddRow.Enabled = true;
        }
        #endregion

        #region Row methods
        private void btnAddRow_Click(object sender, EventArgs e) {
            int tableIndex = tabControl.SelectedIndex;

            _dbManager.AddRow(tableIndex);
            RenderTable(_dbManager.GetTable(tableIndex));
            btnDeleteRow.Enabled = true;
            btnDeleteColumn.Enabled = true;
            btnProject.Enabled = true;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e) {
            int tableIndex = tabControl.SelectedIndex;
            var dialogResult = MessageBox.Show(_messageDeleteRow, _titleWarning,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                _dbManager.DeleteRow(tableIndex, dataGridView.CurrentCell.RowIndex);
                RenderTable(_dbManager.GetTable(tableIndex));

                if (dataGridView.RowCount == 0) {
                    btnDeleteRow.Enabled = false;
                    btnDeleteColumn.Enabled = false;
                    btnProject.Enabled = false;
                }
            }
        }
        #endregion

        #region Cell methods
        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            _cellOldValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int tableIndex = tabControl.SelectedIndex;
            _cellNewValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (!_dbManager.ChangeCellValue(_cellNewValue, tableIndex, e.ColumnIndex, e.RowIndex)) {
                dynamic column = _dbManager.GetTable(tableIndex).Columns[e.ColumnIndex];

                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _cellOldValue;
                MessageBox.Show(_errorValidation + column.type, _titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region File methods
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdOpenDB.ShowDialog() == DialogResult.OK) {
                _dbManager.OpenDatabase(ofdOpenDB.FileName);
                tabControl.TabPages.Clear();
                databaseNameLabel.Text = _dbManager.Database.Name;

                List<string> tableNames = _dbManager.GetTableNames();

                foreach (string name in tableNames) {
                    tabControl.TabPages.Add(name);
                }

                int tableIndex = tabControl.SelectedIndex;

                if (tableIndex != -1) {
                    RenderTable(_dbManager.GetTable(tableIndex));

                    if (_dbManager.GetTable(tableIndex).Columns.Count > 0) {
                        btnProject.Enabled = true;
                    }
                }

                btnAddDatabase.Enabled = false;
                btnDeleteDatabase.Enabled = true;
                btnAddTable.Enabled = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            Stream stream;

            if (sfdSaveDB.ShowDialog() == DialogResult.OK) {
                if ((stream = sfdSaveDB.OpenFile()) != null) {
                    stream.Close();
                    _dbManager.SaveDatabase(sfdSaveDB.FileName);
                }
            }
        }
        #endregion

        #region Render methods
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
            foreach (dynamic column in table.Columns) {
                var viewColumn = new DataGridViewTextBoxColumn {
                    Name = column.Name,
                    HeaderText = $"{column.Name} ({column.type})"
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
        #endregion


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            int tableIndex = tabControl.SelectedIndex;

            if (tableIndex != -1) {
                RenderTable(_dbManager.GetTable(tableIndex));

                bool columnsExist = dataGridView.ColumnCount > 0;
                bool rowsExist = dataGridView.RowCount > 0;

                btnAddColumn.Enabled = true;
                btnAddRow.Enabled = columnsExist;
                btnDeleteColumn.Enabled = columnsExist && rowsExist;
                btnDeleteRow.Enabled = columnsExist && rowsExist;
                btnProject.Enabled = columnsExist;
            }
        }

        private void btnProject_Click(object sender, EventArgs e) {
            int tableIndex = tabControl.SelectedIndex;
            var cells = dataGridView.SelectedCells.Cast<DataGridViewCell>().ToList();
            var columnIndices = cells.GroupBy(c => c.ColumnIndex).Select(g => g.First().ColumnIndex).ToArray();
            var projection = _dbManager.Project(tableIndex, columnIndices);

            var table = _dbManager.GetTable(tableIndex);
            var projectionForm = new ProjectionForm {
                Text = $"{table.Name} - проекція"
            };

            projectionForm.RenderProjection(projection);
            projectionForm.Show();
        }
    }
}
