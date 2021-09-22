using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects.AFW_Objects
{
    public class ModalDialogs:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private IAlert alert = null;
        By _smallModalBtn = new TextLoc("Small modal");  //*[text()= 'Small modal']
        By _largeModalBtn = new TextLoc("Large modal");  //*[text()= 'Large modal']
        By _smallModCloseBtn = By.Id("closeSmallModal");
        By _largeModCloseBtn = By.Id("closeLargeModal");
        public ModalDialogs(IWebDriver driver, WebDriverWait wait, IAlert alert):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.alert = alert;
        }
        
        public void ClickOnSmallModal()
        {
            webElement(_smallModalBtn).Click();
            Thread.Sleep(500);
            webElement(_smallModCloseBtn).Click();
        }

        public void ClickOnLargeModal()
        {
            webElement(_largeModalBtn).Click();
            Thread.Sleep(500);
            webElement(_largeModCloseBtn).Click();
            
        }

    }
}
