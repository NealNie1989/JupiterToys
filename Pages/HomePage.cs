using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace JupiterToys.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        static String url = "https://jupiter.cloud.planittesting.com/";

        [FindsBy(How = How.CssSelector, Using = "[id$='nav-home']")]
        private IWebElement home;

        [FindsBy(How = How.CssSelector, Using = "[id$='nav-shop']")]
        private IWebElement shop;

        [FindsBy(How = How.CssSelector, Using = "[id$='nav-contact']")]
        private IWebElement contact;

        [FindsBy(How = How.CssSelector, Using = "[id$='nav-cart']")]
        private IWebElement carts;


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
           PageFactory.InitElements(driver, this);
        }
        public void goToHomePage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void goToContactPage()
        {
            contact.Click();
        }

        public void goToShopPage()
        {
            shop.Click();
        }

        public void goToCarts()
        {
            carts.Click();
        }
    }
}
