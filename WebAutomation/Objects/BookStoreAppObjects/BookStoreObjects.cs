using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;
using WebAutomation.Utils.DataProviders.DataForBookStore;

namespace WebAutomation.Objects.BookStoreAppObjects
{
    public class BookStoreObjects:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private SelectElement select;
        By _searchBox = new ClassPath("form-control", "/..");                           
        By _searchBtn = By.Id("basic-addon2");
        By _logInBtn = new ClassLoc("btn btn-primary");                                
        By _bookObjects = new ClassLoc("mr-2");                                        
        By _pagePlaceHolder = By.XPath("//*[@type= 'number']/..");
        By _dropDownPlaceHolder = new ContainsClassPath("select-wrap", "/select");      
        By _backToBookStoreBtn = new IDPath("addNewRecordButton", "/..");               
        By _searchBoxInput = new ContainsClassPath("input", "/input");
        private string[] _bookTitles = { "Git Pocket Guide", "Learning JavaScript Design Patterns", "Designing Evolvable Web APIs with ASP.NET",
        "Speaking JavaScript", "You Don't Know JS", "Programming JavaScript Applications", "Eloquent JavaScript, Second Edition", "Understanding ECMAScript 6"};
        private string[] _rowsTitles = { "5 rows", "10 rows", "20 rows", "25 rows", "50 rows", "100 rows" };

        public BookStoreObjects(IWebDriver driver, WebDriverWait wait, SelectElement select):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.select = select;
        }

        public void ClickOnSearchBox()
        {
            webElement(_searchBox).Click();
            
        }

        public void ClickOnSearchBtn()
        {
            webElement(_searchBtn).Click();
           
        }

        public void ClickOnLoginBtn()
        {
            webElement(_logInBtn).Click();
            
        }

        public void ClickOnPagePlaceholder()
        {
            webElement(_pagePlaceHolder).Click();
            
        }

        public void ClickOnPageDropdown()
        {
            webElement(_dropDownPlaceHolder).Click();
            
        }

        public void ClickOnBookLists(string _lists)
        {
            int index = Array.IndexOf(_bookTitles, _lists);
            webElements(_bookObjects)[index].Click();
           
        }

        public void ClickOnBackToBookStoreBtn()
        {
            webElement(_backToBookStoreBtn).Click();
           
        }

        public void EnterTitleOnSearchBox(string _titles)
        {
            webElement(_searchBoxInput).SendKeys(_titles);
            
        }  
            
        public void ClickOnFirstRowInBookTable(int index)
        {
            webElements(_bookObjects)[index].Click();
           
        }

        public void PopulateDropdown(string _titles)
        {
            int index = Array.IndexOf(_rowsTitles, _titles);
            select = new SelectElement(webElement(_dropDownPlaceHolder));
            select.SelectByIndex(index);
        }

        public string GetResultFromPlaceHolder()
        {
            return GetTextFromElement(_dropDownPlaceHolder);
        }

        public string GetTextFromSearchBar()
        {

            return GetTextFromElement(_searchBoxInput);
        }
    }
}
