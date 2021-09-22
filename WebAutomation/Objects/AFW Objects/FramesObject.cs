using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.WidgetObjects
{
    public class FramesObject:MethodsCollection 
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By _iframeOne = new IDPath("frame1Wrapper", "/iframe");    //*[@id='frame1Wrapper']/iframe
        By _iframeHeading = new ContainsText("This is a sample page");   //*[contains(text(), 'This is a sample page')]
        By _iframeTwo = new IDPath("frame2Wrapper", "/iframe");  //*[@id= 'frame2Wrapper']/iframe
        By _parentFrameHeader = new ClassLoc("main-header");

        public FramesObject(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void SwitchToIframe1()
        {
            switchToFrame(_iframeOne);
        }

        public void SwitchToIframe2()
        {
            switchToFrame(_iframeTwo);
        }
        public string GetTextFomIframe()
        {
            return GetTextFromElement(_iframeHeading);
            
        }

        public string GetTextFromParentFrame()
        {
            return GetTextFromElement(_parentFrameHeader);
        }

        
        public void SwitchToParentFrame()
        {
            driver.SwitchTo().ParentFrame();
        }

        public void SwitchToIframeWithIndex(int index)
        {
            driver.SwitchTo().Frame(index);
        }
       
    }
}
