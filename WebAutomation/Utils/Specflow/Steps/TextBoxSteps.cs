using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebAutomation.Utils.DataProviders;

namespace WebAutomation.Utils.Specflow.Steps
{
    [Binding]
    public class TextBoxSteps : Hooks1
    {

        [Given(@"Navigate to the page")]
        public void GivenNavigateToThePage()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Text Box");

        }

        [Given(@"Populate Full Name")]
        public void GivenPopulateFullName()
        {
            textBox.EnterFullName(ConstantsForTextBox._USER_NAME_TEXTBOX);

        }

        [Given(@"Populate Email")]
        public void GivenPopulateEmail()
        {
            textBox.EnterEmail(ConstantsForTextBox._EMAIL_TEXTBOX);
            Thread.Sleep(1000);
        }

        [Given(@"Populate Current Address")]
        public void GivenPopulateCurrentAddress()
        {
            textBox.EnterCurrentAddress(ConstantsForTextBox._CURRENT_ADDRESS_TEXTBOX);

        }

        [Given(@"Populate Permanent Address")]
        public void GivenPopulatePermanentAddress()
        {
            textBox.EnterPermanentAddress(ConstantsForTextBox._PERMANENT_ADDRESS_TEXTBOX);

        }

        [When(@"I click Login Button")]
        public void WhenIClickLoginButton()
        {
            javaScriptExec.ScrollBy300();
            textBox.ClickSubmitButton();

        }

        [Then(@"I want to verify the data")]
        public void ThenIWantToVerifyTheData()
        {
            Assert.AreEqual(textBox.GetBasicInfoTitles("Name"), $"Name:{ConstantsForTextBox._USER_NAME_TEXTBOX}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Email"), $"Email:{ConstantsForTextBox._EMAIL_TEXTBOX}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Current Address"), $"Current Address :{ConstantsForTextBox._CURRENT_ADDRESS_TEXTBOX}");
            Assert.AreEqual(textBox.GetBasicInfoTitles("Permananet Address"), $"Permananet Address :{ConstantsForTextBox._PERMANENT_ADDRESS_TEXTBOX}");
            Thread.Sleep(1000);
        }
    }
}
