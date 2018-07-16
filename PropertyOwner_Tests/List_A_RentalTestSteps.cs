using System;
using TechTalk.SpecFlow;
using Property.Community_OwnerPages;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace PropertyOwner_Tests
{
    [Binding]
    public class List_A_RentalTestSteps
    {
        [Given(@"I have logged in successfully using Property Owner Credentials")]
        public void GivenIHaveLoggedInSuccessfullyUsingPropertyOwnerCredentials()
        {
            BaseClass.Do_Login();
        }
        
        [Given(@"I have redirected to the Property page")]
        public void GivenIHaveRedirectedToThePropertyPage()
        {
            MyPropertyPage.Can_getAfterLogin_pageTitle();
            MyPropertyPage.Can_Goto_MyProperty();
            MyPropertyPage.Check_MyProperty_Title();
        }
        
        [When(@"I clicked the List A Rental button")]
        public void WhenIClickedTheListARentalButton()
        {
            List_A_Rental_Page.Can_Open_RentalPage();
        }
        
        [When(@"I entered valid values into List Rental Property page")]
        public void WhenIEnteredValidValuesIntoListRentalPropertyPage()
        {
            List_A_Rental_Page.Can_Enter_Input();
        }
        
        [When(@"I clicked the Save button")]
        public void WhenIClickedTheSaveButton()
        {
            Boolean saveButtonIsEnable = true;
            saveButtonIsEnable= List_A_Rental_Page.Can_Save_All_Input();
            Assert.Equal(saveButtonIsEnable, true);
        }
        
        [Then(@"successfull save message should deisplay")]
        public void ThenSuccessfullSaveMessageShouldDeisplay()
        {
            String expectedTitle = "Rental Listings";
            String actualTitle = List_A_Rental_Page.returnPageTitleAfterSave();
            Assert.Equal(expectedTitle, actualTitle);
            List_A_Rental_Page.CloseBrowser();
        }
    }
}
