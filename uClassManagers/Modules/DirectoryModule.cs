using SDG.Unturned;
using System.IO;
using System.Collections.Generic;
using uScript.API.Attributes;

namespace uClassManagers.Modules
{
    [ScriptModule("directory")]
    public static class DirectoryModule
    {
        [ScriptFunction("exists")]
        public static bool Exists(string directory)
        {
            if (Path.IsPathRooted(directory))
            {
                return Directory.Exists(directory);
            }
            else
            {
                return Directory.Exists($"{UnturnedPaths.RootDirectory.FullName}/Servers/{Provider.serverID}/uScript/Data/{directory}");
            }
        }

        [ScriptFunction("createDirectory")]
        public static void CreateDirectory(string directory)
        {
            if (Path.IsPathRooted(directory))
            {
                Directory.CreateDirectory(directory);
            }
            else
            {
                Directory.CreateDirectory($"{UnturnedPaths.RootDirectory.FullName}/Servers/{Provider.serverID}/uScript/Data/{directory}");
            }
        }

        [ScriptFunction("listFiles")]
        public static List<string> ListFiles(string directory)
        {
            string fullPath;

            if (Path.IsPathRooted(directory))
            {
                fullPath = directory;
            }
            else
            {
                fullPath = $"{UnturnedPaths.RootDirectory.FullName}/Servers/{Provider.serverID}/uScript/Data/{directory}";
            }

            List<string> fileList = new List<string>();

            if (Directory.Exists(fullPath))
            {
                string[] files = Directory.GetFiles(fullPath);
                fileList.AddRange(files);
            }

            return fileList;
        }
    }
}
