using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects.ElementObjects
{
    public class DynamicProporties:MethodsCollection
    {
        IWebDriver driver;
        WebDriverWait wait;
        By _colourChangeBtn = By.Id("colorChange");
        By _enableAfterBtn = By.Id("enableAfter");
        By _visibleAfterBtn = By.Id("visibleAfter");

        public DynamicProporties(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ClickOnColourChangeBtn()
        {
            
            webElement(_colourChangeBtn).Click();
        }

        public void ClickOnEnableAfterBtn()
        {
            webElement(_enableAfterBtn).Click();
           
        }
        public void ClickVisibleAfterBtn()
        {
            webElement(_visibleAfterBtn).Click();
          
        }
    }
}
