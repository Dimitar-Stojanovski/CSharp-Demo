using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForBookStore;

namespace WebAutomation.Tests.BookStoreTests
{
    public class BookStoreTabsTests:BaseTests
    {
        [TestCaseSource(typeof(BookStoreMenuData), nameof(BookStoreMenuData.MenuData))]
        public void ClickOnBookStoreTabs(string tabs)
        {
            //javaScriptExec.ScrollBy500();
            scroll.ScrollDown(0, 500);
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            //scroll.ScrollDown(1600,0);

            bookStoreTabs.ListMenuTabs(tabs);

        }




    }
}
