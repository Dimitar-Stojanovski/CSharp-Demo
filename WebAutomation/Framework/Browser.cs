
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Framework
{
    class Browser
    {
        IWebDriver driver;

        public IWebDriver SetUp(string browser) {
            switch (browser) 
            {
                case "chrome":
                   /*var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("--headless");
                    chromeOptions.AddArguments("--window-size=1920,1080");*/
                    driver = new ChromeDriver();
                    break;
                case "gecko":
                    driver = new FirefoxDriver();
                    break;
                case "explorer":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    Console.WriteLine("Unkonwn driver");
                    break;
            }
            return driver;
        
        }
    }
}
