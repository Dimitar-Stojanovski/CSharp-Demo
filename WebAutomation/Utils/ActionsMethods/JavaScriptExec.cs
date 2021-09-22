using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils.ActionsMethods
{
    public class JavaScriptExec
    {
        IJavaScriptExecutor js;
        IWebDriver driver;

        public JavaScriptExec(IJavaScriptExecutor js, IWebDriver driver)
        {
            this.js = js;
            this.driver = driver;
        }

        public void ScrollBy300()
        {
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,300)");
        }

        public void ScrollBy500()
        {
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
        }

        public void ScrollBy1000()
        {
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        public void ScrollBy800()
        {
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,800)");
        }

        public void ScrollUpBy300()
        {
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 300)");
        }

        public void ScrollUpBy500()
        {
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 500)");
        }

        public void ScrollUpBy1000()
        {
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 1000)");
        }


    }
}
