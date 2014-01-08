using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public class XmlLocalizationModule : LocalizationModule
    {
        public override string Name
        {
            get { return "Xml"; }
        }

        public override EntityExtractor CreateExtractor()
        {
            return new XmlExtractor();
        }

        public override Composer CreateComposer()
        {
            return new XmlComposer();
        }
    }
}
