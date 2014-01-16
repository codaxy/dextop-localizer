using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Codaxy.Dextop.Localizer
{
    public class Js2Extractor : EntityExtractor
    {
        static String id = @"[a-zA-Z_][a-zA-Z0-9_]*";
        static String idx = @"[a-zA-Z_][a-zA-Z0-9_.\[\]'" + "\"" + @"]*"; // Literal "
        static String indent = @"([ ]{1,5}|\t)";

        static Regex CreateRegex(String regex)
        {
            return new Regex(regex
                .Replace("{id}", id)
                .Replace("{idx}", idx)
                .Replace("{indent}", indent), RegexOptions.Compiled);
        }

        static Regex linePlainObject = CreateRegex(@"^(?<name>{id}\.{idx})\s*=\s*{"); // e.g. eBroker.App = {
        static Regex lineForLocalizationSimple = CreateRegex(@"^{indent}*,?(?<name>{id})\s*:\s*(?<value>.+)\s*,?$"); // e.g. localizationText: 'Text' or title: 'Title'

        String GetShortObjectName(String objectName)
        {
            var l = objectName.IndexOf('[');
            if (l == -1)
                return objectName.Substring(objectName.LastIndexOf('.') + 1);
            else
                return objectName.Substring(objectName.Substring(0, l).LastIndexOf('.') + 1);
        }

        ClasslikeEntity ProcessEntityDefinitionLine(String filePath, String line) {
            var m4 = linePlainObject.Match(line);
            if (m4.Success)
            {
                var on = m4.Result("${name}"); // Object name (e.g. eBroker.App)
                return new ClasslikeEntity
                {
                    FilePath = filePath,
                    FullEntityName = on,
                    EntityNameForOverride = on,
                    ShortEntityName = GetShortObjectName(on)
                };
            }

            else
                return null;
        }

        LocalizableEntity ProcessPropertyLine(ClasslikeEntity jsObject, String line)
        {
            Match m1;

            m1 = lineForLocalizationSimple.Match(line);

            if (m1.Success)
            {
                var name = m1.Result("${name}");
                var value = m1.Result("${value}").TrimEnd(',', ';', ' ', '\t', '\r', '\n');
                bool quotes = (value.StartsWith("'") && value.EndsWith("'"));
                bool dquotes = (value.StartsWith("\"") && value.EndsWith("\""));
                return new LocalizableEntity
                {
                    EnclosingEntity = jsObject,
                    EntityName = name,
                    ShallowEntityPath = jsObject.ShortEntityName + "." + name,
                    FullEntityPath = jsObject.EntityNameForOverride + "." + name,
                    IsQuoteEnclosed = quotes,
                    Value = quotes ? value.TrimStart('\'').TrimEnd('\'') : 
                            (dquotes ? value.TrimStart('"').TrimEnd('"') : value)
                };
            }

            else
                return null;
        }

        public override void ProcessFile(String filePath, Dictionary<String, LocalizableEntity> map)
        {
            
            ClasslikeEntity jsObject = null;
            System.IO.TextReader reader = new System.IO.StreamReader(filePath, Encoding.UTF8);
            //Logger.LogFormat("Processing file {0}", filePath);
            try
            {
                while (reader.Peek() > 0)
                {
                    String line = reader.ReadLine();
                    ClasslikeEntity o = ProcessEntityDefinitionLine(filePath, line);
                    if (o != null)
                        jsObject = o;

                    else if (jsObject != null) {
                        LocalizableEntity prop = ProcessPropertyLine(jsObject, line);
                        if (prop != null && !map.ContainsKey(prop.FullEntityPath))
                            map.Add(prop.FullEntityPath, prop);
                    }
                }
                Logger.LogFormat("Processing file {0} - Success", filePath);
            }
            catch (Exception ex)
            {
                Logger.LogFormat("Processing file {0} - Error", filePath);
                throw ex;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
