using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public abstract class LocalizationModule
    {
        public EntityExtractor Extractor { get; private set;  }
        public Composer Composer { get; private set;  }
        public abstract String Name { get; }

        public LocalizationModule()
        {
            Extractor = CreateExtractor();
            Composer = CreateComposer();
        }

        public abstract EntityExtractor CreateExtractor();
        public abstract Composer CreateComposer();

        public static LocalizationModule Create(LocalizerType type)
        {
            switch (type)
            {
                case LocalizerType.JavaScript: return new JsLocalizationModule();
                case LocalizerType.JavaScript2: return new Js2LocalizationModule();
                case LocalizerType.Xml: return new XmlLocalizationModule();
                case LocalizerType.Resx: return new ResxLocalizationModule();
                default:
                    throw new ArgumentException("Invalid type: " + type);
            }
        }
    }
}
