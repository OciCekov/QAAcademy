using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SikuliModule;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;
using System.Diagnostics;
using System.Threading;

namespace TelerikSystem.SikuliTests
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly InputSimulator simulator = new InputSimulator();

        public static IKeyboardSimulator KeyBoard
        {
            get { return simulator.Keyboard; }
        }


        public void StartChromeBrowser()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("chrome");
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(startInfo);
        }

        [TestMethod]
        public void OpenTelerikAcademy()
        {
            StartChromeBrowser();
            // SikuliAction.Wait(Patterns.ChromeSearchBar, 20); -- java crashes
            Thread.Sleep(500);
            

            KeyBoard.TextEntry("test.telerikacademy.com");
            KeyBoard.KeyDown(VirtualKeyCode.RETURN); // Enter key is "Return" - quite confusing tbh...
        }
    }
}
