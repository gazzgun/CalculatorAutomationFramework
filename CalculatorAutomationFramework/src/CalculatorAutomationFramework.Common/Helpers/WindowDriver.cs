﻿using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorAutomationFramework.Common.Helpers
{
    public static class WindowDriver
    {
        public static Window Window;
        public static Application Application;
        public static string ApplicationPath { get; set; }
        public static string ApplicationTitle { get; set; }

        public static Window Instance => Window ?? (Window = GrabWindow());

        public static Window GrabWindow()
        {
            Application = Application.Launch("C:\\Windows\\System32\\calc1.exe");
            Window = Application.GetWindow(ApplicationTitle);
            return Window;
        }


        public static Window SwitchWindow(string newWindowTitle)
        {
            var windows = Desktop.Instance.Windows();
            //Get all the windows on desktop            
            foreach (var t in windows)
            {
                var str = t.Title;
                if (str.Equals(newWindowTitle))
                    //compare which window title is matching to your string
                    Window = t;
                //    Assert.True(Window != null);
            }

            //  window = window.ModalWindow(newWindowTitle);
            //window = Retry.For(() => application.GetWindows().First(x => x.Title.Contains(newWindowTitle)),
            // TimeSpan.FromSeconds(5));
            return Window;
        }

        public static void CloseApplication()
        {
            Application?.Dispose();
        }

    }
}
