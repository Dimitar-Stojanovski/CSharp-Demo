using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.WidgetTests
{
    public class ProgressBarTest:BaseTests
    {
        private bool _condition = true;
        [Test]
        public void TestProgresBar()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Progress Bar");
            progressBar.ClickOnStartBtn();
            Assert.That(progressBar.VerifyProgressBarFinish(), Is.True);
        }

        [Test]
        public void TestProgressBarPercentage()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Progress Bar");
            progressBar.ClickOnStartBtn();
            Assert.That(progressBar.VerifyProgressBarFinish(), Is.True);
            Assert.AreEqual(progressBar.GetPecrentFromProgressBar(), "100%");
           
            Thread.Sleep(2000);
        }

        [Test]
        public void TestProgressBarWithAddedPercentages()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Progress Bar");
            progressBar.ClickOnStartBtn();
            Assert.That(progressBar.VerifyProgressBarFinish(), Is.True);
            Assert.AreEqual(progressBar.GetPecrentFromProgressBar(), "100%");
            progressBar.ClickOnResetBtn();
            Thread.Sleep(2000);
        }

        [Test]
        public void TestProgressBarWithBreakPercentages()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Progress Bar");
            progressBar.ClickOnStartBtn();
            Assert.IsTrue(progressBar.VerifyProgressBarFinish());
            Assert.AreEqual(progressBar.GetPecrentFromProgressBar(), "100%");
            Thread.Sleep(2000);
        }
    }
}
