using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.WidgetObjects
{
    public class ProgressBarObject:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By _startStopBtn = By.Id("startStopButton");
        By _progressBarFinish = By.XPath("//*[@class = 'progress-bar bg-success']");
        By _progressBarValue = new IDPath("progressBar", "/div"); ////*[@id="progressBar"]/div
        By _resetBtn = By.Id("resetButton");
        public ProgressBarObject(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ClickOnStartBtn()
        {
            webElement(_startStopBtn).Click();
            
        }
        
       public bool VerifyProgressBarFinish()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(_progressBarFinish)).Displayed;
        }

        public string GetPecrentFromProgressBar()
        {
            return GetTextFromElement(_progressBarValue);
        }

       public void ClickOnResetBtn()
        {
            webElement(_resetBtn).Click();
        }

        
    }
}
