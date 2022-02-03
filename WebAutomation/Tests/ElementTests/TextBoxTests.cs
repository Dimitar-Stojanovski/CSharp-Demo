using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders;

namespace WebAutomation.Tests.ElementTests
{
    public class TextBoxTests:BaseTests
    {
        [Test]
        public void FillOutTextBox()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Text Box");
            textBox.EnterFullName("Dimitar");
            textBox.EnterEmail("dimitar@mail.com");
            textBox.EnterCurrentAddress("Address 1");
            textBox.EnterPermanentAddress("Address 2");
            javaScriptExec.ScrollUpBy300();
            textBox.ClickSubmitButton();
            Thread.Sleep(2000);


        }

        [Test]
        public void FillOutAndClearTextBox()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Text Box");
            textBox.EnterFullName("Dimitar Stojanovski");
            Thread.Sleep(1000);
            textBox.ClearName();
            textBox.EnterEmail("dimitar@mail.com");
            Thread.Sleep(1000);
            textBox.ClearEmail();
            textBox.EnterCurrentAddress("Address 1");
            Thread.Sleep(1000);
            textBox.ClearCurrentAddress();
            textBox.EnterPermanentAddress("Address 2");
            Thread.Sleep(1000);
            textBox.ClearPermanentAddress();
            javaScriptExec.ScrollUpBy300();
            textBox.ClickSubmitButton();
            Thread.Sleep(2000);


        }

        [Test]
        public void FillOutTextBoxUsingConstants()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Text Box");
            textBox.EnterFullName(ConstantsForTextBox._USER_NAME_TEXTBOX);
            textBox.EnterEmail(ConstantsForTextBox._EMAIL_TEXTBOX);
            textBox.EnterCurrentAddress(ConstantsForTextBox._CURRENT_ADDRESS_TEXTBOX);
            textBox.EnterPermanentAddress(ConstantsForTextBox._PERMANENT_ADDRESS_TEXTBOX);
            javaScriptExec.ScrollBy300();
            textBox.ClickSubmitButton();
            Assert.AreEqual(textBox.GetBasicInfoTitles("Name"), $"Name:{ConstantsForTextBox._USER_NAME_TEXTBOX}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Email"), $"Email:{ConstantsForTextBox._EMAIL_TEXTBOX}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Current Address"), $"Current Address :{ConstantsForTextBox._CURRENT_ADDRESS_TEXTBOX}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Permananet Address"), $"Permananet Address :{ConstantsForTextBox._PERMANENT_ADDRESS_TEXTBOX}");


        }


        [TestCaseSource(typeof(DataForTextBox), nameof(DataForTextBox.TextBoxData))]
        public void InsertDataFromDataProvider(string FullName, string Email, string CurrentAddress, string PermanentAddress)
        {
            Assert.Multiple(() =>
            {
            
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Text Box");
            textBox.EnterFullName(FullName);
            textBox.EnterEmail(Email);
            textBox.EnterCurrentAddress(CurrentAddress);
            textBox.EnterPermanentAddress(PermanentAddress);
            javaScriptExec.ScrollBy300();
            textBox.ClickSubmitButton();
            //Asseerts
            Assert.AreEqual(textBox.GetBasicInfoTitles("Name"), $"Name:{FullName}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Email"), $"Email:{Email}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Current Address"), $"Current Address :{CurrentAddress}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Permananet Address"), $"Permananet Address :{PermanentAddress}");
            
            
            
            });


        }


        [TestCaseSource(typeof(DataForTextBox), nameof(DataForTextBox.ReadContentFromExcelFile))]
        public void InsertDataFromExcelFile(string FullName, string Email, string CurrentAddress, string PermanentAddress)
        {
            Assert.Multiple(() =>
            {

                menuItems.ClickOnMenuCard("Elements");
                elementsMenuTabs.ListElementTabs("Text Box");
                textBox.EnterFullName(FullName);
                textBox.EnterEmail(Email);
                textBox.EnterCurrentAddress(CurrentAddress);
                textBox.EnterPermanentAddress(PermanentAddress);
                javaScriptExec.ScrollBy300();
                textBox.ClickSubmitButton();
                //Asseerts
                Assert.AreEqual(textBox.GetBasicInfoTitles("Name"), $"Name:{FullName}");
                Assert.AreEqual(textBox.GetBasicInfoTitles("Email"), $"Email:{Email}");
                Assert.AreEqual(textBox.GetBasicInfoTitles("Current Address"), $"Current Address :{CurrentAddress}");
                Assert.AreEqual(textBox.GetBasicInfoTitles("Permananet Address"), $"Permananet Address :{PermanentAddress}");

            });
        }





    }
}
