using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils.DataProviders
{
    public class DataForForms
    {
        public static object[] TestDataForForms =
        {
            new object [] {"John", "Doe", "John@mail.com", "Male", 1234567890, "01 Jan 2019", "Subject1", "Sports", "CR1", "NCR", "Gurgaon"},
            new object [] {"Barbara", "Doe", "barbara@mail.com", "Female", 1234567890, "03 Mar 2019", "Subject2", "Reading", "CR2", "Haryana", "Karnal"},
            new object [] {"Steve", "Doe", "Steve@mail.com", "Other", 1234567890, "06 Sep 2019", "Subject3", "Music", "CR3", "Uttar Pradesh", "Agra"}

        };

       public static IEnumerable TestDataForForms2
        {
            get
            {
                yield return new TestCaseData("Dimitar", "Stojanovski", "mail@mail.com", "Male", 1234567890, "August", 2021, 31, "Subject1", "Sports", "Reading", "CR1", "NCR", "Gurgaon");
                yield return new TestCaseData("Name", "Last Name", "mail@mail.com", "Female", 1234567890, "September", 1986, 18, "Subject1", "Reading", "Music", "CR2", "Haryana", "Karnal");
                yield return new TestCaseData("Name2", "Last Name2", "mail2@mail.com", "Other", 1234567890, "January", 2004, 5, "Subject3", "Reading", "Music", "CR2", "Uttar Pradesh", "Lucknow");
            }
        }
    }

    static class ConstantsForForms
    {
        public const string _FIRST_NAME_PF = "Dimitar";
        public const string _LAST_NAME_PF = "Stojanovski";
        public const string _EMAIL_PF = "dimitar@mail.com";
        public const string _GENDER_PF = "Male";
        public const double _MOBILE_NUMBER_PF = 1234567890;
        public const string _DATE_OF_BIRTH_PF = "07 07 1991";
        public const string _SUBJECT_PF = "Testing Automation";
        public const string _HOBBIES_PF = "Reading";
        public const string _CURRENT_ADDRESS_PF = "Address 1";
        public const string _STATE_PF = "NCR";
        public const string _CITY_PF = "Noida";
    }
}
