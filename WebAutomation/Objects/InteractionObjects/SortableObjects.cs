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
    public class SortableObjects:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;

        By _navTabs = new ClassPath("nav nav-tabs", "/a"); 
        By _verticalListContainer = new ContainsClassPath("list-container", "/div"); 
        By _gridContainer = new ClassPath("create-grid", "/div"); 
        private string[] _navTabsTitles = { "List", "Grid" };
        private string[] _containerTitles = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        public SortableObjects(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }


        public void ClickOnNavTabs(string titles)
        {
            int index = Array.IndexOf(_navTabsTitles, titles);
            webElements(_navTabs)[index].Click();
           
            
        }

        public void ClickOnListTitles(string titles)
        {
            int index = Array.IndexOf(_containerTitles, titles);
            webElements(_verticalListContainer)[index].Click();
           
            
        }

        public void ClickOnGridTitles(string titles)
        {
            int index = Array.IndexOf(_containerTitles, titles);
            webElements(_gridContainer)[index].Click();
           
            
        }
    }
}
