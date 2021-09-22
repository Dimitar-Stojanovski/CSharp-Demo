using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebAutomation.Framework;

namespace WebAutomation.Utils.Specflow.Steps
{
    [Binding]
    public class RegisterNewUserSteps : Hooks1
    {
        [Given(@"I navigate on the page")]
        public void GivenINavigateOnThePage()
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Login");
        }

        [Given(@"I click New User Button")]
        public void GivenIClickNewUserButton()
        {
            login.ClickOnNewUserBtn();
        }

        [Given(@"I enter First Name ""(.*)""")]
        public void GivenIEnterFirstName(string _name)
        {
            login.EnterName(_name);
        }

        [Given(@"I enter Last Name ""(.*)""")]
        public void GivenIEnterLastName(string _lastName)
        {
            login.EnterLastName(_lastName);
        }

        [Given(@"I enter UserName ""(.*)""")]
        public void GivenIEnterUserName(string _userName)
        {
            login.EnterUserName(_userName);
        }

        [Given(@"I enter Password ""(.*)""")]
        public void GivenIEnterPassword(string _password)
        {
            login.EnterPassword(_password);
        }

        [When(@"I press register button")]
        public void WhenIPressRegisterButton()
        {
            javaScriptExec.ScrollBy300();
            login.ClickOnRegisterBtn();
        }

        [Then(@"Verify the message ""(.*)""")]
        public void ThenVerifyTheMessage(string _message)
        {
            Assert.AreEqual(login.GetTextAfterRegistering(), _message);
        }
    }
}
