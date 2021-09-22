using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.InteractionObjects
{
    public class DraggableObjects:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By _navTabs = new ClassPath("nav nav-tabs", "/a"); 
        private string[] _navTitles = { "Simple", "Axis Restricted", "Container Restricted", "Cursor Style" };

        public DraggableObjects(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ClickOnNavTabs(string _titles)
        {
            int index = Array.IndexOf(_navTitles, _titles);
            webElements(_navTabs)[index].Click();
           
            
        }
    }
}
