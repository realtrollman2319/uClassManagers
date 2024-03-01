using SDG.Unturned;
using System.IO;
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
    }
}
