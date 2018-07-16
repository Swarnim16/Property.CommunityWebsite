using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Property.Community_OwnerPages
{
    public class LoginPage
    {
        public static string url = "http://new-keys.azurewebsites.net/Account/Login";
        public static void Go_To_Login_Page()
        {
            BrowserUtility.Initialize();
            BrowserUtility.GoToURL(url);

        }

        public static void Can_Enter_LoginData(String userName, String password)
        {
            //id="UserName" and id="Password"
            var userNameElement = BrowserUtility.Instance.FindElement(By.Id("UserName"));
            var passwordElement = BrowserUtility.Instance.FindElement(By.Id("Password"));


            userNameElement.Clear();
            userNameElement.SendKeys(userName);

            passwordElement.Clear();
            passwordElement.SendKeys(password);

        }

        public static void Enter_LoginData(String userName, String password)
        {
            //id="UserName" and id="Password"
            var userNameElement = BrowserUtility.Instance.FindElement(By.Id("UserName"));
            var passwordElement = BrowserUtility.Instance.FindElement(By.Id("Password"));


            userNameElement.Clear();
            userNameElement.SendKeys(userName);

            passwordElement.Clear();
            passwordElement.SendKeys(password);

        }

        public static void Can_Click_Login()
        {
            var loginButtonElement = BrowserUtility.Instance.FindElement(By.XPath("//*[@id='sign_in']/div[1]/div[4]/button"));
            
            loginButtonElement.Click();
            //Giving some wait time to load page fully
            BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);            

            IWebElement skipButtonElement = BrowserUtility.Instance.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]"));
            skipButtonElement.Click();
    
        }

        public static string Return_Title()
        {
            return BrowserUtility.Instance.Title;
            
        }
        public static void Close_Browser()
        {
            BrowserUtility.CloseBrowser();
        }

    }
}
