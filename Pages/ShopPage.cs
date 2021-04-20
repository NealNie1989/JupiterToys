using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace JupiterToys.Pages
{
    class ShopPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//li[contains(@id, 'product-1')]/div/p/a")]
        private IWebElement teddyBearBuy;

        [FindsBy(How = How.XPath, Using = ".//li[contains(@id, 'product-2')]/div/p/a")]
        private IWebElement stuffedFrogBuy;

        [FindsBy(How = How.XPath, Using = ".//li[contains(@id, 'product-3')]/div/p/a")]
        private IWebElement handMadeDollBuy;

        [FindsBy(How = How.XPath, Using = ".//li[contains(@id, 'product-4')]/div/p/a")]
        private IWebElement fluffyBunnyBuy;

        [FindsBy(How = How.XPath, Using = ".//li[contains(@id, 'product-5')]/div/p/a")]
        private IWebElement smileyBearBuy;

        [FindsBy(How = How.XPath, Using = ".//li[contains(@id, 'product-6')]/div/p/a")]
        private IWebElement funnyCowBuy;

        [FindsBy(How = How.XPath, Using = ".//li[contains(@id, 'product-7')]/div/p/a")]
        private IWebElement valentineBearBuy;

        [FindsBy(How = How.XPath, Using = ".//li[contains(@id, 'product-8')]/div/p/a")]
        private IWebElement smileyFaceBuy;

        public ShopPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            
        }
        public void buyTeddyBear(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                teddyBearBuy.Click();
            }
           
        }

        public void buyStuffedFrog(int count)
        {
            for (int i = 1; i <= count; i++) {
                stuffedFrogBuy.Click();
            }      
        }

        public void buyHandMadeDoll(int count)
        {
            handMadeDollBuy.Click();
        }

        public void buyFluffyBunny(int count)
        {
            for (int i = 1; i <= count; i++)
                fluffyBunnyBuy.Click();
        }

        public void buySmileyBear(int count)
        {
            for (int i = 1; i <= count; i++)
                smileyBearBuy.Click();
        }

        public void buyFunnyCow(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                funnyCowBuy.Click();
            }
                
        }

        public void buyValentineBear(int count)
        {
            for (int i = 1; i <= count; i++) {
                valentineBearBuy.Click();
            }
                
        }

        public void buySmileyFace(int count)
        {
            for (int i = 1; i <= count; i++) {
                smileyFaceBuy.Click();
            }      
        }

    }
}
