using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects
{
    public class Links:MethodsCollection
    {
        IWebDriver driver;
        WebDriverWait wait;
        //Links for New Tab
        By HomeLink = By.Id("simpleLink");
        By DynamicLink = By.Id("dynamicLink");

        //Api Links
        By CreatedLink = new TextLoc("Created");       
        By NoContentLink = new TextLoc("No Content");  
        By MovedLink = new TextLoc("Moved");           
        By BadRequestLink = new TextLoc("Bad Request"); 
        By UnAuthorisedLink = new TextLoc("Unauthorized");  
        By ForbidenLink = new TextLoc("Forbidden");                
        By NotFoundLink = new TextLoc("Not Found");     
        By LinksResponse = By.Id("linkResponse");
        



        public Links(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            

        }

        
        public void ClickHomeLnk()
        {
            webElement(HomeLink).Click();
            
            
        }

        public void ClickDynamicLnk()
        {
            webElement(DynamicLink).Click();
            
        }

        public void ClickOnCreatedLinks()
        {
            webElement(CreatedLink).Click();
            
        }
        public void ClickOnNoContentLinks()
        {
            webElement(NoContentLink).Click();
            
        }
        public void ClickOnMovedLinks()
        {
            webElement(MovedLink).Click();
            
        }
        public void ClickOnBadRequestLinks()
        {
            webElement(BadRequestLink).Click();
            
        }
        public void ClickOnUnauthorisedLinks()
        {
            webElement(UnAuthorisedLink).Click();
           
        }
        public void ClickOnForbidenLinks()
        {
            webElement(ForbidenLink).Click();
            
        }
        public void ClickOnNotFoundLinks()
        {
            webElement(NotFoundLink).Click();
            
        }

        public string GetResponseMsg()
        {
            return GetTextFromElement(LinksResponse);
            
        }
    }


    
}
