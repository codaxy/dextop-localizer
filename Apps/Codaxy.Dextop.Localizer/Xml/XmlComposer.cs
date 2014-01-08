using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Codaxy.Dextop.Localizer
{
    public class XmlComposer : Composer
    {
        public override string GenerateOutputFile(LocalizedEntityBlock[] blocks)
        {
            StringBuilder sb = new StringBuilder();
            XmlWriter xw = XmlWriter.Create(sb, new XmlWriterSettings {
                Indent = true,
                OmitXmlDeclaration = true,
                NewLineChars = "\r\n"
            });
            xw.WriteStartElement("localization");
            foreach (var block in blocks)
            {
                xw.WriteStartElement("type");
                xw.WriteAttributeString("name", block.EntityNameForOverride);
                foreach (var r in block.LocalizationGridRows)
                {
                    xw.WriteStartElement("field");
                    xw.WriteAttributeString("name", r.LocalizableProperty.EntityName);
                    xw.WriteValue(r.Value);
                    xw.WriteEndElement();
                }
                xw.WriteEndElement();
            }
            xw.WriteEndElement();
            xw.Close();
            return sb.ToString();
        }
    }
}
