using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WebAutomation.Utils.ActionsMethods
{
    public class Scroll
    {
        private IWebDriver driver = null;
        private Actions action = null;

        public Scroll(IWebDriver driver, Actions action)
        {
            this.driver = driver;
            this.action = action;
        }

        public void ScrollDown(int offsetX, int offsetY )
        {
            action = new Actions(driver);
            action.MoveByOffset(offsetX, offsetY).Build().Perform();
        }
    }
}
