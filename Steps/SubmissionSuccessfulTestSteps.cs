using JupiterToys.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using TechTalk.SpecFlow;

namespace JupiterToys.Steps
{
    [Binding]
    public class SubmissionSuccessfulTestSteps
    {

        private IWebDriver driver;
        HomePage homePage;
        ContactPage contactPage;

        [BeforeScenario("TestCase2")]
        public void StartUp()
        {
            driver = new FirefoxDriver();
            homePage = new HomePage(driver);
            contactPage = new ContactPage(driver);
        }

        [AfterScenario("TestCase2")]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"Go to contact page")]
        public void GivenGoToContactPage()
        {
            homePage.goToHomePage();
            homePage.goToContactPage();
        }

        [Given(@"Filling mandatory fields")]
        public void GivenFillingMandatoryFields()
        {
            contactPage.fillForeName("Test One Name");
            contactPage.fillEmail("testing@gmail.com");
            contactPage.fillMessage("Testing");
        }

        [When(@"Click Submit")]
        public void WhenClickSubmit()
        {
            contactPage.clickSubmit();
        }

        [Then(@"the information message should be displayed")]
        public void ThenTheInformationMessageShouldBeDisplayed()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(contactPage.verifySuccessMessageIsDisplayed() is true);
        }
    }
}
