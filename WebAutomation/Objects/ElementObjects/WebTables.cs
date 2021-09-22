using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Objects.CustomLocators;
using WebAutomation.Utils;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Utils.CustomLocators;

namespace WebAutomation.Objects
{
    public class WebTables:MethodsCollection
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;
        public WebTables(IWebDriver driver, WebDriverWait wait):base(driver, wait)
        {
            this.driver = driver;
            this.wait = wait;

        }

        By mainHeader = new ClassLoc("main - header");
        By addNewRecordButton = By.Id("addNewRecordButton");
        By firstName = By.Id("firstName");
        By lastName = By.Id("lastName");
        By email = By.Id("userEmail");
        By age = By.Id("age");
        By salary = By.Id("salary");
        By department = By.Id("department");
        By submitButton = By.Id("submit");
        By tableData = new ClassPath("rt-tbody", "/div[4]"); //[@class = 'rt-tbody']/div[4]
        //Index until number 6
        By EditButton = By.Id("edit-record-4");
        By xButton = new ClassLoc("close");     //"//*[@class= 'close']"
        By searchBox = By.Id("searchBox");
        By deleteBtn = new ContainsID("delete");    //"//*[contains(@id, 'delete')]"




        public string GetMainHeader()
        {
            return GetTextFromElement(mainHeader);
          
        }

        public void ClickAddNewBtn()
        {
            webElement(addNewRecordButton).Click();
           
        }

        public void EnterFirstName(string name)
        {
            webElement(firstName).SendKeys(name);
            
        }

        public void EnterLastName(string last_name)
        {
            webElement(lastName).SendKeys(last_name);
           
        }
        public void EnterEmail(string e_mail)
        {
            webElement(email).SendKeys(e_mail);
            
        }
        public void EnterAge(int Age)
        {
            webElement(age).SendKeys(""+Age);
            
        }

        public void EnterSalary(int Salary)
        {
            webElement(salary).SendKeys("" + Salary);
            
        }

        public void EnterDepartment(string Department)
        {
            webElement(department).SendKeys(Department);
            
        }

        public void ClickSubmitBtn()
        {
            webElement(submitButton).Click();
           
        }

        public void ClickEditRecord()
        {
            webElement(EditButton).Click();
            
        }

        public void ClickOnXButton()
        {
            webElement(xButton).Click();
            
        }

        public void ClearLastName()
        {
            webElement(lastName).Clear();
           
        }
        public void ClearFirstName()
        {
            webElement(firstName).Clear();
            
        }

        public void ClearDepartment()
        {
            webElement(department).Clear();
            
        }

        public void ClearEmail()
        {
            webElement(email).Clear();
            
        }

        public void ClearAge()
        {
            webElement(age).Clear();
            
        }

        public void ClearSalary()
        {
            webElement(salary).Clear();
            
        }

        public void EnterSearchBx(string search) 
        {
            webElement(searchBox).SendKeys(search);
            

        }

        public void ClickDeleteBtn()
        {
            webElement(deleteBtn).Click();
           
        }

        public void ClearSearchBox()
        {
            webElement(searchBox).Clear();
            
        }
        

        public string TableContent(int index)
        {
            return wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(tableData))[index].Text;
        }
    }
}
