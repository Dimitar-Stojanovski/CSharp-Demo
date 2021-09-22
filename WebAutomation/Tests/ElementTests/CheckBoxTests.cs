using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests
{
    public class CheckBoxTests : BaseTests
    {
        [Test]
        public void ClicksOnCheckBxs()
        {
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Check Box");
            //checkBox.ClickExpandAllButton();
            checkBox.ClickDropDown();
            checkBox.ClickCheckBx("Home");
            checkBox.ClickDropDownDesktop();
            checkBox.ClickCheckBx("Desktop");


            checkBox.ClickCheckBx("Notes");
            checkBox.ClickCheckBx("Commands");
            checkBox.ClickDropDownDocuments();

            checkBox.ClickCheckBx("Documents");
            checkBox.ClickCheckBx("WorkSpace");
            checkBox.ClickCheckBx("Office");
            checkBox.ClickDropDownDownloads();
            checkBox.ClickCheckBx("Word File.doc");
            checkBox.ClickCheckBx("Excel File.doc");

            Thread.Sleep(2000);
         }

    }

      
}
