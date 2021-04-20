using JupiterToys.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace JupiterToys.Features
{
    [Binding]
    public class ContactInformationErrorGoneTestSteps
    {
        private IWebDriver driver;
        HomePage homePage;
        ContactPage contactPage;

        [BeforeScenario("TestCase1")]
        public void StartUp()
        {
            driver = new FirefoxDriver();
            homePage = new HomePage(driver);
            contactPage = new ContactPage(driver);
        }

        [AfterScenario("TestCase1")]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"Go to contact page and click the submit button")]
        public void GivenGoToContactPageAndClickTheSubmitButton()
        {
            homePage.goToHomePage();
            homePage.goToContactPage();
            contactPage.clickSubmit();
        }
        
        [Given(@"Error message is displayed")]
        public void GivenErrorMessageIsDisplayed()
        {
            Assert.IsTrue(contactPage.verifyErrorMessageIsDisplayed() is true);
        }
        
        [When(@"Populate mandatory fields")]
        public void WhenPopulateMandatoryFields()
        {
            contactPage.fillForeName("Test One Name");
            contactPage.fillEmail("testing@gmail.com");
            contactPage.fillMessage("Testing");
        }
        
        [Then(@"Validate error message is gone")]
        public void ThenValidateErrorMessageIsGone()
        {
            Assert.IsTrue(contactPage.verifyInfoMessageIsDisplayed() is true);
        }
    }
}
