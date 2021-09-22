using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebAutomation.Utils.Specflow.Steps;

namespace WebAutomation.Utils.Specflow.Features
{
    [Binding]
    public class LogInSteps : Hooks1
    {
        [Given(@"enter username ""(.*)""")]
        public void GivenEnterUsername(string _name)
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Login");
            login.EnterUserName(_name);
            Thread.Sleep(1000);
        }

        [Given(@"enter password ""(.*)""")]
        public void GivenEnterPassword(string _password)
        {
            login.EnterPassword(_password);

        }

        [When(@"I click LoginButton")]
        public void WhenIClickLoginButton()
        {
            javaScriptExec.ScrollBy300();
            login.ClickOnLogInBtn();

        }

        [Then(@"A message ""(.*)"" should be displayed")]
        public void ThenAMessageShouldBeDisplayed(string _responseMessage)
        {
            Assert.AreEqual(login.GetResponseMessage(), _responseMessage);

        }
    }
}
