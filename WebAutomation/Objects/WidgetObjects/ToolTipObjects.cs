using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects.WidgetObjects
{
    public class ToolTipObjects:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null; 
        By _hooverMeToSeeBtn = By.Id("toolTipButton");
        By _hooverMeToSeeContainer = By.Id("texFieldToolTopContainer");
        By _contraryWord = new TextLoc("Contrary");
        By _hooverPlaceholder = new TypeLoc("text");

        public ToolTipObjects(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
        }

        public void HooverAndClickOnHVMSBtn()
        {
            action.MoveToElement(webElement(_hooverMeToSeeBtn)).Perform(); 
        }

        public void HooverOverPlaceHolder()
        {
            action.MoveToElement(webElement(_hooverMeToSeeContainer)).Perform(); 
        }

        public void HooverOverContraryWord()
        {
            action.MoveToElement(webElement(_contraryWord)).Perform();
        }

        public string GetTextFromHooverButton()
        {
            return GetTextFromElement(_hooverMeToSeeBtn); 
        }

        public string GetTextFromHooverPlaceHolder()
        {
            return GetTextFromElement(_hooverMeToSeeContainer);
        }

        public string GetTextFromContraryWord()
        {
            return GetTextFromElement(_contraryWord);
        }

        public void EnterTextInHooverPlaceHolder(string _text)
        {
            webElement(_hooverPlaceholder).SendKeys(_text);
            
         }

        public void ClearTextInHooverPlaceHolder()
        {
             webElement(_hooverPlaceholder).Clear();
        }
    }
}
