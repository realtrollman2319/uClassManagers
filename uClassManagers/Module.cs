using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using uScript.Unturned;

namespace uClassManagers
{
    public partial class Module : ScriptModuleBase
    {
        /*
        static async Task<string> GetGithubVer()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "uClassManagers - C# Asssembly");
                var url = "https://api.github.com/repos/realtrollman2319/uClassManagers/releases/latest";
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
                string json = await client.GetStringAsync(url);

                dynamic latestRelease = JsonConvert.DeserializeObject(json);
                return latestRelease.tag_name;
            }
        }

        private static Assembly currentAssembly;
        private static AssemblyName name;
        */

        protected override void OnModuleLoaded()
        {
            /*
            // https://api.github.com/repos/realtrollman2319/uClassManagers/releases/latest
            currentAssembly = Assembly.GetExecutingAssembly();
            name = currentAssembly.GetName();
            Version ver = name.Version;

            Console.WriteLine($"{name.Name} loaded! Version: {ver}");
            string githubVer = GetGithubVer().Result;
            if (ver.ToString() != githubVer)
            {
                Console.WriteLine("A new update is available on GitHub. Download it here:");
                Console.WriteLine("https://github.com/realtrollman2319/uClassManagers/releases/tag/" + githubVer);
            }
            else
            {
                Console.WriteLine($"You're up to date.");
            }
            */

            // Create classes for Enums to use
            EnumTool.CreateEnums();
        }
    }
}