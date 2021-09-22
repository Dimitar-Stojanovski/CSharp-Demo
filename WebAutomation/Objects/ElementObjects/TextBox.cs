using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects
{
    public class TextBox:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null ;
        By submitButton = By.Id("submit");
        By _fullName = new TypeLoc("text");
        By _email = new IDLoc("userEmail");
        By _currentAddress = new IDLoc("currentAddress");
        By _permanentAddress = new IDLoc("permanentAddress");
        By _firstName = new ContainsClass("mr-sm-2'");             //mr-sm-2 form-control
        By _outputElements = new ContainsClassPath("border", "/p");  //*[contains(@class, 'border')]/p
        private string[] _outputElementTitles = { "Name", "Email", "Current Address", "Permananet Address" };
        
       public TextBox(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.wait = wait;
            this.driver = driver;
            this.action = action;
            

        }
    

        public void EnterFullName(string name)
        {
            webElement(_fullName).SendKeys(name);
            //SendKeysAction.SendKeys(wait, _fullName, name);
        }

        public void EnterEmail(string Email)
        {
            webElement(_email).SendKeys(Email);
            //SendKeysAction.SendKeys(wait, _email, Email);
        }

        public void EnterCurrentAddress(string CurrentAddress)
        {
            webElement(_currentAddress).SendKeys(CurrentAddress);
            //SendKeysAction.SendKeys(wait, _currentAddress, CurrentAddress);
        }

        public void EnterPermanentAddress(string PermanentAddress)
        {
            webElement(_permanentAddress).SendKeys(PermanentAddress);
            //SendKeysAction.SendKeys(wait, _permanentAddress, PermanentAddress);
        }

        public void ClickSubmitButton()
        {
            webElement(submitButton).Click();
            //ClickAction.Click(wait, submitButton);
        }


        public string GetBasicInfoTitles(string titles)
        {
            int index = Array.IndexOf(_outputElementTitles, titles);
            return wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_outputElements))[index].Text;
            
        }

        public void ClearName()
        {
            webElement(_fullName).Clear();
            
        }
       
        public void ClearEmail()
        {
            webElement(_email).Clear();
            
        }

        public void ClearCurrentAddress()
        {
            webElement(_currentAddress).Clear();
            
        }

        public void ClearPermanentAddress()
        {
            webElement(_permanentAddress).Clear();
            
        }

    }
}
