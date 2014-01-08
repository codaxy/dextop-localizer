using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public class Js2LocalizationModule : LocalizationModule
    {
        public override string Name
        {
            get { return "Javascript simple"; }
        }

        public override EntityExtractor CreateExtractor()
        {
            return new Js2Extractor();
        }

        public override Composer CreateComposer()
        {
            return new Js2Composer();
        }
    }
}
