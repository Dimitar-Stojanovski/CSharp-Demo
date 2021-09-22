using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.WidgetObjects
{
    public class WidgetsMenuItems:MethodsCollection
    {
        IWebDriver driver;
        WebDriverWait wait;
        By _widgetMenuTabs = new TextPath("Accordian", "/../../li");  
        string[] _widgetTitles = { "Accordian", "Auto Complete", "Date Picker", "Slider", "Progress Bar", "Tabs", "Tool Tips", "Menu", "Select Menu" };

        public WidgetsMenuItems(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

       public void WidgetMenuTabs(string tabs)
        {
            int index = Array.IndexOf(_widgetTitles, tabs);
            webElements(_widgetMenuTabs)[index].Click();
        }
    }
}
