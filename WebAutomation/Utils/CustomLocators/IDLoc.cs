using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WebAutomation.Objects
{
    public class IDLoc: By
    {
        public IDLoc(string _id)
        {
            FindElementMethod = (ISearchContext context) =>
            {
                IWebElement mockElement = context.FindElement(By.Id(_id));
                return mockElement;
            };

            FindElementsMethod = (ISearchContext context) =>
            {
                ReadOnlyCollection<IWebElement> mockElements = context.FindElements(By.Id(_id));
                return mockElements;
            };
        }
    }
}
