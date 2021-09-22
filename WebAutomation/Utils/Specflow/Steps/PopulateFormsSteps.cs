using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using TechTalk.SpecFlow;
using WebAutomation.Objects.FormObjects;
using OpenQA.Selenium.Interactions;

namespace WebAutomation.Utils.Specflow.Steps
{
    [Binding]
    public class PopulateFormsSteps
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;
        private SelectElement select = null;
        private PractiseForm practiseForm;
        

        public PopulateFormsSteps(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            practiseForm = new PractiseForm(driver, wait, action, select);
            
        }

        [Given(@"enter first name ""(.*)""")]
        public void GivenEnterFirstName(string _name)
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            practiseForm.EnterFirstName(_name);
        }
        
        [Given(@"enter last name ""(.*)""")]
        public void GivenEnterLastName(string _lastName)
        {
            practiseForm.EnterLastName(_lastName);
        }
        
        [When(@"enter email address ""(.*)""")]
        public void WhenEnterEmailAddress(string _mail)
        {
            practiseForm.EnterEmail(_mail);
        }
        
        [Then(@"I want to select gender")]
        public void ThenIWantToSelectGender()
        {
            practiseForm.ClickRadioButton("Male");
        }
    }
}
