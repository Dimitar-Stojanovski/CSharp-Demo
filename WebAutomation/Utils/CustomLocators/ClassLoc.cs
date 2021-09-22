using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
//using DocumentFormat.OpenXml.InkML;

namespace WebAutomation.Objects
{
    public class ClassLoc:By
    {
        public ClassLoc(string _title)
        {
            FindElementMethod = (ISearchContext context) =>
            {
                IWebElement mockElement = context.FindElement(By.XPath("//*[@class ='" + _title + "']"));
                return mockElement;
                
                
            };

            FindElementsMethod = (ISearchContext context) =>
            {
                ReadOnlyCollection<IWebElement> mockElements = context.FindElements(By.XPath("//*[@class ='" + _title + "']"));
                return mockElements;
            
            };



           

           
        }
    }
}
