using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.WidgetObjects
{
    public class DatePicker:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;
        private SelectElement select = null;
        private IJavaScriptExecutor js = null;

        By _datePickerMonthInput = new IDPath("datePickerMonthYearInput", "/..");
        By _dateAndTimePickerInput = new IDPath("dateAndTimePickerInput", "/..");
        By _dateInputForDateMonth = new IDPath("datePickerMonthYear", "/div/div/input");
        By _dateHourMonthInput = new IDPath("datePickerMonthYear", "/div/div/input");
        By _monthSelect = new ContainsClass("month-select");
        By _yearSelect = new ContainsClass("year-select");
        By _daySelect = new ClassPath("react-datepicker__week", "/div");
        By _clickMonthFromReact = new ContainsClassPath("selected-month", "/..");
        By _selectMonthReact = new ClassPath("react-datepicker__month-dropdown", "/div");
        By _selectYearReact = new ClassPath("react-datepicker__year-dropdown", "/div");
        By _clickYearFromReact = new ContainsClassPath("selected-year", "/..");
        By _selectTime = new ContainsClassPath("time-list", "/li");
        private string[] _monthsTitles = { "January", "February", "March", "April", "May", "June", "July", "August", 
        "September", "October", "November", "December" };
        private string[] _timeTitles = { "00:00", "00:15", "15:15", "15:45", "18:45" };
       
        public DatePicker(IWebDriver driver, WebDriverWait wait, Actions action, SelectElement select, IJavaScriptExecutor js):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
            this.select = select;
            this.js = js;
        }

        public void ClickOnDatePickerInput()
        {
             webElement(_datePickerMonthInput).Click();
            
            
        }

        public void ClickOnDateAndTimePicInput()
        {
            webElement(_dateAndTimePickerInput).Click();
           
           
        }

        public void SendDateMonthYearInput(string date)
        {
            webElement(_dateInputForDateMonth).SendKeys(date);
            Thread.Sleep(1000);
            action.SendKeys(Keys.Enter);
        }

        public void SendDateTimeAndHourInput(string date)
        {
            webElement(_dateHourMonthInput).SendKeys(date);
            Thread.Sleep(1000);
            action.SendKeys(Keys.Enter);
        }

        public void SelectMonth(string _month)
        {
            select = new SelectElement(webElement(_monthSelect)); 
            select.SelectByText(_month);
        }

        public void SelectYear(int _year)
        {
            select = new SelectElement(webElement(_yearSelect));
            select.SelectByText(""+_year);
        }

        public void SelectDay(int index)
        {
            webElements(_daySelect)[index].Click();
            
        }

        public void SelectMonthFromCombo(string _titles)
        {
            webElement(_clickMonthFromReact).Click();
            Thread.Sleep(500);
            int index = Array.IndexOf(_monthsTitles, _titles);
            webElements(_selectMonthReact)[index].Click();
           
        }

        public void SelectYearFromCombo(int _year)
        {
            webElement(_clickYearFromReact).Click();
            Thread.Sleep(500);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'react-datepicker__year-option'][text() =" + _year + "]"))).Click();
            
        }

        public void SelectTimeFromCombo(string titels)
        {
            int index = Array.IndexOf(_timeTitles, titels);
            webElements(_selectTime)[index].Click();
        }

    }
}
