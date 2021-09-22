using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects
{
    public class Buttons:MethodsCollection
    {
        IWebDriver driver;
        WebDriverWait wait;
        Actions action;
        By doubleClickBtn = By.Id("doubleClickBtn");
        By rightClickBtn = By.Id("rightClickBtn");
        By clickMeBtn = By.XPath("//*[@class = 'mt-4'][2]/button");
        By doubleClickMessage = By.Id("doubleClickMessage");
        By rightClickMessage = By.Id("rightClickMessage");
        By dynamicClickMessage = By.Id("dynamicClickMessage");


        public Buttons(IWebDriver driver, WebDriverWait wait, Actions action ):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;

        }

        

        public void ClickDoubleClick()
        {
           action.MoveToElement(webElement(doubleClickBtn)).DoubleClick().Perform();
            
        }

        public void ClickRightClickBtn()
        {
            action.ContextClick(webElement(rightClickBtn)).Perform();
           
        }

        public void DynamicClick()
        {
            action.MoveToElement(webElement(clickMeBtn)).Click().Perform();
           
        }

        public string GetDoubleClickMsg()
        {
            
            return GetTextFromElement(doubleClickMessage);
        }
        public string GetRightClickMsg()
        {
            
            return GetTextFromElement(rightClickMessage);
        }
        public string GetDynamicClickMsg()
        {
           
            return GetTextFromElement(dynamicClickMessage);
        }
    }
}
