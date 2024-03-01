using SDG.Unturned;
using System.IO;
using uScript.API.Attributes;

namespace uClassManagers.Modules
{
    [ScriptModule("uFile")]
    public static class uFileModule
    {
        [ScriptFunction("exists")]
        public static bool Exists(string directory)
        {
            if (Path.IsPathRooted(directory))
            {
                return File.Exists(directory);
            }
            else
            {
                return File.Exists($"{UnturnedPaths.RootDirectory.FullName}/Servers/{Provider.serverID}/uScript/Data/{directory}");
            }
        }
    }
}