using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Property.Community_OwnerPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Property.Community_OwnerPages
{
    public class List_A_Rental_Page
    {
        //Rental Listings : page title
        public static void Can_Open_RentalPage()
        {
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            IWebElement listARentalButton = BrowserUtility.Instance.FindElement(By.LinkText("List A Rental"));
                
            listARentalButton.Click();
        }

        public static void Can_Enter_Input()
        {
            Thread.Sleep(2000);
            SelectElement selElement = new SelectElement(BrowserUtility.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div.field > select")));
                
            String rentalProperty = "50 Nelson, Penshurst, Sydney, 3333";
            
            foreach (IWebElement rentalElement in selElement.Options)
            {
                if(rentalElement.Text== rentalProperty)
                {
                    rentalElement.Click();
                    break;
                }
            }

            IWebElement titleInput= BrowserUtility.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(4) > div:nth-child(1) > input[type='text']:nth-child(2)"));
            IWebElement movingCostInput = BrowserUtility.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(4) > div:nth-child(1) > input[type='text']:nth-child(6)"));
            IWebElement targetRentInput = BrowserUtility.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(5) > div:nth-child(1) > input[type='text']"));
            IWebElement availableDateInput = BrowserUtility.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(6) > div:nth-child(1) > input[type='text']"));
            
            IWebElement occupantsCountInput = BrowserUtility.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(7) > div:nth-child(1) > input[type='text']"));
            IWebElement descriptionInput = BrowserUtility.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(4) > div:nth-child(2) > textarea"));

            titleInput.SendKeys("Sydney Properties");
            movingCostInput.SendKeys("2000");
            targetRentInput.SendKeys("3000");
            availableDateInput.SendKeys("18/07/2018");
            occupantsCountInput.SendKeys("4");
            descriptionInput.SendKeys("2BHK Apartment with 1 parking space.");

            //-----------------------------------------------------------------------

        }

        public static Boolean Can_Save_All_Input()
        {
            IWebElement saveButton = BrowserUtility.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div.ui.grid > div > button.teal.ui.button"));
            if (saveButton.Enabled == true)
            {
                saveButton.Click();
                BrowserUtility.Instance.SwitchTo().Alert().Accept();
                return true;              
            }
            else
                return false;

            
        }

        public static string returnPageTitleAfterSave()
        {
            String rentalListingPageTitle = "";
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WebDriverWait waitForElement = new WebDriverWait(BrowserUtility.Instance, TimeSpan.FromSeconds(30));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#main-content > div.container.segment > div:nth-child(1) > div.highlighted > div > div.middle.aligned.eight.wide.column > a")));
            rentalListingPageTitle =BrowserUtility.Instance.Title;
            return (rentalListingPageTitle);
            
        }

        public static void CloseBrowser()
        {
            BrowserUtility.CloseBrowser();
        }
    }
}
