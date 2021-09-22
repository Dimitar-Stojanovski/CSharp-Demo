using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForInteraction;

namespace WebAutomation.Tests.InteractionTests
{
    public class SortableTests:BaseTests
    {
        [Test]
        public void ClickOnNavTabs()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            interactionMenuItems.ClickOnInteractionTabs("Sortable");
            sortable.ClickOnNavTabs("List");
            sortable.ClickOnNavTabs("Grid");


        }
        
        [TestCaseSource(typeof(DataForSortable), nameof(DataForSortable.DataForList))]
        public void ClickOnListContainer(string _listItem)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            interactionMenuItems.ClickOnInteractionTabs("Sortable");
            sortable.ClickOnNavTabs("List");
            sortable.ClickOnListTitles(_listItem);


        }
        
        [TestCaseSource(typeof(DataForSortable), nameof(DataForSortable.DataForGrid))]
        public void ClickOnGridContainer(string _listItem)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            interactionMenuItems.ClickOnInteractionTabs("Sortable");
            sortable.ClickOnNavTabs("Grid");
            Thread.Sleep(1000);
            sortable.ClickOnGridTitles(_listItem);
            Thread.Sleep(1000);
        }
    }
}
