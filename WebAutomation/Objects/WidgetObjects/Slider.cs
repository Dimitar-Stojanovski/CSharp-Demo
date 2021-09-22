using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using WebAutomation.Utils;
using WebAutomation.Utils.CustomLocators;
using System.Threading;
using System;

namespace WebAutomation.Objects.WidgetObjects
{
    public class Slider:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;
        By _sliderBtn = new ContainsClass("slider--primary");

        public Slider(IWebDriver driver, WebDriverWait wait, Actions action):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
        }

        public void MoveSlider(int offsetX, int offsetY)
        {
            /* int sliderWidth = webElement(_sliderBtn).Size.Width;
             xcord = webElement(_sliderBtn).Location.X;*/
            //action.DragAndDropToOffset(webElement(_sliderBtn), offsetX, offsetY).Build().Perform();
            //action.DragAndDropToOffset(webElement(_sliderBtn), xcord + sliderWidth, 0).Build().Perform();
            action.DragAndDropToOffset(webElement(_sliderBtn), offsetX, offsetY).Build().Perform();
           
            
        }

        public void CheckSizeOfSlider()
        {
            int sizeWidth = webElement(_sliderBtn).Size.Width;
            Console.WriteLine(sizeWidth);
        }
    }
}
