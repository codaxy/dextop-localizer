using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Codaxy.Dextop.Localizer.Windows
{
    public class EnvironmentVariable
    {
        public String Name { get; set; }
        public String Value { get; set; }
    }

    public class EnvironmentVariables
    {
        public BindingList<EnvironmentVariable> Entries { get; set; }
        public EnvironmentVariables()
        {
            Entries = new BindingList<EnvironmentVariable>();
        }
        public EnvironmentVariable this[String name]
        {
            get
            {
                return Entries.SingleOrDefault(a => a.Name == name);
            }
        }
    }
}
