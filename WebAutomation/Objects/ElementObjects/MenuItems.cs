using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects
{
    public class MenuItems:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By cardsLocaction = new ContainsClass("top-card");  //*[contains(@class, 'top-card')]"
        private string[] menuCards = { "Elements", "Forms", "Alerts, Frame & Windows", "Widgets", "Interactions", "Book Store Application" };

        public MenuItems(IWebDriver driver, WebDriverWait wait):base(driver,wait)
        {
            this.driver = driver;
            this.wait = wait;

        }

         public void ClickOnMenuCard(string cards) 
        {
             int index = Array.IndexOf(menuCards, cards);
             webElements(cardsLocaction)[index].Click();
         
         }
    }
}
