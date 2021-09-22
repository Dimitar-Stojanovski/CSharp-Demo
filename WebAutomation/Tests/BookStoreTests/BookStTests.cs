using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForBookStore;

namespace WebAutomation.Tests.BookStoreTests
{
    public class BookStTests:BaseTests
    {
        [Test]
        public void ClickOnBookStoreButtons()
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Book Store");
            bookStore.ClickOnSearchBox();
            bookStore.ClickOnSearchBtn();
            //bookStore.ClickOnLoginBtn();
            javaScriptExec.ScrollBy500();
            bookStore.ClickOnPagePlaceholder();
            bookStore.ClickOnPageDropdown();
        }
        
        [TestCaseSource(typeof(DataForBookStoreObjects), nameof(DataForBookStoreObjects.BookLinks))]
        public void ClickOnBookLists(string _bookTitles)
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Book Store");
            bookStore.ClickOnBookLists(_bookTitles);
            javaScriptExec.ScrollBy300();
            bookStore.ClickOnBackToBookStoreBtn();
            Thread.Sleep(2000);
        }

        [TestCaseSource(typeof(DataForBookStoreObjects), nameof(DataForBookStoreObjects.BookLinks))]
        public void SearchBookAndClick(string _bookTitle)
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Book Store");
            bookStore.EnterTitleOnSearchBox(_bookTitle);
            //Assert.AreEqual(_bookTitle, bookStore.GetTextFromSearchBar());
            bookStore.ClickOnFirstRowInBookTable(0);
            


        }

        [TestCaseSource(typeof(DataForBookStoreObjects), nameof(DataForBookStoreObjects.DropDownData))]
        public void SelectTheOptionsFromTheDropDown(string _values)
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Book Store");
            javaScriptExec.ScrollBy500();
            bookStore.PopulateDropdown(_values);
           
            javaScriptExec.ScrollUpBy1000();
            Thread.Sleep(2000);
        }






    }
}
