using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils.DataProviders.DataForInteraction;

namespace WebAutomation.Tests.InteractionTests
{
    public class InteractionMenuTabTest: BaseTests
    {
        [TestCaseSource(typeof(InteractionTabsData), nameof(InteractionTabsData.DataForTabs))]
        public void ClickOnMenuItems(string tabs)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            javaScriptExec.ScrollBy500();
            interactionMenuItems.ClickOnInteractionTabs(tabs);
        }


    }
}
