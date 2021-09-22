using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForElements;

namespace WebAutomation.Tests.ElementTests
{
    public class ElementsTabTests:BaseTests
    {
        [TestCaseSource(typeof(DataForElementsTabs), nameof(DataForElementsTabs.ElmenentsTabData))]
        public void ListAllElementsTabs(string tabs)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            javaScriptExec.ScrollBy500();
            elementsMenuTabs.ListElementTabs(tabs);
            Thread.Sleep(1000);

        }
    }
}
