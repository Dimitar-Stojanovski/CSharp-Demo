using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForBookStore;

namespace WebAutomation.Tests.BookStoreTests
{
    public class LoginTests:BaseTests
    {
        [Test]
        public void ClickOnLoginButtons()
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();

            bookStoreTabs.ListMenuTabs("Login");
            login.ClickOnLogInBtn();
            login.ClickOnNewUserBtn();
            login.ClickOnRegisterBtn();
            login.ClickOnBackToLogInBtn();
        }

        [Test]
        public void PopulateUserNameAndPassword()
        {
            string _responseForInvalidCred = "Invalid username or password!";
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Login");
            login.EnterUserName(Faker.NameFaker.FirstName());
            login.EnterPassword(Faker.LocationFaker.City());
            login.ClickOnLogInBtn();
            Assert.AreEqual(login.GetResponseMessage(), _responseForInvalidCred);
            Thread.Sleep(1000);

        }

        [TestCaseSource(typeof(DataForLogin), nameof(DataForLogin.TestDataForLogin))]
        public void EnterCredentialsWithFakeData(string _username, string _password)
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Login");
            login.EnterUserName(_username);
            login.EnterPassword(_password);
            javaScriptExec.ScrollBy300();
            login.ClickOnLogInBtn();
            Assert.AreEqual(login.GetResponseMessage(), ConstantsForLogin._INVALID_CREDENTIALS);
        }

        [Test]
        public void CreateUser()
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Login");
            login.ClickOnNewUserBtn();
            login.EnterName("Dimitar");
            login.EnterLastName("Stojanovski");
            login.EnterUserName("UsernameDimitar");
            login.EnterPassword("Password1!");
            login.SwitchToRecaptchaIframe();
            login.ClickOnRecapthcha();
            login.SwitchToDefaultContent();
            login.ClickOnRegisterBtn();
            Thread.Sleep(2000);
        }

        [TestCaseSource(typeof(DataForLogin), nameof(DataForLogin.TestDataForCreateUser))]
        public void CreateUserFromData(string _firstName, string _lastName, string _userName, string _password)
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Book Store Application");
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy800();
            bookStoreTabs.ListMenuTabs("Login");
            login.ClickOnNewUserBtn();
            login.EnterName(_firstName);
            login.EnterLastName(_lastName);
            login.EnterUserName(_userName);
            login.EnterPassword(_password);
            login.SwitchToRecaptchaIframe();
            login.ClickOnRecapthcha();
            login.SwitchToDefaultContent();
            login.ClickOnRegisterBtn();
        }
    }
}
