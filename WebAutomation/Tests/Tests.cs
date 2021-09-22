using NUnit.Framework;
using WebAutomation.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using WebAutomation.Utils;
using WebAutomation.Utils.DataProviders;

namespace WebAutomation.Tests
{
    
    public class Tests:BaseTests
    {
        IJavaScriptExecutor js;
       
        
        [TestCaseSource(typeof(DataForHomePage), nameof(DataForHomePage.HomePageItems))]
        public void MenuCardClicks(string homePageItem)
        {
            menuItems.ClickOnMenuCard(homePageItem);
            

         }// data provider solution

        [Test]
        public void SelectElementMenuTabs()
        {   
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Text Box");
            elementsMenuTabs.ListElementTabs("Check Box");
            elementsMenuTabs.ListElementTabs("Radio Button");
            elementsMenuTabs.ListElementTabs("Web Tables");

            javaScriptExec.ScrollBy500();

            elementsMenuTabs.ListElementTabs("Buttons");
            elementsMenuTabs.ListElementTabs("Links");
            elementsMenuTabs.ListElementTabs("Broken Links- Images");

            javaScriptExec.ScrollBy300();
            
            elementsMenuTabs.ListElementTabs("Upload and Download");
            elementsMenuTabs.ListElementTabs("Dynamic Properties");
            Thread.Sleep(2000);

        }


        [Test]
        public void ClickOnRadioButton()
        {
            string[] answers = { "Yes", "Impressive" };
            string statement = "You have selected";

            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Radio Button");
            Assert.AreEqual(radioButtons.GetQuestion(), TitlesForElements._RADIO_BUTTON_QUESTION);
            radioButtons.ClickRadioButton("Yes");
            Thread.Sleep(2000);
            radioButtons.ClickRadioButton("Impressive");
            Thread.Sleep(2000);
            //radioButtons.ClickRadioButton("No");
            //Assert.AreEqual(radioButtons.GetRadioMessage(), statement+" " +answers[1] );
            
        }

       

        [Test]
        public void ButtonsClick()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            javaScriptExec.ScrollBy300();
            elementsMenuTabs.ListElementTabs("Buttons");
            buttons.ClickDoubleClick();
            buttons.ClickRightClickBtn();
            buttons.DynamicClick();
            Assert.AreEqual(buttons.GetDoubleClickMsg(), MessagesForAssertions._DOUBLE_CLICK_MSG);
            Assert.AreEqual(buttons.GetRightClickMsg(), MessagesForAssertions._RIGHT_CLICK_MSG);
            Assert.AreEqual(buttons.GetDynamicClickMsg(), MessagesForAssertions._DYNAMIC_CLICK_MSG);
        }

       
        
        
       
    }
}
