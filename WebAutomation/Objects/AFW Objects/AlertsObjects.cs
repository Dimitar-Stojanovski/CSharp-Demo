using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;

namespace WebAutomation.Objects.AFW_Objects
{
    public class AlertsObjects:MethodsCollection
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        IAlert alert;
        By _alertBtn = By.Id("alertButton");
        By _timeAlertBtn = By.Id("timerAlertButton");
        By _confirmBtn = By.Id("confirmButton");
        By _promptBtn = By.Id("promtButton");

        public AlertsObjects(IWebDriver driver, WebDriverWait wait, IAlert alert):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.alert = alert;

        }

        public void ClickOnAlertBtn()
        {
            webElement(_alertBtn).Click();
            wait.Until(ExpectedConditions.AlertIsPresent());
            alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void ClickOnTimeAlertBtn()
        {
            webElement(_timeAlertBtn).Click();
            wait.Until(ExpectedConditions.AlertIsPresent());
            alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void ClickOnConfirmAlertBtn()
        {
            webElement(_confirmBtn).Click();
            wait.Until(ExpectedConditions.AlertIsPresent());
            alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        public void ClickOnPromptAlertBtn(string text)
        {
            webElement(_promptBtn).Click();
            wait.Until(ExpectedConditions.AlertIsPresent());
            alert = driver.SwitchTo().Alert();
            alert.SendKeys(text);
            alert.Accept();
        }
    }
}
