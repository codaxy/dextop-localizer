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
    public partial class FrmOutput : Form
    {
        public String OutputText
        {
            get { return tbOutput.Text; }
            set { tbOutput.Text = value; }
        }

        public String OutputFile
        {
            get { return tbOutputFile.Text; }
            set { tbOutputFile.Text = value; }
        }

        public FrmOutput()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChooseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog w = new SaveFileDialog();
            if (w.ShowDialog() == DialogResult.OK)
                tbOutputFile.Text = w.FileName;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(tbOutputFile.Text, tbOutput.Text, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
