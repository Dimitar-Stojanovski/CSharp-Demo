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
    public class SelectableObject:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By _navTabs = new ClassPath("nav nav-tabs", "/a");  
        By _listElements = new IDPath("verticalListContainer", "/li");  
        By _row1 = new IDPath("row1", "/li");  
        By _row2 = new IDPath("row2", "/li"); 
        By _row3 = new IDPath("row3", "/li"); 
        private string[] _navTitles = { "List", "Grid" };
        private string[] _listTitles = { "Cras justo odio", "Dapibus ac facilisis in", "Morbi leo risus", "Porta ac consectetur ac" };
        private string[] _row1Titles = { "One", "Two", "Three" };
        private string[] _row2Titles = { "Four", "Five", "Six" };
        private string[] _row3Titles = { "Seven", "Eight", "Nine" };


        public SelectableObject(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ClickOnNavTabs(string title)
        {
            int index = Array.IndexOf(_navTitles, title);
            webElements(_navTabs)[index].Click();
            
            
        }

        public void ClickOnListTitles(string titles)
        {
            int index = Array.IndexOf(_listTitles, titles);
            webElements(_listElements)[index].Click();
           
           
        }

        public void ClickOnGridTitlesRow1(string titles)
        {
            int index = Array.IndexOf(_row1Titles, titles);
            webElements(_row1)[index].Click();
           
            
        }

        public void ClickOnGridTitlesRow2(string titles)
        {
            int index = Array.IndexOf(_row2Titles, titles);
            webElements(_row2)[index].Click();
            
           
        }

        public void ClickOnGridTitlesRow3(string titles)
        {
            int index = Array.IndexOf(_row3Titles, titles);
            webElements(_row3)[index].Click();
            
            
        }
    }
}
