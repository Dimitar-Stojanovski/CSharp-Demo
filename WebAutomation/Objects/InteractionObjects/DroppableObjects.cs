using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.InteractionObjects
{
    public class DroppableObjects:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;
        By _navTabs = new ClassPath("nav nav-tabs", "/a");
        By _dragMe = By.Id("draggable");
        By _dropMe = By.Id("droppable");
        By _dropText = new TextLoc("Dropped!");
        By _acceptable = new TextLoc("Acceptable");
        By _notAcceptable = new IDPath("acceptable", "/../div[2]");
        By _dragBox = By.Id("dragBox");
        By _outerDroppable = By.Id("notGreedyDropBox");
        By _notGreedyDropBxText = new IDPath("notGreedyDropBox", "/p");
        By _innerDroppable = By.Id("notGreedyInnerDropBox");
        private string[] _navTitles = { "Simple", "Accept", "Prevent Propogation", "Revert Draggable" };

        public DroppableObjects(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
        }

        public void ClickOnDroppableNavTab(string _title) 
        {
            int index = Array.IndexOf(_navTitles, _title);
            webElements(_navTabs)[index].Click();
           
            
        }

        public void PerformDragAndDrop()
        {
            action = new Actions(driver);
            var dragMe = webElement(_dragMe);
            var dropMe = webElement(_dropMe);
            action.ClickAndHold(dragMe).MoveToElement(dropMe).Release().Build().Perform();
        }

        public string GetMessageAfterDragAndDrop()
        {
            return GetTextFromElement(_dropText);
           
        }

        public void DragAndDropWithNotAcceptable()
        {
            action = new Actions(driver);
            var dragMe = webElement(_notAcceptable);
            var dropMe = webElement(_dropMe);
            action.ClickAndHold(dragMe).MoveToElement(dropMe).Release().Perform();
            
        }

        public void DragAndDropWithAcceptable()
        {
            action = new Actions(driver);
            var dragMe = webElement(_acceptable);
            var dropMe = webElement(_dropMe);
            action.DragAndDrop(dragMe, dropMe).Build().Perform();
            
        }

        public void DragAndDropToNotGreedy()
        {
            action = new Actions(driver);
            var dragMe = webElement(_dragBox);
            var dropMe = webElement(_outerDroppable);
            action.ClickAndHold(dragMe).MoveByOffset(358,18).Release().Perform();
        }

        public void DragAndDropToInnerDropBxNotGreedy()
        {
            action = new Actions(driver);
            var dragMe = webElement(_dragBox);
            var dropMe = webElement(_innerDroppable);
            action.DragAndDrop(dragMe, dropMe).Build().Perform();
            
        }



        public string GetTextFromNotGreedyDropBx()
        {
            return GetTextFromElement(_notGreedyDropBxText);
           
        }

    }
}
