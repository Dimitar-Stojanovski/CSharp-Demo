using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects.WidgetObjects
{
    public class WidgetTabs:MethodsCollection
    {
        IWebDriver driver;
        WebDriverWait wait;
        By _tabElements = By.XPath("//*[contains(@class, 'nav nav-tabs')]/a");
        private string[] _elementTabs = { "What", "Origin", "Use" };

        public WidgetTabs(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        

        public void ClickOnLoremIpsumElements(string elements)
        {
            int index = Array.IndexOf(_elementTabs, elements);
            webElements(_tabElements)[index].Click();
            
        }
    }
}
