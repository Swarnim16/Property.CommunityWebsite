using System;
using TechTalk.SpecFlow;
using Property.Community_OwnerPages;
using Xunit;
using OpenQA.Selenium.Chrome;

namespace PropertyOwner_Tests
{
    [Binding] 
    public class MyPropertyTestSteps
    {
        
        [Given(@"I have Login successfully using Property Owner Credentials")]
        public void GivenIHaveLoginSuccessfullyUsingPropertyOwnerCredentials()
        {
            MyPropertyPage.Can_Do_Login();
        }
        
        [Given(@"I have redirected to the Dashboard page")]
        public void GivenIHaveRedirectedToTheDashboardPage()
        {
            String currentPageTitle = MyPropertyPage.Can_getAfterLogin_pageTitle();
            String dashboardPageTitle = "Dashboard";
            Assert.Equal(dashboardPageTitle, currentPageTitle);

        }
        
        [When(@"I click on Owner and then Properties menu")]
        public void WhenIClickOnOwnerAndThenPropertiesMenu()
        {
            MyPropertyPage.Can_Goto_MyProperty();
        }
        
        [Then(@"I should have redirected to the MyProperties page")]
        public void ThenIShouldHaveRedirectedToTheMyPropertiesPage()
        {
            String actualPageTitle = MyPropertyPage.Check_MyProperty_Title();
            String expectedPageTitle = "Properties | Property Community";
            Assert.Equal(expectedPageTitle, actualPageTitle);
            MyPropertyPage.CloseBrowser();
        }
    }
}
