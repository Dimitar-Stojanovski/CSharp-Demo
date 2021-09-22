using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForInteraction;

namespace WebAutomation.Tests.InteractionTests
{
    public class DraggableTests:BaseTests
    {
        [TestCaseSource(typeof(DataForDraggable), nameof(DataForDraggable.TestDataForDraggable))]
        public void ClickOnDraggableTabs(string _tabs)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            javaScriptExec.ScrollBy300();
            interactionMenuItems.ClickOnInteractionTabs("Dragabble");
            draggable.ClickOnNavTabs(_tabs);
            Thread.Sleep(2000);
        }
    }
}
