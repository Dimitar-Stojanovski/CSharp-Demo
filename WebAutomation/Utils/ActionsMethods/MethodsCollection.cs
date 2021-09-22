
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils
{
    public class MethodsCollection
    {
        public IWebDriver driver = null;
        public WebDriverWait wait = null;

        public MethodsCollection(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public IWebElement webElement(By _locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(_locator));
        }

        public IList<IWebElement> webElements(By _locator)
        {
            return wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_locator));
        }

        public string GetTextFromElement(By _locator)
        {
            return wait.Until(ExpectedConditions.ElementExists(_locator)).Text;
        }

        public void  switchToFrame(By _locator)
        {
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(_locator));
        }

       

       
    }
}
