using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils;
using WebAutomation.Utils.DataProviders;

namespace WebAutomation.Tests
{
    public class LinkTests: BaseTests
    {
        IJavaScriptExecutor js;

         [Test]
        public void ClickHomeLink()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            javaScriptExec.ScrollBy300();
            elementsMenuTabs.ListElementTabs("Links");
            links.ClickHomeLnk();
            

        }

        [Test]
        public void ClickDynamicLink()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            javaScriptExec.ScrollBy300();
            elementsMenuTabs.ListElementTabs("Links");
            links.ClickDynamicLnk();
            
        }

        [Test]
        public void ClickOnApiLinks()
        {
            Assert.Multiple(() =>
            {
                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Elements");
                javaScriptExec.ScrollBy300();
                elementsMenuTabs.ListElementTabs("Links");

                links.ClickOnCreatedLinks();
                Thread.Sleep(1000);
                Assert.AreEqual(links.GetResponseMsg(), MessagesForAssertions.__CREATED_MSG);

                
                links.ClickOnNoContentLinks();
                Thread.Sleep(1000);
                Assert.AreEqual(links.GetResponseMsg(), MessagesForAssertions.__NO_CONTENT_MSG);

                links.ClickOnMovedLinks();
                Thread.Sleep(1000);
                Assert.AreEqual(links.GetResponseMsg(), MessagesForAssertions._MOVED_MSG);

                links.ClickOnBadRequestLinks();
                Thread.Sleep(1000);
                Assert.AreEqual(links.GetResponseMsg(), MessagesForAssertions._BAD_REQUEST);

                links.ClickOnUnauthorisedLinks();
                Thread.Sleep(1000);
                Assert.AreEqual(links.GetResponseMsg(), MessagesForAssertions._UNAUTHORIZED);

                links.ClickOnForbidenLinks();
                Thread.Sleep(1000);
                Assert.AreEqual(links.GetResponseMsg(), MessagesForAssertions._FORBIDEN);

                links.ClickOnNotFoundLinks();
                Thread.Sleep(1000);
                Assert.AreEqual(links.GetResponseMsg(), MessagesForAssertions._NOT_FOUND);








            });

           
            
            



        }
    }
}
