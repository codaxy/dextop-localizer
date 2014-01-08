using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Codaxy.Dextop.Localizer
{
    public enum LocalizerType { 
        JavaScript = 0, 
        Xml = 1,
        JavaScript2 = 2,
        Resx = 3
    };

    public class LocalizationProfile
    {
        public LocalizerType LocalizerType { get; set; }
        public String InputFiles { get; set; }
        public String RootFolderPath { get; set; }
        public String ReferenceFilePath { get; set; }
    }

    public class EntityLocalizationEntry
    {
        public bool IsChecked { get; set; }
        public String Property { get; set; }
        public String OriginalValue { get; set; }
        public String Value { get; set; }
        public LocalizableEntity LocalizableProperty { get; set; }
    }

}
