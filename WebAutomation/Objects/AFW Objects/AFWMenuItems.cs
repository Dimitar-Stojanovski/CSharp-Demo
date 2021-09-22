using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.AFW_Objects
{
    public class AFWMenuItems:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;

        By _afwTabs = new ContainsTextPath("Browser Windows", "/../../li");     

        private string[] _afwTabsTitles = { "Browser Windows", "Alerts", "Frames", "Nested Frames", "Modal Dialogs" };

        public AFWMenuItems(IWebDriver driver, WebDriverWait wait):base(driver,wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ClickOnAFWTabs(string tabs)
        {
            int index = Array.IndexOf(_afwTabsTitles, tabs);
            webElements(_afwTabs)[index].Click();
            
        }
    }
}
