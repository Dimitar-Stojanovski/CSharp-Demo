using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.AFW_Tests
{
    public class ModalDialogsTests: BaseTests
    {
        [Test]
        public void ClickOnSmallModalBtn()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Alerts, Frame & Windows");
            aFWMenuItems.ClickOnAFWTabs("Modal Dialogs");
            modalDialogs.ClickOnSmallModal();
            modalDialogs.ClickOnLargeModal();


        }
    }
}
