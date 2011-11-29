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
    public partial class FrmDefineReference : Form
    {
        public FrmDefineReference()
        {
            InitializeComponent();
        }

        public String ReferenceDefinition
        {
            get { return tbReference.Text; }
        }

        private void btChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                tbReference.Text = ofd.FileName;
        }
    }
}
