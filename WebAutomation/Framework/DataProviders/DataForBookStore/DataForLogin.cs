using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils.DataProviders.DataForBookStore
{
    public class DataForLogin
    {
        

        public static object[] TestDataForLogin =
        {
           /* new object [] { $"{Faker.NameFaker.FirstName()}", $"{Faker.LocationFaker.Country()}"},
            *//*new object [] { Faker.NameFaker.FirstName(), Faker.CompanyFaker.Name()},
            new object [] { Faker.NameFaker.FemaleFirstName(), Faker.InternetFaker.Domain()},
            new object [] {Faker.NameFaker.MaleFirstName(), Faker.LocationFaker.City()}*/

            new object [] {"DimitarS", "Password1"},
            new object [] {"JohnD", "Password2"},
            new object [] {"MichaelD", "Password3"},
        };

        public static object[] TestDataForCreateUser =
        {
            new object [] {"First Name", "Last Name", "UserName", "Password123!"},
            new object [] {"First Name1", "Last Name1", "UserName1", "Password1234!"},
            new object [] {"First Name1", "Last Name2", "UserName2", "Password123!1"}
        };

        public static IEnumerable TestDataWithFaker
        {
            get
            {
                yield return new TestCaseData(Faker.NameFaker.FirstName(), Faker.InternetFaker.Email());
                yield return new TestCaseData(Faker.NameFaker.FirstName(), Faker.InternetFaker.Email());
                yield return new TestCaseData(Faker.NameFaker.FirstName(), Faker.InternetFaker.Email());
            }
        }
    }

    static class ConstantsForLogin
    {
        public const string _INVALID_CREDENTIALS = "Invalid username or password!";
        
    }

    
}
