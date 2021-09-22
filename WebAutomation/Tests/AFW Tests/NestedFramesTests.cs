using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace WebAutomation.Tests.AFW_Tests
{
    public class NestedFramesTests:BaseTests
    {
        private string _parentFrameText = "Parent frame";
        private string _childFrameText = "Child Iframe";
        private string _mainWindowHeader = "Nested Frames";

        [Test]
        public void SwitchBetweenFrames()
        {
            Assert.Multiple(() =>
            {
                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
                aFWMenuItems.ClickOnAFWTabs("Nested Frames");
                Assert.AreEqual(nestedFrames.GetTextFromMainHeader(), "Nested Frames");
                nestedFrames.SwitchToParentFrame();
                Assert.AreEqual(nestedFrames.GetTextFromParentFrame(), _parentFrameText);
                Assert.True(nestedFrames.VerifyTextInParentFrame());
                nestedFrames.SwitchToChildFrame();
                Assert.AreEqual(nestedFrames.GetTextFromChildFrame(), _childFrameText);
                nestedFrames.SwitchToMainWindow();
                Assert.AreEqual(nestedFrames.GetTextFromMainHeader(), "Nested Frames");
                

            });
           
        }

        [Test]
        public void VerifyTextInFramesAndSwitchingBetweenThem()
        {
            Assert.Multiple(() =>
            {
                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
                aFWMenuItems.ClickOnAFWTabs("Nested Frames");
                Assert.AreEqual(nestedFrames.GetTextFromMainHeader(), _mainWindowHeader);
                nestedFrames.SwitchToParentFrame();
                Assert.AreEqual(nestedFrames.GetTextFromParentFrame(), _parentFrameText);
                nestedFrames.SwitchToMainWindow();
                Assert.AreEqual(nestedFrames.GetTextFromMainHeader(), _mainWindowHeader);
                nestedFrames.SwitchToParentFrame();
                nestedFrames.SwitchToChildFrame();
                Assert.AreEqual(nestedFrames.GetTextFromChildFrame(), _childFrameText);
                nestedFrames.SwitchToMainWindow();
                nestedFrames.SwitchToParentFrame();
                Assert.AreEqual(nestedFrames.GetTextFromParentFrame(), _parentFrameText);
                nestedFrames.SwitchToMainWindow();
                Assert.AreEqual(nestedFrames.GetTextFromMainHeader(), _mainWindowHeader);

            });
           
        }

        [Test]
        public void SwitchToFramesWithIndex()
        {
            Assert.Multiple(() =>
            {
                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
                aFWMenuItems.ClickOnAFWTabs("Nested Frames");
                Assert.AreEqual(nestedFrames.GetTextFromMainHeader(), _mainWindowHeader);
                nestedFrames.SwitchIframeByIndex(1);
                Assert.AreEqual(nestedFrames.GetTextFromParentFrame(), _parentFrameText);
                nestedFrames.SwitchIframeByIndex(0);
                Assert.AreEqual(nestedFrames.GetTextFromChildFrame(), _childFrameText);
                nestedFrames.SwitchToMainWindow();
                Assert.AreEqual(nestedFrames.GetTextFromMainHeader(), _mainWindowHeader);
            });
        }
    }
}
