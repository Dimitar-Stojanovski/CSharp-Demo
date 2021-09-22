using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WebAutomation.Objects.CustomLocators
{
    public class ContainsID:By
    {
        public ContainsID(string _value)
        {
            FindElementMethod = (ISearchContext context) =>
            {
                IWebElement mockElement = context.FindElement(By.XPath("//*[contains(@id,'" + _value + "')]"));
                return mockElement;
            };

            FindElementsMethod = (ISearchContext context) =>
            {
                ReadOnlyCollection<IWebElement> mockElements = context.FindElements(By.XPath("//*[contains(@id,'" + _value + "')]"));
                return mockElements;
            };
        }
    }
}
