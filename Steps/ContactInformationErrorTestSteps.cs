using JupiterToys.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace JupiterToys.Steps
{
    [Binding]
    public class ContactInformationErrorTestSteps
    {
        private IWebDriver driver;
        HomePage homePage;
        ContactPage contactPage;

        [BeforeScenario("TestCase3")]
        public void StartUp()
        {
            driver = new FirefoxDriver();
            homePage = new HomePage(driver);
            contactPage = new ContactPage(driver);
        }

        [AfterScenario("TestCase3")]
        public void TearDown()
        {
            driver.Quit();
        }
        [Given(@"From home page to contact page")]
        public void GivenFromHomePageToContactPage()
        {
            homePage.goToHomePage();
            homePage.goToContactPage();
        }
        
        [Given(@"Populate mandatory feilds with invalid data")]
        public void GivenPopulateMandatoryFeildsWithInvalidData()
        {
            contactPage.fillForeName("@#$%");
            contactPage.fillsurName("$%^&23");
            contactPage.fillEmail("testingEmail");
            contactPage.fillTelephone("testingPhone");
            contactPage.fillMessage("1234testing");
        }
        
        [When(@"After Finish filling feilds")]
        public void WhenPressSubmitButton()
        {
           // contactPage.clickSubmit();
        }
        
        [Then(@"Error message is displayed")]
        public void ThenErrorMessageIsDisplayed()
        {
        
            Assert.IsTrue(contactPage.verifyErrorMessageIsDisplayed() is true);
        }
    }
}
