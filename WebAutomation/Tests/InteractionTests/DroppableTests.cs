using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForInteraction;

namespace WebAutomation.Tests.InteractionTests
{
    public class DroppableTests:BaseTests
    {
        [TestCaseSource(typeof(DataForDroppable), nameof(DataForDroppable.TestDataForDroppable))]
        public void ClickOnDroppableNavTabs(string _titles)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            javaScriptExec.ScrollBy300();
            interactionMenuItems.ClickOnInteractionTabs("Droppable");
            javaScriptExec.ScrollBy300();
            droppable.ClickOnDroppableNavTab(_titles);
            Thread.Sleep(2000);
        }

        [Test]
        public void PerformDragAndDrop()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            javaScriptExec.ScrollBy300();
            interactionMenuItems.ClickOnInteractionTabs("Droppable");
            droppable.PerformDragAndDrop();
            Assert.AreEqual(droppable.GetMessageAfterDragAndDrop(), "Dropped!");
            Thread.Sleep(2000);
        }

        [Test]
        public void PerformDragAndDropInAccept()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            javaScriptExec.ScrollBy300();
            interactionMenuItems.ClickOnInteractionTabs("Droppable");
            droppable.ClickOnDroppableNavTab("Accept");
            droppable.DragAndDropWithAcceptable();
            Assert.AreEqual(droppable.GetMessageAfterDragAndDrop(), "Dropped!");
            Thread.Sleep(2000);
        }


        [Test]
        public void PerformDragAndDropInNotGreedyDropBox()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            javaScriptExec.ScrollBy300();
            interactionMenuItems.ClickOnInteractionTabs("Droppable");
            droppable.ClickOnDroppableNavTab("Prevent Propogation");
            droppable.DragAndDropToNotGreedy();
            Assert.AreEqual(droppable.GetTextFromNotGreedyDropBx(), "Dropped!");
            droppable.DragAndDropToInnerDropBxNotGreedy();
            Thread.Sleep(2000);
        }
    }
}
