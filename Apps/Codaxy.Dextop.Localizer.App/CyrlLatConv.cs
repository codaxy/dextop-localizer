using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.NaturalLanguage.Tools;

namespace Codaxy.Dextop.Localizer.Windows
{
    class CyrlLatConv
    {
        public static String Convert(String text, bool toCyrillic)
        {
            //1. Add reference to MSTranslitTools.DLL (it can be found in %programfiles%\Microsoft Transliteration Utility)
            //2. Add Current translation files (.tms) can be found in %CommonProgramFiles%\Transliteration\Modules\Microsoft\
            //3. using System.NaturalLanguage.Tools;
            
            String direction;
            if(toCyrillic)
                direction = "SerbianLatintoCyrillic.tms";
            else
                direction = "SerbianCyrillictoLatin.tms";

            TransliteratorSpecification specification = TransliteratorSpecification.FromSpecificationFile(direction);
            Transliterator transliterator = Transliterator.FromSpecification(specification);
            String converted = transliterator.Transliterate(text);

            return converted;
        }
    }
}
