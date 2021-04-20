using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace JupiterToys.Pages
{
    class CartPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//table[@class='table table-striped cart-items']/tbody/tr[1]/td[1]")]
        private IWebElement teddyBearItem;

        [FindsBy(How = How.XPath, Using = ".//table[@class='table table-striped cart-items']/tbody/tr[2]/td[1]")]
        private IWebElement fluffyBunnyItem;


        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public Boolean isTeddyBearExisted()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//table[@class='table table-striped cart-items']/tbody/tr[1]/td[1]")));

            return teddyBearItem.Displayed;
        }

        public String teddyBearCount()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//table[@class='table table-striped cart-items']/tbody/tr[1]/td[3]/input")));

            return driver.FindElement(By.XPath(".//table[@class='table table-striped cart-items']/tbody/tr[1]/td[3]/input")).GetAttribute("value");
        }
        public Boolean isFuffyBunnyExisted()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//table[@class='table table-striped cart-items']/tbody/tr[2]/td[1]")));

            return fluffyBunnyItem.Displayed;
        }

        public String fuffyBunnyCount()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//table[@class='table table-striped cart-items']/tbody/tr[2]/td[3]/input")));

          return  driver.FindElement(By.XPath(".//table[@class='table table-striped cart-items']/tbody/tr[2]/td[3]/input")).GetAttribute("value");
        }
    }
}
