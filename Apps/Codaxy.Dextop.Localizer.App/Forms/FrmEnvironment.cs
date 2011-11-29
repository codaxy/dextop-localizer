using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Codaxy.Dextop.Localizer.Windows.Forms
{
    public partial class FrmEnvironment : Form
    {
        Dextop.Localizer.Windows.EnvironmentVariables env;
        public Dextop.Localizer.Windows.EnvironmentVariables Environment { get { return env; } set { env = value; dgvEnvironment.DataSource = env.Entries; } }

        public FrmEnvironment()
        {
            InitializeComponent();
            dgvEnvironment.AutoGenerateColumns = false;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvEnvironment.SelectedCells)
                Environment.Entries.Remove((EnvironmentVariable)cell.OwningRow.DataBoundItem);

            dgvEnvironment.DataSource = null;
            dgvEnvironment.DataSource = Environment.Entries;
            dgvEnvironment.Refresh();
        }

        private void dgvEnvironment_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var name = dgvEnvironment.Rows[e.RowIndex].Cells[0].Value;
            var value = dgvEnvironment.Rows[e.RowIndex].Cells[1].Value;

            if (name == null && value == null)
                return;

            if (name == null || String.IsNullOrEmpty(name.ToString())) {
                dgvEnvironment.Rows[e.RowIndex].ErrorText = "Property name must not be empty!";
                e.Cancel = true;
            }
        }
    }
}
