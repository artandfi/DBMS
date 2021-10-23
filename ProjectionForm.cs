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
    public partial class ProjectionForm : Form {
        public ProjectionForm() {
            InitializeComponent();
        }

        public void RenderProjection(Table projection) {
            RenderColumns(projection);
            RenderRows(projection);
        }

        private void RenderColumns(Table table) {
            foreach (dynamic column in table.Columns) {
                var viewColumn = new DataGridViewTextBoxColumn {
                    Name = column.Name,
                    HeaderText = $"{column.Name} ({column.type})"
                };
                projectionView.Columns.Add(viewColumn);
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

                projectionView.Rows.Add(viewRow);
            }
        }
    }
}
