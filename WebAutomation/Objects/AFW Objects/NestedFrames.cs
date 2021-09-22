using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.AFW_Objects
{
    public class NestedFrames:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;

        By _mainHeader = new ClassLoc("main-header");
        By _parentFrame = By.Id("frame1");
        By _childFrame = new TextPath("Parent frame", "/iframe"); 
        By _childFrameText = new TextLoc("Child Iframe");
        By _parentFrameText = new TextLoc("Parent frame");
        public NestedFrames(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public string GetTextFromMainHeader()
        {
            return GetTextFromElement(_mainHeader);
        }

        public void SwitchToParentFrame()
        {
            switchToFrame(_parentFrame);
        }

        public void SwitchToChildFrame()
        {
            switchToFrame(_childFrame);
        }

        public string GetTextFromChildFrame()
        {
            return GetTextFromElement(_childFrameText);
        }

        public string GetTextFromParentFrame()
        {
            return GetTextFromElement(_parentFrameText);
        }

        public void SwitchToMainWindow()
        {
            driver.SwitchTo().DefaultContent();
        }

        public bool VerifyTextInParentFrame()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(_parentFrameText)).Displayed;
        }

        public void SwitchIframeByIndex(int index)
        {
            driver.SwitchTo().Frame(index);
        }
    }
}
