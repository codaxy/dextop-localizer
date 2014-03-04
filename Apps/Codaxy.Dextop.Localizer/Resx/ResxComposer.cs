using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Xml;

namespace Codaxy.Dextop.Localizer
{
    public class ResxComposer : Composer
    {
        public override string GenerateOutputFile(LocalizedEntityBlock[] blocks)
        {
            var ms = new MemoryStream();

            using (var resxw = new ResXResourceWriter(ms))
                foreach (var block in blocks)
                    foreach (var r in block.LocalizationGridRows)
                        resxw.AddResource(r.LocalizableProperty.EntityName, r.Value);

            var array = ms.ToArray();
            return Encoding.UTF8.GetString(array, 3, array.Length - 3);
        }
    }
}
