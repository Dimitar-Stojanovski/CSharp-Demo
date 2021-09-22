using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebAutomation.Tests;
using WebAutomation.Utils.Specflow.Steps;

namespace WebAutomation.Utils.Specflow
{
    [Binding]
    public class DropDownSteps : Hooks1
    {


        [Given(@"I navigate to the page")]
        public void GivenINavigateToThePage()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");

        }

        [Given(@"select values from a dropdown")]
        public void GivenSelectValuesFromADropdown()
        {
            selectMenuObjects.PopulateMultiSelectDropDown();
        }

        [Then(@"the page should navigate back")]
        public void ThenThePageShouldNavigateBack()
        {
            driver.Navigate().Back();
            Thread.Sleep(2000);
        }
    }
}
