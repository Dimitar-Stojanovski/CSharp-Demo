using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils.DataProviders.DataForBookStore
{
    public class DataForBookStoreObjects
    {
        public static object[] BookLinks =
        {
            new object [] { "Git Pocket Guide" },
            new object [] { "Learning JavaScript Design Patterns" },
            new object [] { "Designing Evolvable Web APIs with ASP.NET"  },
            new object [] { "Speaking JavaScript" },
            new object [] { "You Don't Know JS" },
            new object [] { "Programming JavaScript Applications" },
            new object [] { "Eloquent JavaScript, Second Edition"},
            new object [] { "Understanding ECMAScript 6" }
        };

        public static IEnumerable DropDownData
        {
            get
            {
                yield return new TestCaseData("5 rows");
                yield return new TestCaseData("10 rows");
                yield return new TestCaseData("20 rows");
                yield return new TestCaseData("25 rows");
                yield return new TestCaseData("50 rows");
                yield return new TestCaseData("100 rows");
            }
        }
    }
}
