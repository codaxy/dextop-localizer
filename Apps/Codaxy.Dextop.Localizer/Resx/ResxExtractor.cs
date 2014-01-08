using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Resources;
using System.Collections;

namespace Codaxy.Dextop.Localizer
{
    public class ResxExtractor : EntityExtractor
    {
        String GetShortClassName(String className)
        {
            return className.Substring(className.LastIndexOf('.') + 1);
        }

        private LocalizableEntity GetLocalizableProperty(string filePath, string fieldName, string fieldValue)
        {
            var ee = new ClasslikeEntity {
                EntityNameForOverride = String.Empty,
                FilePath = filePath,
                FullEntityName = fieldName,
                ShortEntityName = String.Empty
            };

            return new LocalizableEntity
            {
                EnclosingEntity = ee,
                FullEntityPath = fieldName,
                IsQuoteEnclosed = false, // KISS
                EntityName = fieldName,
                ShallowEntityPath = fieldName,
                Value = fieldValue
            };
        }

        public override void ProcessFile(string filePath, Dictionary<string, LocalizableEntity> map)
        {
            Logger.LogFormat("Processing file {0}", filePath);
            try
            {
                using (var reader = new ResXResourceReader(filePath))
                {
                    var dict = reader.GetEnumerator();
                    while (dict.MoveNext())
                        map.Add(dict.Key.ToString(), GetLocalizableProperty(filePath, dict.Key.ToString(), dict.Value.ToString()));
                }

            }
            catch (Exception ex)
            {
                Logger.LogFormat("Error ({0})", filePath);
                throw ex;
            }
        }
    }
}
