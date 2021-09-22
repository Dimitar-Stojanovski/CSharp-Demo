using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.ElementTests
{
    public class BrokenLinksTests:BaseTests
    {
        [Test]
        public void ClickOnBrokenLinks()
        {
            Assert.Multiple(() =>
            {
                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Elements");
                
                elementsMenuTabs.ListElementTabs("Broken Links- Images");
                /* Assert.AreEqual(brokenLinks.GetTitles("Valid image"), "Valid image");
                 Assert.AreEqual(brokenLinks.GetTitles("Broken image"), "Broken image");
                 Assert.AreEqual(brokenLinks.GetTitles("Valid Link"), "Valid Link");
                 Assert.AreEqual(brokenLinks.GetTitles("Broken Link"), "Broken Link");*/
                brokenLinks.ClickOnValidLink();
                Thread.Sleep(1000);
               
                /* driver.Navigate().Back(); // ova samo za primer iako ne se koristi so navigate back
                brokenLinks.ClickOnValidLink();*/








            });
        }
    }
}
