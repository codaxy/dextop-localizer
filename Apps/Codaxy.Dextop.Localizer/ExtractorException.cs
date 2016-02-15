using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public class ExtractorException : Exception
    {
        public ExtractorException() : base() { }
        public ExtractorException(string message) : base(message) { }
        public ExtractorException(string message, params object[] args) : base(String.Format(message, args)) { }
        public ExtractorException(Exception innerException, string message, params object[] args) : base(String.Format(message, args), innerException) { }
    }
}
