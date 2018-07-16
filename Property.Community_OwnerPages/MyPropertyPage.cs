using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Property.Community_OwnerPages;
using System.Threading;

namespace Property.Community_OwnerPages  
{
    public class MyPropertyPage
    {
        public static void Can_Do_Login()
        {
            BaseClass.Do_Login();

        }
        public static String Can_getAfterLogin_pageTitle()
        {
            BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Debug.WriteLine("Getting Title");
            
            return LoginPage.Return_Title();
            
        }
        public static void Can_Goto_MyProperty()
        {
            WebDriverWait wait = new WebDriverWait(BrowserUtility.Instance, TimeSpan.FromMinutes(1));
            //Giving some wait time to load page fully
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Debug.WriteLine("Getting Property Menu page ");
            Thread.Sleep(1000);

            //wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[2]/div[1]")));
              //  "//*[@class='ui dropdown item']//*[text()='Owners')]")));
            //AND Contains(text(), 'Owners')
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div[2]/div[1]")));
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement ownerMenu = BrowserUtility.Instance.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]"));
            ownerMenu.Click();
            //ownerMenu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]"));
            //SelectElement ownerMenu = new SelectElement(BrowserUtility.Instance.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/i")));
            //ownerMenu.SelectByText("Properties");
           // BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           // wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]")));
            IWebElement propertyMenu = BrowserUtility.Instance.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]"));
            propertyMenu.Click();
        }

        public static String Check_MyProperty_Title()
        {
            BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return BrowserUtility.Instance.Title;
        }
        public static void CloseBrowser()
        {
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            BrowserUtility.CloseBrowser();
        }

    }
}
