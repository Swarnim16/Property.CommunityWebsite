using System;
using TechTalk.SpecFlow;
using Property.Community_OwnerPages;
using Xunit;
using OpenQA.Selenium.Chrome;


namespace PropertyOwner_Tests
{
    [Binding] 
    public class LoginTestSteps
    {
        
        [Given(@"I have opened the Login page")]
        public void GivenIHaveOpenedTheLoginPage()
        {
            LoginPage.Go_To_Login_Page();
        }
        
        [Given(@"I have entered valid (.*), valid (.*)")]
        public void GivenIHaveEnteredValidValid(String userName, String password)
        {
            LoginPage.Can_Enter_LoginData(userName, password);
        }
        
        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            LoginPage.Can_Click_Login();
        }
        
        [Then(@"the Dashboard page should open")]
        public void ThenTheDashboardPageShouldOpen()
        {
            string title = LoginPage.Return_Title();

            Assert.Equal("Dashboard", title);
            LoginPage.Close_Browser();
        }

        
    }
}
