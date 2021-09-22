using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.InteractionObjects
{
    public class InteractionMenuItems:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;
        By _interactionTabs = new TextPath("Sortable", "/../../li");  
        private string[] _tabsTitles = { "Sortable", "Selectable", "Resizable", "Droppable", "Dragabble" };

        public InteractionMenuItems(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
        }

        public void ClickOnInteractionTabs(string tabs)
        {
           int index = Array.IndexOf(_tabsTitles, tabs);
           webElements(_interactionTabs)[index].Click();
           
          
        }
    }
}
