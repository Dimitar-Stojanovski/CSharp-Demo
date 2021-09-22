using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForWidgets;

namespace WebAutomation.Tests.WidgetTests
{
   public class WidgetTest:BaseTests
    {
        [TestCaseSource(typeof(DataForWidgetMenuListing), nameof(DataForWidgetMenuListing.DataForListing))]
        public void ListAllWidgetMenuItems(string tabs)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs(tabs);
            

        }
        
        [Test]
        public void ClickOnTabs()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Tabs");
            widgetTabs.ClickOnLoremIpsumElements("What");
            widgetTabs.ClickOnLoremIpsumElements("Origin");
            widgetTabs.ClickOnLoremIpsumElements("Use");
            Thread.Sleep(2000);

        }

        [Test]
        public void ClickOnAccordian()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Accordian");
            widgetAccordian.ClickOnWhatLoremIps();
            widgetAccordian.ClickOnWhereComesFrom();
            widgetAccordian.ClickOnWhereWeUseIt();
        }
    }
}
