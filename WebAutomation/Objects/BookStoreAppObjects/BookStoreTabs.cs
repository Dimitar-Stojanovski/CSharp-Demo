
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.BookStoreAppObjects
{
    public class BookStoreTabs:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By _bookStoreTabs = new TextPath("Login", "/../../li");  
        By _bookStoreHeader = new TextLoc("Book Store Application");
        private string[] _titles = { "Login", "Book Store", "Profile", "Book Store API" };

        public BookStoreTabs(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        public void ClickOnBookStoreMenuHeader()
        {
            webElement(_bookStoreHeader).Click();
           
        }
        public void ListMenuTabs(string titles)
        {
            int index = Array.IndexOf(_titles, titles);
            webElements(_bookStoreTabs)[index].Click();
            
        }
    }
}
