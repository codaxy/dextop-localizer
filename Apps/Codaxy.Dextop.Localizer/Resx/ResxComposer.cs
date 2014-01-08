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
            StringBuilder sb = new StringBuilder();
            var stream = new MemoryStream();
            using (var writer = new ResXResourceWriter(stream))
            foreach (var block in blocks)
                foreach (var r in block.LocalizationGridRows)
                    writer.AddResource(r.LocalizableProperty.EntityName, r.Value);

            return Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}
