using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects.FormObjects
{
    public class PractiseForm:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        private Actions action = null;
        private SelectElement select = null;
        IJavaScriptExecutor js;
        By _practiseFormMenu = By.XPath("//*[contains(@class, 'text')][contains(text(), 'Practice Form')]");
        By _firstName = By.Id("firstName");
        By _lastName = By.Id("lastName");
        By _email = By.Id("userEmail");
        By _radioLoc = new ContainsClass("radio"); 
        By _subjectInput = By.Id("subjectsInput");
        By _checkBoxLoc = new ContainsClass("checkbox");            
        By _mobileNumber = By.Id("userNumber");
        By _datePicker = By.Id("dateOfBirthInput");
        By _month = new ContainsClass("month-select");
        By _year = new ContainsClass("year-select");
        By _day = new ClassPath("react-datepicker__week", "/div");    
        By _currentAddress = By.Id("currentAddress");
        By _uploadFile = By.Id("uploadPicture");
        By _state = new IDPath("react-select-3-input", "/../input");                                   
        By _city = new IDPath("react-select-4-input", "/../input");                                    
        
        By _submitButton = new ContainsClassPath("text-right", "/button");
        By _submitFormElements = new ContainsClassPath("table-hover", "/tbody/tr");                             
        private string[] _buttonTitles = { "Male", "Female", "Other" };
        private string[] _checkboxTitle = { "Sports", "Reading", "Music" };
        private string[] _submitFormTitles = { "Student Name", "Student Email", "Gender", "Mobile", "Date of Birth", "Subjects", "Hobbies", "Picture", "Address", "State and City" };
        private string path = "C:\\Users\\Dimitar.Stojanovski\\Desktop";
        

        public PractiseForm(IWebDriver driver, WebDriverWait wait, Actions action, SelectElement select):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.action = action;
            this.select = select;
            
        }

       
        public void ClickPracFormMenu()
        {
            webElement(_practiseFormMenu).Click();
           

        }
        public void EnterFirstName(string name)
        {
            webElement(_firstName).SendKeys(name);
           
        }
        public void EnterLastName(string lastName)
        {
            webElement(_lastName).SendKeys(lastName);
            
        }
        public void EnterEmail(string email)
        {
            webElement(_email).SendKeys(email);
            
        }

        public void ClickRadioButton(string buttons)
        {
           
            int index = Array.IndexOf(_buttonTitles, buttons);
            webElements(_radioLoc)[index].Click();
            

        }

        public void EnterMobileNumber(double number)
        {
            webElement(_mobileNumber).SendKeys(""+number);
           
        }

        public void EnterDate(string date)
        {
            webElement(_datePicker).SendKeys(date);
            Thread.Sleep(500);
            webElement(_datePicker).SendKeys(Keys.Enter);
            

        }

        public void ClickOnDateField()
        {
            webElement(_datePicker).Click();
            
        }

        public void SelectMonth(string _monthTitles)
        {
           
            select = new SelectElement(webElement(_month));  
            select.SelectByText(_monthTitles);
            
        }

        public void SelectYear(int year)
        {
            select = new SelectElement(webElement(_year)); //wait.Until(ExpectedConditions.ElementIsVisible(_year)
            select.SelectByText(""+year);
        }

        public void SelectDay(int index)
        {
            
            if (index >20 && index<30)
            {
                webElements(_day)[index + 1].Click();
                
            } else if (index > 30)
            {
                webElements(_day)[index].Click();
                
            }
            else
            {
                webElements(_day)[index -1].Click();
               
            }
        }

        public void ClearDateField()
        {
            webElement(_datePicker).Clear();
            
        }

        public void EnterSubject(string subject)
        {
            webElement(_subjectInput).SendKeys(subject);
            
        }

        public void SelectCheckBox(string checkbox)
        {
            int index = Array.IndexOf(_checkboxTitle, checkbox);
            webElements(_checkBoxLoc)[index].Click();
            
        }

        public void UploadPicture()
        {
            webElement(_uploadFile).SendKeys(path);
            

        }

        
        public void EnterCurrentAddress(string address)
        {
            webElement(_currentAddress).SendKeys(address);
            
        }

        public void SelectState(string state)
        {
            webElement(_state).SendKeys(state);
            Thread.Sleep(500);
            action.SendKeys(Keys.Enter);
           
        }

        public void SelectCity(string city)
        {
            action.MoveToElement(webElement(_city)).Click().Perform();
            webElement(_city).SendKeys(city);
            Thread.Sleep(500);
            action.SendKeys(Keys.Enter);
        }

        public void ClickSubmitBtn()
        {
            action.MoveToElement(webElement(_submitButton)).Click().Perform();
            
            
        }


        public string GetSubmissionFormElements(string _titles)
        {
            int index = Array.IndexOf(_submitFormTitles, _titles);
            return wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_submitFormElements))[index].Text;
        }
    }
}
