using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.WidgetObjects
{
    public class SelectMenuObjects:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private SelectElement select = null;
        private Actions action = null;
        By _selectValueDropDown = By.Id("withOptGroup");
        By _selectOneDropDown = By.XPath("//*[@id = 'selectOne']");
        By _oldStyleSelectMenu = By.Id("oldSelectMenu");
        By _multiSelectDropDwon = new TextPath("Select", "/../../..");
        By _standartMultiSelect = By.Id("cars");
        By _populateSelectValueDrop = new IDPath("react-select-2-input", "/../input");
        By _populateSelectOneValueDropDown = new IDPath("react-select-3-input", "/../input");
        By _populateOldStyleDrop = By.Id("oldSelectMenu");
        By _populateMultiSelectDrop = new IDPath("react-select-4-input", "/../input");
        By _populateStandartMultiSelectDrop = By.Id("cars");                  
        private string[] _multiSelectDropColours = { "Green", "Blue", "Black", "Red" };
        private string[] _odlstyleCarsValues = { "volvo", "saab", "opel", "audi" };
        private string[] _oldStyleColours = { "Red", "Blue", "Green", "Yellow", "Purple", "Black", "White", "Voilet", "Indigo", "Magenta", "Aqua" };
        //By _populateOldStyleDrop = new IDPath("oldSelectMenu", "/option");
        //private string[] _oldStyleDropColours = { "Red", "Blue", "Green" }

        public SelectMenuObjects(IWebDriver driver, WebDriverWait wait, SelectElement select, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.select = select;
            this.action = action;
        }

        public void ClickOnValueDropDown()
        {
            action.MoveToElement(webElement(_selectValueDropDown)).DoubleClick().Perform();
            
        }

        public void ClickOnOneDropDown()
        {
            
            action.MoveToElement(webElement(_selectOneDropDown)).DoubleClick().Perform();
            
        }

        public void ClickOnOldStyleDropDown()
        {
            
            action.MoveToElement(webElement(_oldStyleSelectMenu)).DoubleClick().Perform();
        }

        public void ClickOnMultySelectDropDown()
        {
            action.MoveToElement(webElement(_multiSelectDropDwon)).DoubleClick().Perform();
           
        }

        public void ClickOnOldStyleMultySelectDropDown()
        {
            action.MoveToElement(webElement(_standartMultiSelect)).DoubleClick().Perform();
        }

        public void PopulateSelectValueDropDown(string value)
        {
            webElement(_populateSelectValueDrop).SendKeys(value);
            Thread.Sleep(500);
            webElement(_populateSelectValueDrop).SendKeys(Keys.Enter);

        }

        public void PopulateSelectOneValueDropDown(string _value)
        {
            webElement(_populateSelectOneValueDropDown).SendKeys(_value);
            Thread.Sleep(500);
            webElement(_populateSelectOneValueDropDown).SendKeys(Keys.Enter);

        }

        public void PopulateOldStyleDropDownValues(string values)
        {
            select = new SelectElement(webElement(_populateOldStyleDrop)); 
            select.SelectByText(values);
        }

        public void PopulateOldStyleDropDownWithIndex(string _colourTitles)
        {
            int index = Array.IndexOf(_oldStyleColours, _colourTitles);
            select = new SelectElement(webElement(_populateOldStyleDrop));
            select.SelectByIndex(index);
        }

        public void PopulateMultiSelectDropDown()
        {
            int i = 0;
            do
            {
                webElement(_populateMultiSelectDrop).SendKeys(_multiSelectDropColours[i]);
                Thread.Sleep(500);
                webElement(_populateMultiSelectDrop).SendKeys(Keys.Enter);
                i++;
            } while (i < _multiSelectDropColours.Length);
        }

       public void PopulateStandartMultiSelectDropdown(string _value)
        {
            select = new SelectElement(webElement(_populateStandartMultiSelectDrop)); 
            select.SelectByValue(_value);
        }

        public void ClearMultSelectDropDownValues()
        {
            webElement(_populateMultiSelectDrop).SendKeys(Keys.Backspace);
        }
    }
}
