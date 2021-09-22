using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects.ElementObjects
{
    public class UpploadsAndDownloads:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        By _downloadBtn = By.Id("downloadButton");
        By _chooseFile = By.Id("uploadFile");
        By _chooseFileClick = new ClassLoc("form-file-label");
        private string _filePath = "C:\\Users\\Dimitar.Stojanovski\\Desktop\\Capture.JPG";

        public UpploadsAndDownloads(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ClickDownloadBtn()
        {
            webElement(_downloadBtn).Click();
            
        }

        public void UploadFile()
        {
            webElement(_downloadBtn).SendKeys(_filePath);
            
        }

        public void ClickToUpload()
        {
            webElement(_chooseFileClick).Click();
           
        }
    }
}
