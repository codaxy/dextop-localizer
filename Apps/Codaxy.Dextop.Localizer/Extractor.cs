using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Codaxy.Dextop.Localizer
{
    public class ClasslikeEntity
    {
        public String FullEntityName { get; set; } // e.g. eBroker.window.SimpleWindow or Dextop.common
        public String ShortEntityName { get; set; } // e.g. SimpleWindow or common
        public String EntityNameForOverride { get; set; } // e.g. eBroker.window.SimpleWindow.prototype or Dextop.common
        public String FilePath { get; set; }
        public bool IsDextopLocalize { get; set; }
    }

    public class LocalizableEntity
    {
        public ClasslikeEntity EnclosingEntity { get; set; }
        public String FullEntityPath { get; set; }  // e.g. eBroker.window.SimpleWindow.prototype.title or Dextop.common.saveText
        public String ShallowEntityPath { get; set; } // e.g. SimpleWindow.title or common.saveText
        public String EntityName { get; set; }   // e.g. title or saveText
        public String Value { get; set; }
        public bool IsQuoteEnclosed { get; set; }
    }

    public abstract class EntityExtractor
    {
        public ILogger Logger { get; set; }

        void Log(String format, params object[] v)
        {
            if (Logger != null)
                Logger.LogFormat(format, v);
        }

        public abstract void ProcessFile(String filePath, Dictionary<String, LocalizableEntity> map);

        public void ProcessFile(String filePath, HashSet<String> excludePaths, Dictionary<String, LocalizableEntity> map)
        {
            if (excludePaths.Contains(filePath))
            {
                Logger.LogFormat("Skipping excluded file: {0}", filePath);
                return;
            }

            ProcessFile(filePath, map);
        }

        public void ProcessFolder(String dirPath, HashSet<String> excludePaths, String searchPattern, Dictionary<String, LocalizableEntity> map)
        {
            if (excludePaths.Contains(dirPath + @"\"))
            {
                Logger.LogFormat("Skipping excluded folder: {0}", dirPath);
                return;
            }

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dirPath);
            if ((dir.Attributes & FileAttributes.Hidden) != 0)
                return;

            Logger.LogFormat("Entering directory {0}", dirPath);

            foreach (var file in dir.GetFiles(searchPattern))
                ProcessFile(file.FullName, excludePaths, map);

            foreach (var subdir in dir.GetDirectories())
                ProcessFolder(subdir.FullName, excludePaths, searchPattern, map);
        }

        String ComposePath(String rootFolder, String name)
        {
            return Path.Combine(rootFolder, name.Replace(@"/", @"\").Replace(@"\\", @"\"));
        }
        
        public void ProcessFileList(String[] includes, String[] excludes, String rootFolder, String searchPattern, Dictionary<String, LocalizableEntity> map)
        {
            try
            {
                List<String> includePaths = new List<string>();
                HashSet<String> excludePaths = new HashSet<string>();

                foreach (var name in excludes)
                {
                    var path = ComposePath(rootFolder, name);
                    excludePaths.Add(path);
                }

                foreach (var name in includes)
                {
                    var path = ComposePath(rootFolder, name);
                    includePaths.Add(path);
                }

                foreach (var path in includePaths)
                {
                    if (path.EndsWith(@"\"))
                        ProcessFolder(path, excludePaths, searchPattern, map);
                    else
                        ProcessFile(path, excludePaths, map);
                }
                Logger.Log("Success all");
            }
            catch (Exception ex)
            {
                Logger.LogFormat("Error ({0})", ex.Message);
                throw ex;
            }
        }


        public String GetShortFileName(String filePath)
        {
            var l = filePath.LastIndexOf("\\");
            return (l != -1) ? filePath.Substring(l + 1) : filePath;
        }
    }
}
