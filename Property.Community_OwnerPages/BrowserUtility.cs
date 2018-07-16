using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Property.Community_OwnerPages
{
    public class BrowserUtility
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--disable-notifications");
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public static void GoToURL(string url)
        {
            Instance.Url = url;
        }

        public static string ReturnTitle()
        {
            return Instance.Title;
        }


        public static void CloseBrowser()
        {
            BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Instance.Close();
            Instance.Dispose();
        }

    }
}
