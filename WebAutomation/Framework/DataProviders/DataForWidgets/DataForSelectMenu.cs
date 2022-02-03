using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils.DataProviders.DataForWidgets
{
    public class DataForSelectMenu
    {
        public static object[] ValueDropDowns =
        {
            new object [] { "Red" },
            new object [] { "Blue" },
            new object [] { "Green" },
            new object [] { "Yellow" },
            new object [] { "Purple" },
            new object [] { "Black" },
            new object [] { "White" },
            new object [] { "Voilet" },
            new object [] { "Indigo" },
            new object [] { "Magenta" },
            new object [] { "Aqua" }
        };

        public static IEnumerable TestCasesForOldyStyle
        {
            get
            {
                yield return new TestCaseData("volvo", "saab");
                yield return new TestCaseData("opel", "audi");

            }
        }

        public static object[] SelectSingleValueDropDownValue =
        {
            new object[] { "Group 1, option 1"},
            new object[] { "Group 1, option 2"},
            new object[] { "Group 2, option 1"},
            new object[] { "A root option" },
            new object[] { "Another root option"}

        };
       
    }
}
