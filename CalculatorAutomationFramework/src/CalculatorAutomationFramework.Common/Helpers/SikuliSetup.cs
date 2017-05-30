using SikuliSharp;

namespace CalculatorAutomationFramework.Common
{
    public static class SikuliSetup
    {
        public static ISikuliSession Session;

        public static ISikuliSession GetSession()=> Session;

        public static void CreateSession()
        {
            Session = Sikuli.CreateSession();
        }
    }
}