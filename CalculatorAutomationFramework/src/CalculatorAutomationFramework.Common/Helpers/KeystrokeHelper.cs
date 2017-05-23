using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace CalculatorAutomationFramework.Common.Helpers
{
    public class KeystrokeHelper
    {
        private static readonly InputSimulator InputSim = new InputSimulator();
        private static readonly KeyboardSimulator Keyboard = new KeyboardSimulator(InputSim);


        public static void SendText(string input)
        {
            Thread.Sleep(500);
            Keyboard.TextEntry(input);
        }

        public static void ButtonPress(int index, VirtualKeyCode virtualKeyCode)
        {
            for (var i = 0; i < index; i++)
                Keyboard.KeyPress(virtualKeyCode);
        }

        public static void KeyDownPress(VirtualKeyCode virtualKeyCode)
        {
            Keyboard.KeyDown(virtualKeyCode);
        }

        public static void KeyUp(VirtualKeyCode virtualKeyCode)
        {
            Keyboard.KeyUp(virtualKeyCode);
        }
    }
}
