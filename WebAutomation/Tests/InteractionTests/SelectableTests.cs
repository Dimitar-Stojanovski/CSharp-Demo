using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForInteraction;

namespace WebAutomation.Tests.InteractionTests
{
    public class SelectableTests:BaseTests
    {
        [Test]
        public void ClickOnNavTitles()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            interactionMenuItems.ClickOnInteractionTabs("Selectable");
            selectable.ClickOnNavTabs("List");
            selectable.ClickOnNavTabs("Grid");


        }

        [TestCaseSource(typeof(DataForSelectable), nameof(DataForSelectable.ListData))]
        public void ClickOnListElements(string _listTitles)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            interactionMenuItems.ClickOnInteractionTabs("Selectable");
            selectable.ClickOnNavTabs("List");
            selectable.ClickOnListTitles(_listTitles);
            
        }

        [TestCaseSource(typeof(DataForSelectable), nameof(DataForSelectable.Row1Data))]
        public void ClickOnRow1Title(string title)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            interactionMenuItems.ClickOnInteractionTabs("Selectable");
            selectable.ClickOnNavTabs("Grid");
            selectable.ClickOnGridTitlesRow1(title);
            
        }

        [TestCaseSource(typeof(DataForSelectable), nameof(DataForSelectable.Row2Data))]
        public void ClickOnRow2Title(string title)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            interactionMenuItems.ClickOnInteractionTabs("Selectable");
            selectable.ClickOnNavTabs("Grid");
            selectable.ClickOnGridTitlesRow2(title);
            Thread.Sleep(2000);

        }

        [TestCaseSource(typeof(DataForSelectable), nameof(DataForSelectable.Row3Data))]
        public void ClickOnRow3Title(string title)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Interactions");
            interactionMenuItems.ClickOnInteractionTabs("Selectable");
            selectable.ClickOnNavTabs("Grid");
            selectable.ClickOnGridTitlesRow3(title);
            Thread.Sleep(2000);

        }




    }
}
