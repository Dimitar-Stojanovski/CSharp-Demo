using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders;

namespace WebAutomation.Tests
{
    public class PractiseFormTest:BaseTests 
    {
        [TestCaseSource(typeof(DataForForms), nameof(DataForForms.TestDataForForms))]
        public void EnterPractiseForm(string firstName, string lastName, string email, string gender, int number, string date, string subject,  string hobbies
            , string currentAddress, string state, string city)
        {
            Assert.Multiple(() =>
            {

                javaScriptExec.ScrollBy300();
                menuItems.ClickOnMenuCard("Forms");
                practiseForm.ClickPracFormMenu();
                practiseForm.EnterFirstName(firstName);
                practiseForm.EnterLastName(lastName);
                practiseForm.EnterEmail(email);
                practiseForm.ClickRadioButton(gender);
                practiseForm.EnterMobileNumber(number);
                practiseForm.EnterDate(date);
                practiseForm.EnterSubject(subject);
                practiseForm.SelectCheckBox(hobbies);
                practiseForm.UploadPicture();
                javaScriptExec.ScrollBy300();
                practiseForm.EnterCurrentAddress(currentAddress);
                practiseForm.SelectState(state);
                practiseForm.SelectCity(city);
                practiseForm.ClickSubmitBtn();



                Assert.AreEqual(practiseForm.GetSubmissionFormElements("Student Name"), "Student Name" + " " + firstName + " " + lastName);
                Assert.AreEqual(practiseForm.GetSubmissionFormElements("Student Email"), "Student Email" + " " + email);
                Assert.AreEqual(practiseForm.GetSubmissionFormElements("Gender"), "Gender" + " " + gender);
                Assert.AreEqual(practiseForm.GetSubmissionFormElements("Mobile"), "Mobile" + " " + number);
                //Assert.AreEqual(practiseForm.GetSubmissionFormElements("Date of Birth"), "Date of Birth" + " " + date);
                Assert.AreEqual(practiseForm.GetSubmissionFormElements("Hobbies"), "Hobbies" + " " + hobbies);
                Assert.AreEqual(practiseForm.GetSubmissionFormElements("Address"), "Address" + " " + currentAddress);
                Assert.AreEqual(practiseForm.GetSubmissionFormElements("State and City"), "State and City" + " " + state + " " + city);


            });
        }

        [Test]
        public void PopulatePractiseForm()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Forms");
            practiseForm.ClickPracFormMenu();
            practiseForm.EnterFirstName(ConstantsForForms._FIRST_NAME_PF);
            practiseForm.EnterLastName(ConstantsForForms._LAST_NAME_PF);
            practiseForm.EnterEmail(ConstantsForForms._EMAIL_PF);
            practiseForm.ClickRadioButton(ConstantsForForms._GENDER_PF);
            practiseForm.EnterMobileNumber(ConstantsForForms._MOBILE_NUMBER_PF);
            practiseForm.EnterDate(ConstantsForForms._DATE_OF_BIRTH_PF);
            practiseForm.EnterSubject(ConstantsForForms._SUBJECT_PF);
            practiseForm.SelectCheckBox(ConstantsForForms._HOBBIES_PF);
            Thread.Sleep(2000);
            javaScriptExec.ScrollBy300();
            practiseForm.EnterCurrentAddress(ConstantsForForms._CURRENT_ADDRESS_PF);
            practiseForm.SelectState(ConstantsForForms._STATE_PF);

            practiseForm.SelectCity(ConstantsForForms._CITY_PF);
            practiseForm.ClickSubmitBtn();

            Assert.AreEqual(practiseForm.GetSubmissionFormElements("Student Name"), "Student Name" + " " +ConstantsForForms._FIRST_NAME_PF+ " " + ConstantsForForms._LAST_NAME_PF);
            Assert.AreEqual(practiseForm.GetSubmissionFormElements("Student Email"), "Student Email" + " " + ConstantsForForms._EMAIL_PF);
            Assert.AreEqual(practiseForm.GetSubmissionFormElements("Gender"), "Gender" + " " + ConstantsForForms._GENDER_PF);
            Assert.AreEqual(practiseForm.GetSubmissionFormElements("Mobile"), "Mobile" + " " + ConstantsForForms._MOBILE_NUMBER_PF);
            Assert.AreEqual(practiseForm.GetSubmissionFormElements("Hobbies"), "Hobbies" + " " + ConstantsForForms._HOBBIES_PF);
            Assert.AreEqual(practiseForm.GetSubmissionFormElements("Address"), "Address" + " " + ConstantsForForms._CURRENT_ADDRESS_PF);
            Assert.AreEqual(practiseForm.GetSubmissionFormElements("State and City"), "State and City" + " " + ConstantsForForms._STATE_PF + " " + ConstantsForForms._CITY_PF);

        }

        [TestCaseSource(typeof(DataForForms), nameof(DataForForms.TestDataForForms2))]
        public void PopulatePractiseFormWithCorrectDate(string _name, string _last_name, string _email, string _gender, int _mobileNumber, string _month,
           int _year, int _day, string _subject, string _hobbies1, string _hobbies2, string _currentAddress, string _state, string _city )
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Forms");
            practiseForm.ClickPracFormMenu();
            practiseForm.EnterFirstName(_name);
            practiseForm.EnterLastName(_last_name);
            practiseForm.EnterEmail(_email);
            practiseForm.ClickRadioButton(_gender);
            practiseForm.EnterMobileNumber(_mobileNumber);
            practiseForm.ClickOnDateField();
            practiseForm.SelectMonth(_month);
            practiseForm.SelectYear(_year);
            practiseForm.SelectDay(_day);
            practiseForm.EnterSubject(_subject);
            practiseForm.SelectCheckBox(_hobbies1);
            practiseForm.SelectCheckBox(_hobbies2);
            javaScriptExec.ScrollBy300();
            practiseForm.EnterCurrentAddress(_currentAddress);
            practiseForm.SelectState(_state);
            practiseForm.SelectCity(_city);
            practiseForm.ClickSubmitBtn();
            Thread.Sleep(2000);



        }



    }
}
