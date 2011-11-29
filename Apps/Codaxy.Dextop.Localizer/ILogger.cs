using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public interface ILogger
    {
        void Log(string log);
        void LogFormat(string format, params object[] v);
        void ClearLog();
    }
}
