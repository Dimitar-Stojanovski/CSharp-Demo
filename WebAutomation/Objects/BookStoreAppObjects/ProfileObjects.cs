using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.BookStoreAppObjects
{
    public class ProfileObjects:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By _linkTexts = new IDPath("notLoggin-label", "/a"); //*[@id = 'notLoggin-label']/a
        private string[] _linkTextTitles = { "login", "register" };



        public ProfileObjects(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ClickOnLinkTexts(string _links)
        {
            int index = Array.IndexOf(_linkTextTitles, _links);
            webElements(_linkTexts)[index].Click();
            
        }

    }
}
