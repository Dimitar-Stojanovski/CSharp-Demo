using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.AFW_Tests
{
    public class BrowserWindowTests: BaseTests
    {
        private string _headerText = "This is a sample page";
        private string _mainHeaderText = "Browser Windows";

        [Test]
        public void ClickOnNewTabBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Browser Windows");
            browserWindows.ClickOnNewTabBtn();
        }
        
        [Test]
        public void ClickOnNewWindowBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Browser Windows");
            browserWindows.ClickOnNewWindowBtn();
        }
        
        [Test]
        public void ClickOnNewWindowMessBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Browser Windows");
            browserWindows.ClickOnNewWindowBtn();
        }

        [Test]
        public void NavigateThroughNewTabBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Browser Windows");
            browserWindows.ClickOnNewTabBtn();
            Thread.Sleep(500);
            browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 1);
            Console.WriteLine("Fokus window is", browserWindows.GetCurrentTab());
            Assert.AreEqual(browserWindows.ReturnHeading(), _headerText);
            browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 0);
            Console.WriteLine("Fokus window is", browserWindows.GetCurrentTab());

        }

        [Test]
        public void NavigateThroughNewWindowBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Browser Windows");
            browserWindows.ClickOnNewWindowBtn();
            Thread.Sleep(500);
            browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 1);
            Assert.AreEqual(browserWindows.ReturnHeading(), _headerText);
            browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 0);
            Assert.AreEqual(browserWindows.GetTextFromMainHeader(), _mainHeaderText);
            Thread.Sleep(1000);
        }

        [Test]
        public void NavigateThroughNewWindowMessBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Browser Windows");
            browserWindows.ClickOnNewWindowMessBtn();
            browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 1);
            Thread.Sleep(500);
            browserWindows.CountWindowHandles();
            browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 0);
            Assert.AreEqual(browserWindows.GetTextFromMainHeader(), _mainHeaderText);
            Thread.Sleep(1000);



        }

        [Test]
        public void OpenMultipleWindows()
        {
            scroll.ScrollDown(0, 300);
            Thread.Sleep(2000);
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Browser Windows");
            browserWindows.ClickOnNewWindowMessBtn();
            browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 1);
            Thread.Sleep(500);
            browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 0);
        }


        [Test]
        public void OpenMultipleWindowsAndNavigateThroughThem()
        {
            Assert.Multiple(() =>
            {
                scroll.ScrollDown(0, 300);
                Thread.Sleep(2000);
                menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
                aFWMenuItems.ClickOnAFWTabs("Browser Windows");
                browserWindows.ClickOnNewTabBtn();
                browserWindows.ClickOnNewWindowBtn();
                Thread.Sleep(1000);
                Console.WriteLine(browserWindows.CountWindowHandles());
                browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 1);
                Assert.AreEqual(browserWindows.ReturnHeading(), _headerText);
                browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 2);
                Assert.AreEqual(browserWindows.ReturnHeading(), _headerText);
                browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 0);
                Assert.AreEqual(browserWindows.GetTextFromMainHeader(), _mainHeaderText);
                browserWindows.ClickOnNewWindowMessBtn();
                browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 3);
                browserWindows.NavigateToTab(browserWindows.GetAllTabs(), 0);
                Assert.AreEqual(browserWindows.GetTextFromMainHeader(), _mainHeaderText);

                Thread.Sleep(1000);

            });

            
        }


    }
}
