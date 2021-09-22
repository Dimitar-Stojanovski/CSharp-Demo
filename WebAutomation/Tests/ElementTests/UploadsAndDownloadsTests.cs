using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.ElementTests
{
    public class UploadsAndDownloadsTests:BaseTests
    {
        [Test]
        public void ClickDownloadBtn()
        {
            menuItems.ClickOnMenuCard("Elements");
            javaScriptExec.ScrollBy300();
            elementsMenuTabs.ListElementTabs("Upload and Download");
            upploadsAndDownloads.ClickDownloadBtn();
            Thread.Sleep(2000);
        }
        
        [Test]
        public void UploadFile()
        {
            menuItems.ClickOnMenuCard("Elements");
            javaScriptExec.ScrollBy300();
            elementsMenuTabs.ListElementTabs("Upload and Download");
            upploadsAndDownloads.UploadFile();
            Thread.Sleep(2000);
        }

        [Test]
        public void ClickOnUploadBtn()
        {
            menuItems.ClickOnMenuCard("Elements");
            javaScriptExec.ScrollBy300();
            elementsMenuTabs.ListElementTabs("Upload and Download");
            upploadsAndDownloads.ClickToUpload();
            Thread.Sleep(2000);
        }
    }
}
