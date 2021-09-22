using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders;


namespace WebAutomation.Tests.ElementTests
{
    public class WebTablesTests:BaseTests
    {
        [TestCaseSource(typeof(DataForWebTables), nameof(DataForWebTables.WebTablesData))]
        public void TestWebTables(string Name, string Last_Name, string Email, int Age, int Salary, string Department)
        {
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Web Tables");
            webTables.ClickAddNewBtn();
            webTables.EnterFirstName(Name);
            webTables.EnterLastName(Last_Name);
            webTables.EnterEmail(Email);
            webTables.EnterAge(Age);
            webTables.EnterSalary(Salary);
            webTables.EnterDepartment(Department);
            webTables.ClickSubmitBtn();
            webTables.ClickEditRecord();
            webTables.ClearFirstName();
            webTables.ClearLastName();
            webTables.ClearDepartment();
            webTables.ClickSubmitBtn();
            webTables.ClickOnXButton();
            webTables.EnterSearchBx(Name);
            Thread.Sleep(2000);
            webTables.ClickDeleteBtn();






        }

        [Test]
        public void PopulateAndEditWebTables()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Elements");
            elementsMenuTabs.ListElementTabs("Web Tables");
            webTables.ClickAddNewBtn();
            webTables.EnterFirstName(ConstantsForWebTables._FIRST_NAME_WT);
            webTables.EnterLastName(ConstantsForWebTables._LAST_NAME_WT);
            webTables.EnterEmail(ConstantsForWebTables._EMAIL_WT);
            webTables.EnterAge(ConstantsForWebTables._AGE_WT);
            webTables.EnterSalary(ConstantsForWebTables.__SALARY_WT);
            webTables.EnterDepartment(ConstantsForWebTables._DEPARTMENT_WT);
            webTables.ClickSubmitBtn();
            webTables.ClickEditRecord();
            webTables.ClearFirstName();
            webTables.ClearLastName();
            webTables.ClearEmail();
            webTables.ClearSalary();
            webTables.ClearAge();
            webTables.ClearDepartment();
            webTables.ClickOnXButton();
            webTables.EnterSearchBx("Alden");
            Thread.Sleep(2000);
            webTables.ClearSearchBox();
           
        }
    }
}
