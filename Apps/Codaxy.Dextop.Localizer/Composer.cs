using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public class LocalizedEntityBlock
    {
        public String EntityNameForOverride { get; set; }
        public bool IsDextopLocalize { get; set; }
        public EntityLocalizationEntry[] LocalizationGridRows { get; set; }
    }

    public abstract class Composer
    {
        public abstract String GenerateOutputFile(LocalizedEntityBlock[] blocks);
    }
}
