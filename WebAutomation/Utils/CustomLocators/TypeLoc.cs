using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WebAutomation.Objects
{
    public class TypeLoc:By
    {
        public TypeLoc(string _value)
        {
            FindElementMethod = (ISearchContext context) =>
            {
                IWebElement mockElement = context.FindElement(By.XPath("//*[@type ='" + _value + "']"));
                return mockElement;
            };

            FindElementsMethod = (ISearchContext context) =>
            {
                ReadOnlyCollection<IWebElement> mockElements = context.FindElements(By.XPath("//*[@type ='" + _value + "']"));
                return mockElements;
            };
        }
    }
}
