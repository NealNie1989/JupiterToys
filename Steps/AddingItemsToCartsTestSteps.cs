using JupiterToys.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace JupiterToys.Steps
{
    [Binding]
    public class AddingItemsToCartsTestSteps
    {
        private IWebDriver driver;
        HomePage homePage;
        ShopPage shopPage;
        CartPage cartPage;
        [BeforeScenario("TestCase4")]
        public void StartUp()
        {
            driver = new FirefoxDriver();
            homePage = new HomePage(driver);
            shopPage = new ShopPage(driver);
            cartPage = new CartPage(driver);
        }

        [AfterScenario("TestCase4")]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"Go to shop page")]
        public void GivenGoToShopPage()
        {
            homePage.goToHomePage();
            homePage.goToShopPage();
        }
        
        [Given(@"Clicking buy Funny Cow (.*) times Fluffy Bunny (.*) time")]
        public void GivenClickingBuyFunnyCowTimesFluffyBunnyTime(int p0, int p1)
        {
            shopPage.buyFunnyCow(p0);
            shopPage.buyFluffyBunny(p1);
        }
        
        [When(@"Click the cart menu")]
        public void WhenClickTheCartMenu()
        {
            homePage.goToCarts();
        }
        
        [Then(@"verify the items are in the cart")]
        public void ThenVerifyTheItemsAreInTheCart()
        {
            Assert.IsTrue(cartPage.isTeddyBearExisted() is true);
            Assert.IsTrue(cartPage.isFuffyBunnyExisted() is true);

            Assert.AreEqual("2", cartPage.teddyBearCount());
            Assert.AreEqual("1", cartPage.fuffyBunnyCount());
        }
    }
}
