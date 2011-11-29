using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Codaxy.Dextop.Localizer.Xml
{
    public class XmlExtractor : EntityExtractor
    {
        String GetShortClassName(String className)
        {
            return className.Substring(className.LastIndexOf('.') + 1);
        }

        private LocalizableEntity GetLocalizableProperty(string filePath, string className, string fieldName, string fieldValue)
        {
            var ee = new ClasslikeEntity {
                EntityNameForOverride = className,
                FilePath = filePath,
                FullEntityName = className,
                ShortEntityName = GetShortClassName(className)
            };

            return new LocalizableEntity
            {
                EnclosingEntity = ee,
                FullEntityPath = className + "." + fieldName,
                IsQuoteEnclosed = false, // KISS
                EntityName = fieldName,
                ShallowEntityPath = ee.ShortEntityName + "." + fieldName,
                Value = fieldValue
            };
        }

        public override void ProcessFile(string filePath, Dictionary<string, LocalizableEntity> map)
        {
            Logger.LogFormat("Processing file {0}", filePath);
            XmlTextReader xr = new XmlTextReader(filePath);
            try
            {
                if (xr.ReadToDescendant("localization"))
                    if (xr.ReadToDescendant("type"))
                        do
                        {
                            var className = xr.GetAttribute("name");
                            if (xr.ReadToDescendant("field"))
                                do
                                {
                                    switch (xr.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            if (xr.Name == "field")
                                            {
                                                String fieldName = xr.GetAttribute("name");
                                                String fieldValue = xr.ReadElementContentAsString();
                                                LocalizableEntity property = GetLocalizableProperty(filePath, className, fieldName, fieldValue);
                                                map.Add(property.FullEntityPath, property);
                                            }
                                            break;
                                    }
                                } while (xr.ReadToNextSibling("field"));
                        } while (xr.ReadToNextSibling("type"));
            }
            catch (Exception ex)
            {
                Logger.LogFormat("Error ({0})", filePath);
                throw ex;
            }
            finally
            {
                xr.Close();
            }
        }
    }
}
