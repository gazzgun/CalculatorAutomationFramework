using SikuliSharp;
using System.IO;
using System.Reflection;

namespace CalculatorAutomationFramework.Common
{
    public static class SikuliSetup
    {
        public static ISikuliSession Session;

        public static ISikuliSession GetSession() => Session;

        public static void CreateSession()
        {
            Session = Sikuli.CreateSession();
        }
        public static string GetSikuliBasePath()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);
            return path;

        }
    }
}