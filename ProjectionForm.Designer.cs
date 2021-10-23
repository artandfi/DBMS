
namespace DBMS {
    partial class ProjectionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.projectionView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.projectionView)).BeginInit();
            this.SuspendLayout();
            // 
            // projectionView
            // 
            this.projectionView.AllowUserToAddRows = false;
            this.projectionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectionView.Location = new System.Drawing.Point(0, 0);
            this.projectionView.Name = "projectionView";
            this.projectionView.RowHeadersWidth = 92;
            this.projectionView.RowTemplate.Height = 45;
            this.projectionView.Size = new System.Drawing.Size(1800, 1041);
            this.projectionView.TabIndex = 0;
            // 
            // ProjectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1041);
            this.Controls.Add(this.projectionView);
            this.Name = "ProjectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectionView";
            ((System.ComponentModel.ISupportInitialize)(this.projectionView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectionView;
    }
}