using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace JupiterToys.Pages
{
    class ContactPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "[id$='forename']")]
        private IWebElement foreName;

        [FindsBy(How = How.CssSelector, Using = "[id$='surname']")]
        private IWebElement surName;

        [FindsBy(How = How.CssSelector, Using = "[id$='email']")]
        private IWebElement email;

        [FindsBy(How = How.CssSelector, Using = "[id$='telephone']")]
        private IWebElement telephone;

        [FindsBy(How = How.CssSelector, Using = "textarea[id$='message']")]
        private IWebElement message;

        [FindsBy(How = How.XPath, Using = ".//a[contains(text(),'Submit')]")]
        private IWebElement submitButton;

        [FindsBy(How = How.CssSelector, Using = "div[class='alert alert-error ng-scope']")]
        private IWebElement errorMessage;

        [FindsBy(How = How.CssSelector, Using = "div[class='alert alert-info ng-scope']")]
        private IWebElement infoMessage;

        [FindsBy(How = How.CssSelector, Using = "div[class='alert alert-success']")]
        private IWebElement successMessage;
        
        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public void fillForeName(String foreNames)
        {
            foreName.SendKeys(foreNames);
        }

        public void fillsurName(String surNames)
        {
            surName.SendKeys(surNames);
        }

        public void fillTelephone(String phoneNumber)
        {
            telephone.SendKeys(phoneNumber);
        }

        public void fillEmail(String emailAddress)
        {
            email.SendKeys(emailAddress);
        }

        public void fillMessage(String messages)
        {
            message.SendKeys(messages);
        }

        public void clickSubmit()
        {
            submitButton.Click();
        }

        public Boolean verifyErrorMessageIsDisplayed(){

            return errorMessage.Displayed;
        }

        public Boolean verifyInfoMessageIsDisplayed()
        {

            return infoMessage.Displayed;
        }

        public Boolean verifySuccessMessageIsDisplayed()
        {

            return successMessage.Displayed;
        }
    }
}
