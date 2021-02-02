using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Redmine.SeleniumStuff
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            // driver = new ChromeDriver();
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public static void Close()
        {
            Instance.Quit();
        }

        internal static void Wait(int seconds)
        {
            Thread.Sleep(seconds * 0);
        }

        public static void OpenSecondTab()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Instance;
            js.ExecuteScript("window.open();");
            Thread.Sleep(400);
        }

        public static void GoToFirstTab()
        {
            Instance.SwitchTo().Window(Instance.WindowHandles[0]);
            Thread.Sleep(400);
        }

        public static void GoToSecondTab(string wantedUrl = null)
        {
            Instance.SwitchTo().Window(Instance.WindowHandles[1]);
            if (wantedUrl != null)
                Instance.Navigate().GoToUrl(wantedUrl);
            Thread.Sleep(400);
        }

        public static void GoToThirdTab(string wantedUrl = null)
        {
            Instance.SwitchTo().Window(Instance.WindowHandles[2]);
            if (wantedUrl != null)
                Instance.Navigate().GoToUrl(wantedUrl);
            Thread.Sleep(400);
        }
    }
    
}
