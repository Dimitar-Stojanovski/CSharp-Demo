using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils;

namespace WebAutomation.Tests.WidgetTests
{
    public class ToolTipsTests: BaseTests
    {
        [Test]
        public void HooverOverElementsAndVerifyText()
        {
           
                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Widgets");
                javaScriptExec.ScrollBy300();
                widgetMenu.WidgetMenuTabs("Tool Tips");
                toolTip.HooverAndClickOnHVMSBtn();
                toolTip.HooverOverPlaceHolder();
                toolTip.EnterTextInHooverPlaceHolder("This is a sample text");
                toolTip.ClearTextInHooverPlaceHolder();
                toolTip.HooverOverContraryWord();







        }
    }
}
