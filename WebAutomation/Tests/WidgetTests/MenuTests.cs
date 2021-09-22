using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForWidgets;

namespace WebAutomation.Tests.WidgetTests
{
    public class MenuTests:BaseTests
    {

        [TestCaseSource(typeof(DataForMenuTab), nameof(DataForMenuTab.TestDataForMenuTab))]
        public void ClickOnMenuItemsWithData(string _menu)
        {
            //javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Menu");
            menuObject.ClickOnMenuItems(_menu);
            Thread.Sleep(1000);
        }

        [TestCaseSource(typeof(DataForMenuTab), nameof(DataForMenuTab.TestForMainItem2))]
        public void ClickOnMenuItems2(string _list)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Menu");
            menuObject.ClickOnMenuItems("Main Item 2");
            Thread.Sleep(500);
            menuObject.ClicOnMenuItems2List(_list);
            Thread.Sleep(1000);

        }

        [TestCaseSource(typeof(DataForMenuTab), nameof(DataForMenuTab.TestForSubSubList))]
        public void ClickOnSubSubList(string _sublist, string _subItem)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Menu");
            menuObject.ClickOnMenuItems("Main Item 2");
            menuObject.ClicOnMenuItems2List(_sublist);
            menuObject.ClickOnSubListProperties(_subItem);
            Thread.Sleep(1000);

        }




    }
}
















