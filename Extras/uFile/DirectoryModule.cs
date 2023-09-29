using SDG.Unturned;
using System.IO;
using uScript.API.Attributes;

namespace uClassManagers.Extras.uFile
{
    [ScriptModule("directory")]
    public static class DirectoryModule
    {
        [ScriptFunction("exists")]
        public static bool Exists(string directory)
        {
            return Directory.Exists($"{UnturnedPaths.RootDirectory.FullName}/Servers/{Provider.serverID}/uScript/Data/{directory}");
        }

        [ScriptFunction("createDirectory")]
        public static void CreateDirectory(string directory)
        {
            Directory.CreateDirectory($"{UnturnedPaths.RootDirectory.FullName}/Servers/{Provider.serverID}/uScript/Data/{directory}");
        }
    }
}
