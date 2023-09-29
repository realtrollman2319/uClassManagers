using SDG.Unturned;
using System.IO;
using uScript.API.Attributes;
using uScript.Module.Main.Modules;

namespace uClassManagers.Extras.uFile
{
    [ScriptTypeExtension(typeof(FileModule))]
    public static class FileModuleExtension
    {
        [ScriptFunction("exists")]
        public static bool Exists(string directory)
        {
            return File.Exists(Path.Combine(UnturnedPaths.RootDirectory.ToString(), $"/servers/{Provider.serverID}/uScript/Data/{directory}"));
        }
    }
}
