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
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        public DataGridView SearchSource { get; set; }
        public event EventHandler<SearchEventArgs> SearchRequested;

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            var handler = SearchRequested;
            if (handler != null)
                handler(this, new SearchEventArgs
                {
                    CheckFields = cbFields.Checked,
                    CheckValues = cbValues.Checked,
                    Pattern = tbPattern.Text,
                    SearchCriteria = rbContains.Checked ? SearchCriteria.Contains : SearchCriteria.StartsWith,
                    MatchCase = cbMatchCase.Checked
                });
        }
    }
    public enum SearchCriteria { StartsWith, Contains }

    public class SearchEventArgs : EventArgs
    {
        public String Pattern { get; set; }
        public bool CheckFields { get; set; }
        public bool CheckValues { get; set; }
        public bool MatchCase { get; set; }
        public SearchCriteria SearchCriteria { get; set; }
    }

}
