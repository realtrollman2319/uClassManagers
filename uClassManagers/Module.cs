using Rocket.Core.Logging;
using SDG.Unturned;
using System;
using System.Reflection;
using uScript.Unturned;

namespace uClassManagers
{
    public static class C
    {
        public static void PrintLine(string message, ConsoleColor color = ConsoleColor.Gray, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteLine(string message) // This is for debugging
        {
            PrintLine($"[uClassManagers] {message}", ConsoleColor.DarkGray);
            Logs.printLine($"[Debug] {message}");
        }

        public static void WriteInfo(string message)
        {
            PrintLine($"[uClassManagers] {message}", ConsoleColor.Cyan);
            Logs.printLine($"[Info] {message}");

        }
        public static void WriteWarn(string message)
        {
            PrintLine($"[uClassManagers] {message}", ConsoleColor.Yellow);
            Logs.printLine($"[Warning] {message}");
            Logger.LogError(message);
        }

        public static void WriteError(string message)
        {
            PrintLine($"[uClassManagers] {message}", ConsoleColor.Red);
            Logs.printLine($"[Error] {message}");
        }
    }

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
            C.WriteInfo($"uClassManagers loaded! Version: {Assembly.GetExecutingAssembly().GetName().Version}");
            EnumTool.CreateEnums();
        }
    }
}