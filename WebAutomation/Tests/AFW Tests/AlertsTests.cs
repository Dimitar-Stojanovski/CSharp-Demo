using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.AFW_Tests
{
    public class AlertsTests:BaseTests
    {
        [Test]
        public void TestAlertBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            javaScriptExec.ScrollBy300();
            aFWMenuItems.ClickOnAFWTabs("Alerts");
            alertsObjects.ClickOnAlertBtn();
            Thread.Sleep(1000);
        }
        
        [Test]
        public void TestTimeAlertBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Alerts");
            alertsObjects.ClickOnTimeAlertBtn();
            Thread.Sleep(2000);
        }

        [Test]
        public void TestConfirmAlertBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Alerts");
            alertsObjects.ClickOnConfirmAlertBtn();
            Thread.Sleep(2000);
        }

        [Test]
        public void TestPromptAlertBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Alerts");
            alertsObjects.ClickOnPromptAlertBtn("Dimitar Stojanovski");
            Thread.Sleep(2000);
        }
    }
}
