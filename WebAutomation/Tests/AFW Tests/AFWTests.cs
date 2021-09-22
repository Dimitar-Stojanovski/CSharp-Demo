using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils.DataProviders.DataForAFW;

namespace WebAutomation.Tests.AFW_Tests
{
    public class AFWTests: BaseTests
    {
        [TestCaseSource(typeof(DataForAWF), nameof(DataForAWF.AWFTabsData))]
        public void ClickOnAFWTabs(string title)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs(title);

        }
    }
}
