using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.ElementObjects
{
    public class BrokenLinks:MethodsCollection
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        
        
        By _imageTitles = new ContainsClassPath("col-md-6", "/div/p");  
        By _clickBrokenLink = new ContainsText("for Broken Link");
        By _clickValidLink = new ContainsText("for Valid Link");
        private string[] _titles = { "Valid image", "Broken image", "Valid Link", "Broken Link" };

        public BrokenLinks(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public string GetTitles(string titles)
        {
            int index = Array.IndexOf(_titles, titles);
            return wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_imageTitles))[index].Text;
        }

        public void ClickOnValidLink()
        {
           
            webElement(_clickValidLink).Click();
        }

        public void ClickOnBrokenLink()
        {
            
            webElement(_clickBrokenLink).Click();
        }

    }
}
