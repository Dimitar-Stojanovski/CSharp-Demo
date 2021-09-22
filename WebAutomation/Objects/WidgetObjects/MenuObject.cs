using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.WidgetObjects
{
    public class MenuObject:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;
        By _menuItems = new ContainsClassPath("menu-container", "/ul/li ");          
        By _mainItems2properties = new TextPath("Main Item 2", "/../ul/li");
        By _subListProperties = new TextPath("SUB SUB LIST »", "/../ul/li");
        By _mainItem2 = new TextLoc("Main Item 2"); 
        private string[] _menuTitles = { "Main Item 1", "Main Item 2", "Main Item 3" };
        private string[] _mainItem2Titles = { "Sub Item", "Sub Item", "SUB SUB LIST »" };
        private string[] _sublistTitles = { "Sub Sub Item 1", "Sub Sub Item 2" };

        public MenuObject(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
        }

        public void ClickOnMenuItems(string titles)
        {
            int index = Array.IndexOf(_menuTitles, titles);
            action.MoveToElement(webElements(_menuItems)[index]).Click().Perform();
            
        }

        public void ClicOnMenuItems2List(string titles)
        {
           
            int index = Array.IndexOf(_mainItem2Titles, titles);
            action.MoveToElement(webElements(_mainItems2properties)[index]).Click().Perform();
        }

        public void ClickOnSubListProperties(string titles)
        {
            int index = Array.IndexOf(_sublistTitles, titles);
            action.MoveToElement(webElements(_subListProperties)[index]).Click().Perform();
        }
    }
}
