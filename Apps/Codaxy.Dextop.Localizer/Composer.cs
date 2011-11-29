using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public class LocalizedEntityBlock
    {
        public String EntityNameForOverride { get; set; }
        public EntityLocalizationEntry[] LocalizationGridRows { get; set; }
    }

    public abstract class Composer
    {
        public static Composer CreateComposer(LocalizerType type)
        {
            switch (type)
            {
                case LocalizerType.JavaScript:
                    return new Js.JsComposer();
                case LocalizerType.Xml:
                    return new Xml.XmlComposer();
                default:
                    throw new NotImplementedException();
            }
        }

        public abstract String GenerateOutputFile(LocalizedEntityBlock[] blocks);
    }
}
