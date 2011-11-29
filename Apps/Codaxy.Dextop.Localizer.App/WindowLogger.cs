using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Codaxy.Dextop.Localizer.Windows
{
    public class WindowLogger : ILogger
    {
        private ListBox lbLog;
        public WindowLogger(ListBox tb)
        {
            lbLog = tb;
        }

        #region ILogger Members

        public void Log(string log)
        {
            lbLog.Items.Insert(0, log);
        }
        
        public void LogFormat(string format, params object[] v)
        {
            lbLog.Items.Insert(0, String.Format(format, v));
        }

        public void ClearLog()
        {
            lbLog.Items.Clear();
        }

        #endregion
    }
}
