using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Tests.ElementTests
{
    public class DynamicPropertiesTests:BaseTests
    {
        [Test]
        public void ClickOnDynamicButtons()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            javaScriptExec.ScrollBy300();
            elementsMenuTabs.ListElementTabs("Dynamic Properties");
            dynamicProporties.ClickOnColourChangeBtn();
            dynamicProporties.ClickOnEnableAfterBtn();
            dynamicProporties.ClickVisibleAfterBtn();
        }
    }
}
