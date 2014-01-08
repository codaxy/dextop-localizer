using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public class ResxLocalizationModule : LocalizationModule
    {
        public override string Name
        {
            get { return "Resx"; }
        }

        public override EntityExtractor CreateExtractor()
        {
            return new ResxExtractor();
        }

        public override Composer CreateComposer()
        {
            return new ResxComposer();
        }
    }
}
