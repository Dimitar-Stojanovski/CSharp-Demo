using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace WebAutomation.Tests.BookStoreTests
{
    public class ProfileTests:BaseTests
    {
        [Test]
        public void ClickOnLogInAndRegisterLinks()
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Profile");
            profile.ClickOnLinkTexts("login");
            driver.Navigate().Back();
            profile.ClickOnLinkTexts("register");

            Thread.Sleep(2000);

        }
    }
}
