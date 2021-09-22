using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.BookStoreAppObjects
{
    public class LoginObjects:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;
        By _newUserBtn = new ContainsText("New User");
        By _logInBtn = By.Id("login");
        By _registerBtn = new ClassLoc("text-center button");
        By _backToLoginBtn = By.Id("gotologin");
        By _userName = By.Id("userName");
        By _password = By.Id("password");
        By _invalidUserNameAndPassPar = new ContainsText("username or password");
        By _firstName = By.Id("firstname");
        By _lastName = By.Id("lastname");
        By _rechaptchaBtn = new IDPath("recaptcha-anchor", "/..");  //*[@id = 'recaptcha-anchor']/.."
        By _iframeRecapcha = new IDPath("g - recaptcha", "/div/div/iframe"); //*[@id='g - recaptcha']/div/div/iframe
        By _returnMessage = By.Id("name");
        public LoginObjects(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
        }

        public void ClickOnLogInBtn()
        {
            webElement(_logInBtn).Click();
           
        }

        public void ClickOnNewUserBtn()
        {
            webElement(_newUserBtn).Click();
            
        }

        public void ClickOnRegisterBtn()
        {
            //webElement(_registerBtn).Click();
            action.MoveToElement(webElement(_registerBtn)).Click().Build().Perform();
            
        }

        public void ClickOnBackToLogInBtn()
        {
            webElement(_backToLoginBtn).Click();
            
        }
        public void EnterUserName(string _text)
        {
            webElement(_userName).SendKeys(_text);
            
        }

        public void EnterPassword(string _text)
        {
            webElement(_password).SendKeys(_text);
           
        }
        public string GetResponseMessage()
        {
            return GetTextFromElement(_invalidUserNameAndPassPar);
        }

        public void EnterName(string _name)
        {
            webElement(_firstName).SendKeys(_name);
           
        }

        public void EnterLastName(string _lastName)
        {
            webElement(this._lastName).SendKeys(_lastName);
            
        }
        public void ClickOnRecapthcha()
        {
            webElement(_rechaptchaBtn).Click();
           
        }
        public void SwitchToRecaptchaIframe()
        {

            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(_iframeRecapcha));
        }

        public void SwitchToDefaultContent()
        {
            driver.SwitchTo().DefaultContent();
        }

        public string GetTextAfterRegistering()
        {
            return GetTextFromElement(_returnMessage);
        }
    }
}
