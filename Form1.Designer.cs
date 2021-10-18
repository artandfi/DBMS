
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.tbCreateDBName = new System.Windows.Forms.TextBox();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tbAddTableName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.tbAddColumnName = new System.Windows.Forms.TextBox();
            this.btnChooseFilePath = new System.Windows.Forms.Button();
            this.ofdChooseFilePath = new System.Windows.Forms.OpenFileDialog();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnDeleteColumn = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.sfdSaveDB = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.ofdOpenDB = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(30, 444);
            this.tabControl.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1940, 68);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(32, 37);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(188, 65);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(235, 34);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(188, 65);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "New DB";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(960, 34);
            this.btnAddColumn.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(188, 65);
            this.btnAddColumn.TabIndex = 3;
            this.btnAddColumn.Text = "Add Column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(1782, 34);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(188, 65);
            this.btnAddRow.TabIndex = 4;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // tbCreateDBName
            // 
            this.tbCreateDBName.Location = new System.Drawing.Point(235, 117);
            this.tbCreateDBName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbCreateDBName.Name = "tbCreateDBName";
            this.tbCreateDBName.Size = new System.Drawing.Size(244, 43);
            this.tbCreateDBName.TabIndex = 5;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(580, 34);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(188, 65);
            this.btnAddTable.TabIndex = 6;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tbAddTableName
            // 
            this.tbAddTableName.Location = new System.Drawing.Point(580, 117);
            this.tbAddTableName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbAddTableName.Name = "tbAddTableName";
            this.tbAddTableName.Size = new System.Drawing.Size(244, 43);
            this.tbAddTableName.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(32, 529);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 92;
            this.dataGridView.Size = new System.Drawing.Size(1938, 899);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "INT",
            "REAL",
            "CHAR",
            "STRING",
            "TEXT FILE",
            "INT INTERVAL"});
            this.cbTypes.Location = new System.Drawing.Point(960, 191);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(296, 45);
            this.cbTypes.TabIndex = 10;
            // 
            // tbAddColumnName
            // 
            this.tbAddColumnName.Location = new System.Drawing.Point(960, 117);
            this.tbAddColumnName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbAddColumnName.Name = "tbAddColumnName";
            this.tbAddColumnName.Size = new System.Drawing.Size(296, 43);
            this.tbAddColumnName.TabIndex = 11;
            // 
            // btnChooseFilePath
            // 
            this.btnChooseFilePath.Location = new System.Drawing.Point(1270, 327);
            this.btnChooseFilePath.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnChooseFilePath.Name = "btnChooseFilePath";
            this.btnChooseFilePath.Size = new System.Drawing.Size(188, 65);
            this.btnChooseFilePath.TabIndex = 12;
            this.btnChooseFilePath.Text = "Get file path";
            this.btnChooseFilePath.UseVisualStyleBackColor = true;
            this.btnChooseFilePath.Click += new System.EventHandler(this.btnChooseFilePath_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(1475, 327);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(489, 43);
            this.tbFilePath.TabIndex = 13;
            // 
            // btnDeleteColumn
            // 
            this.btnDeleteColumn.Location = new System.Drawing.Point(992, 268);
            this.btnDeleteColumn.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDeleteColumn.Name = "btnDeleteColumn";
            this.btnDeleteColumn.Size = new System.Drawing.Size(238, 65);
            this.btnDeleteColumn.TabIndex = 14;
            this.btnDeleteColumn.Text = "Delete Column";
            this.btnDeleteColumn.UseVisualStyleBackColor = true;
            this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(1782, 142);
            this.btnDeleteRow.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(188, 65);
            this.btnDeleteRow.TabIndex = 15;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(580, 191);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(242, 65);
            this.btnDeleteTable.TabIndex = 16;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(30, 120);
            this.btnSaveDB.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(188, 65);
            this.btnSaveDB.TabIndex = 17;
            this.btnSaveDB.Text = "Save";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(32, 268);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 65);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Location = new System.Drawing.Point(30, 350);
            this.btnCancelSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(188, 65);
            this.btnCancelSearch.TabIndex = 19;
            this.btnCancelSearch.Text = "Cancel";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(232, 313);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(489, 43);
            this.tbSearch.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1463);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnCancelSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnDeleteColumn);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnChooseFilePath);
            this.Controls.Add(this.tbAddColumnName);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tbAddTableName);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.tbCreateDBName);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "DBMS by Artem Fisunenko, MI-4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.TextBox tbCreateDBName;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox tbAddTableName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.TextBox tbAddColumnName;
        private System.Windows.Forms.Button btnChooseFilePath;
        private System.Windows.Forms.OpenFileDialog ofdChooseFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnDeleteColumn;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.SaveFileDialog sfdSaveDB;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.OpenFileDialog ofdOpenDB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}
