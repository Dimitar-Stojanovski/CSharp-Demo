using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects
{
    
    public class CheckBox:MethodsCollection
    {

        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;

        By HomeCheckBox = new ClassLoc("rct-checkbox"); //*[@class=\"rct-checkbox\"]
        By HomeCheckBoxMessage = By.XPath("//*[@id=\"result\"]");
        By DropDownButton = new TextPath("Home", "/../../button"); //*[text() = 'Home']/../../button
        By DropDownDesktop = new TextPath("Desktop", "/../../button"); //*[text() = 'Desktop']/../../button
        By DropDownDownloads = new TextPath("Downloads", "/../../button"); //*[text() = 'Downloads']/../../button
        By DropDownDocuments = new TextPath("Documents", "/../../button"); //*[text() = 'Documents']/../../button
        By ExpandAllButton = By.XPath("//*[@title='Expand all']");
        private string[] checkBoxTitles = { "Home", "Desktop", "Notes", "Commands", "Documents", "WorkSpace", "Office", "Downloads", "Word File.doc", "Excel File.doc" };
        public CheckBox(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {

            this.driver = driver;
            this.wait = wait;
            
            
            
        }

        

        public void ClickCheckBx(string titles)
        {
            int index = Array.IndexOf(checkBoxTitles, titles);
            webElements(HomeCheckBox)[index].Click();
        }

        public void ClickDropDown()
        {
           webElement(DropDownButton).Click();
         
        }

        public void ClickDropDownDesktop()
        {
           
            webElement(DropDownDesktop).Click();
        }

        public void ClickDropDownDownloads()
        {
            
            webElement(DropDownDownloads).Click();
        }

        public void ClickDropDownDocuments()
        {
           
            webElement(DropDownDocuments).Click();
        }

        public void ClickExpandAllButton()
        {
            webElement(ExpandAllButton).Click();
           
        }

       
    }
}
