using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects
{
    public class RadioButtons:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By RadioButtonQuestion = new ContainsText("Do you like the site?");
        By RadioButtonsLoc = new ContainsClass("custom-radio"); 
        By RadioMessage = By.XPath("//*[@class = 'mt-3']");
        private string[] radioBtnTitles = { "Yes", "Impressive", "No" };
        public RadioButtons(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;

        }

        public string GetQuestion()
        {
            return GetTextFromElement(RadioButtonQuestion);

        }

        public void ClickRadioButton(string buttonIndex)
        {
            
            int index = Array.IndexOf(radioBtnTitles, buttonIndex);
            webElements(RadioButtonsLoc)[index].Click();
            

        }

        public string GetRadioMessage()
        {
             return GetTextFromElement(RadioMessage);
           
        }
    }
}
