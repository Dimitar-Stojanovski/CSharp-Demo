using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.AFW_Tests
{
    public class IframesTests:BaseTests
    {
        private string _iframeHeader = "This is a sample page";
        private string _mainHeader = "Frames";

        [Test]
        public void TestSwithchingBetweenIframes()
        {   
            
            Assert.Multiple(() =>
            {
                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
                aFWMenuItems.ClickOnAFWTabs("Frames");
                framesObject.SwitchToIframe1();
                Assert.AreEqual(framesObject.GetTextFomIframe(), _iframeHeader);
                framesObject.SwitchToParentFrame();
                framesObject.SwitchToIframe2();
                Assert.AreEqual(framesObject.GetTextFomIframe(), _iframeHeader);
                Thread.Sleep(2000);

            });
            
        }

        [Test]
        public void TestingAndVerifyingNavigationBetweenFrames()
        {
            Assert.Multiple(() =>
            {
                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
                aFWMenuItems.ClickOnAFWTabs("Frames");
                Assert.AreEqual(framesObject.GetTextFromParentFrame(), _mainHeader);
                framesObject.SwitchToIframe1();
                Assert.AreEqual(framesObject.GetTextFomIframe(), _iframeHeader);
                framesObject.SwitchToParentFrame();
                Assert.AreEqual(framesObject.GetTextFromParentFrame(), _mainHeader);
                framesObject.SwitchToIframe2();
                Assert.AreEqual(framesObject.GetTextFomIframe(), _iframeHeader);
                framesObject.SwitchToParentFrame();
                Assert.AreEqual(framesObject.GetTextFromParentFrame(), _mainHeader);

            });
        }
    }
}
