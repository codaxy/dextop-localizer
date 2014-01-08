using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public class JsLocalizationModule : LocalizationModule
    {
        public override string Name
        {
            get { return "Javascript"; }
        }

        public override EntityExtractor CreateExtractor()
        {
            return new JsExtractor();
        }

        public override Composer CreateComposer()
        {
            return new JsComposer();
        }
    }
}
