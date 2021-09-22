using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace WebAutomation.Objects.CustomLocators
{
    public class ContainsText:By
    {
        public ContainsText(string _value)
        {
            FindElementMethod = (ISearchContext context) =>
            {
                IWebElement mockElement = context.FindElement(By.XPath("//*[contains(text(),'" + _value + "')]"));
                return mockElement;
            };

            FindElementsMethod = (ISearchContext context) =>
            {
                ReadOnlyCollection<IWebElement> mockElements = context.FindElements(By.XPath("//*[contains(text(),'" + _value + "')]"));
                return (ReadOnlyCollection<IWebElement>)(IWebElement)mockElements;
            };
        }
    }
}
