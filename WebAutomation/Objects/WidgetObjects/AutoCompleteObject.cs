using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects.WidgetObjects
{
    public class AutoCompleteObject:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action;
        By _multiColourInput = new ContainsID("MultipleInput");
        By _singleColourInput = new ContainsID("SingleInput");
        private string[] colours = { "Green", "Blue", "Yellow" };
        public AutoCompleteObject(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
        }

        public void PopulateMultiColourInput(string _input)
        {
            webElement(_multiColourInput).SendKeys(_input);
            Thread.Sleep(500);
            webElement(_multiColourInput).SendKeys(Keys.Enter);
           
            
        }

        public void PopulateSingleColourInput(string _input)
        {
            webElement(_singleColourInput).SendKeys(_input);
            Thread.Sleep(500);
            webElement(_singleColourInput).SendKeys(Keys.Enter);
           

        }

        public void PopulateMultiColourWithDataFromArray()
        {
            int i = 0;
            do
            {
                
                webElement(_multiColourInput).SendKeys(colours[i]);
                Thread.Sleep(500);
                webElement(_multiColourInput).SendKeys(Keys.Enter);
                i++;

            } while (i < colours.Length);
        }
    }
}
