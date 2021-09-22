using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects
{
    public class ElementsMenuTabs:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By elementTabs = new ContainsClassPath("element-list collapse show", "/ul/li"); 
        string[] tabsSelector = { "Text Box", "Check Box", "Radio Button", "Web Tables", "Buttons",
                "Links", "Broken Links- Images", "Upload and Download", "Dynamic Properties" };

        public ElementsMenuTabs(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;

        }

         public void ListElementTabs(string tabs)
        {
             int index = Array.IndexOf(tabsSelector, tabs);
             webElements(elementTabs)[index].Click();
           

        }
    }
}
