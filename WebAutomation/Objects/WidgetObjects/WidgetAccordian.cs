using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects.WidgetObjects
{
    public class WidgetAccordian:MethodsCollection
    {
        IWebDriver driver;
        WebDriverWait wait;
        By _whatIsLI = By.Id("section1Heading");
        By _whereComesFrom = By.Id("section2Heading");
        By _whereWeUseIt = By.Id("section3Heading");

        public WidgetAccordian(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

       
        public void ClickOnWhatLoremIps()
        {
             webElement(_whatIsLI).Click();
        }
        public void ClickOnWhereComesFrom()
        {
            webElement(_whereComesFrom).Click();
        }
        public void ClickOnWhereWeUseIt()
        {
             webElement(_whereWeUseIt).Click();
        }
    }
}
