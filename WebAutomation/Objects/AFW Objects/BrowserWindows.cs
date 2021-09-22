using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.AFW_Objects
{
    public class BrowserWindows:MethodsCollection
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private Actions action;
        By _newTabBtn = new IDPath("tabButtonWrapper", "/button");    
        By _newWindowBtn = new IDPath("windowButtonWrapper", "/button");  
        By _newWindowMessBtn = new IDPath("msgWindowButtonWrapper", "/button");
        By _headerResult = By.Id("sampleHeading");
        By _mainHeader = new ClassLoc("main-header");
        

        public BrowserWindows(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
        }

        public void ClickOnNewTabBtn()
        {
            webElement(_newTabBtn).Click();
            
        }

        public void ClickOnNewWindowBtn()
        {
            webElement(_newWindowBtn).Click();
            
        }

        public void ClickOnNewWindowMessBtn()
        {
            webElement(_newWindowMessBtn).Click();
           
        }

        public void NavigateToTab(ArrayList tabs, int index)
        {
            /*ArrayList tabs = new ArrayList(driver.WindowHandles);*/
            driver.SwitchTo().Window((string)tabs[index]);
            
        }

        public string ReturnHeading()
        {
            return GetTextFromElement(_headerResult);
        }

        public ArrayList GetAllTabs()
        {
            return new ArrayList(driver.WindowHandles);
        }

        public int CountWindowHandles()
        {
            return driver.WindowHandles.Count;
        }

        public string GetCurrentTab()
        {
            return driver.CurrentWindowHandle;
        }

        public void SwitchToBasicUrl(string _url)
        {
            driver.SwitchTo().Window(_url);
        }

        public string GetTextFromMainHeader()
        {
            return GetTextFromElement(_mainHeader);
        }
    }
}
