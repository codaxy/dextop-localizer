using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codaxy.Dextop.Localizer
{
    public class Js2Composer : Composer
    {
        public override string GenerateOutputFile(LocalizedEntityBlock[] blocks)
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("/*");
            output.AppendLine(" * Auto-generated file");
            output.AppendLine(String.Format(" * {0}", DateTime.Now));
            output.AppendLine("*/");
            output.AppendLine();

            foreach (var block in blocks)
            {
                bool firstLine = true;

                output.AppendLine(String.Format("{0} = {{", block.EntityNameForOverride));


                foreach (var d in block.LocalizationGridRows)
                {
                    var value = d.LocalizableProperty.IsQuoteEnclosed ? ("'" + d.Value + "'") : d.Value;
                    output.AppendLine(String.Format("\t{0}{1}: {2}", firstLine ? "" : ",", d.LocalizableProperty.EntityName, value));
                    firstLine = false;
                }

                output.AppendLine("};");
                output.AppendLine();
            }

            return output.ToString();
        }
    }
}
