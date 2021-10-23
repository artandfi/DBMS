
namespace DBMS {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ofdChooseFilePath = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveDB = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenDB = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTable = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteTable = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.проекціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProject = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(17, 101);
            this.tabControl.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1940, 68);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(19, 186);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 92;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(1938, 899);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // sfdSaveDB
            // 
            this.sfdSaveDB.Filter = "TDB files (*.tdb) |*.tdb|All Files (*.*)|*.*";
            this.sfdSaveDB.InitialDirectory = "C:\\";
            this.sfdSaveDB.RestoreDirectory = true;
            // 
            // ofdOpenDB
            // 
            this.ofdOpenDB.Filter = "TDB files|*.tdb|All files|*.*";
            this.ofdOpenDB.InitialDirectory = "C:\\";
            this.ofdOpenDB.RestoreDirectory = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.проекціяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2000, 47);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(103, 43);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(373, 48);
            this.openToolStripMenuItem.Text = "Відкрити";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(373, 48);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(194, 43);
            this.editToolStripMenuItem.Text = "Редагування";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDatabase,
            this.btnAddTable,
            this.btnAddColumn,
            this.btnAddRow});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(284, 48);
            this.addToolStripMenuItem.Text = "Додати";
            // 
            // btnAddDatabase
            // 
            this.btnAddDatabase.Name = "btnAddDatabase";
            this.btnAddDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.btnAddDatabase.Size = new System.Drawing.Size(468, 48);
            this.btnAddDatabase.Text = "Базу даних";
            this.btnAddDatabase.Click += new System.EventHandler(this.btnAddDatabase_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Enabled = false;
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.btnAddTable.Size = new System.Drawing.Size(468, 48);
            this.btnAddTable.Text = "Таблицю";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Enabled = false;
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.btnAddColumn.Size = new System.Drawing.Size(468, 48);
            this.btnAddColumn.Text = "Стовпчик";
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Enabled = false;
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.btnAddRow.Size = new System.Drawing.Size(468, 48);
            this.btnAddRow.Text = "Рядок";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteDatabase,
            this.btnDeleteTable,
            this.btnDeleteColumn,
            this.btnDeleteRow});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(284, 48);
            this.deleteToolStripMenuItem.Text = "Видалити";
            // 
            // btnDeleteDatabase
            // 
            this.btnDeleteDatabase.Enabled = false;
            this.btnDeleteDatabase.Name = "btnDeleteDatabase";
            this.btnDeleteDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.btnDeleteDatabase.Size = new System.Drawing.Size(448, 48);
            this.btnDeleteDatabase.Text = "Базу даних";
            this.btnDeleteDatabase.Click += new System.EventHandler(this.btnDeleteDatabase_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Enabled = false;
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.btnDeleteTable.Size = new System.Drawing.Size(448, 48);
            this.btnDeleteTable.Text = "Таблицю";
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnDeleteColumn
            // 
            this.btnDeleteColumn.Enabled = false;
            this.btnDeleteColumn.Name = "btnDeleteColumn";
            this.btnDeleteColumn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.btnDeleteColumn.Size = new System.Drawing.Size(448, 48);
            this.btnDeleteColumn.Text = "Стовпчик";
            this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Enabled = false;
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.btnDeleteRow.Size = new System.Drawing.Size(448, 48);
            this.btnDeleteRow.Text = "Рядок";
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // проекціяToolStripMenuItem
            // 
            this.проекціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProject});
            this.проекціяToolStripMenuItem.Name = "проекціяToolStripMenuItem";
            this.проекціяToolStripMenuItem.Size = new System.Drawing.Size(154, 43);
            this.проекціяToolStripMenuItem.Text = "Проекція";
            // 
            // btnProject
            // 
            this.btnProject.Enabled = false;
            this.btnProject.Name = "btnProject";
            this.btnProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.btnProject.Size = new System.Drawing.Size(403, 48);
            this.btnProject.Text = "Проекція";
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.databaseNameLabel.Location = new System.Drawing.Point(19, 55);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(0, 37);
            this.databaseNameLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1463);
            this.Controls.Add(this.databaseNameLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "DBMS by Artem Fisunenko, MI-4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog ofdChooseFilePath;
        private System.Windows.Forms.SaveFileDialog sfdSaveDB;
        private System.Windows.Forms.OpenFileDialog ofdOpenDB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddDatabase;
        private System.Windows.Forms.ToolStripMenuItem btnAddTable;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteDatabase;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteTable;
        private System.Windows.Forms.ToolStripMenuItem btnAddColumn;
        private System.Windows.Forms.ToolStripMenuItem btnAddRow;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteRow;
        private System.Windows.Forms.Label databaseNameLabel;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteColumn;
        private System.Windows.Forms.ToolStripMenuItem проекціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnProject;
    }
}
