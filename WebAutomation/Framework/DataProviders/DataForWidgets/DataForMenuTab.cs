using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils.DataProviders.DataForWidgets
{
    public class DataForMenuTab
    {
        public static object[] TestDataForMenuTab =
        {
            new object [] { "Main Item 1" },
            new object [] { "Main Item 2"},
            new object [] { "Main Item 3"},
            
            
           
        };

        public static object[] TestForMainItem2 =
        {
            new object [] { "Sub Item" },
            new object [] { "Sub Item" },
            new object [] { "SUB SUB LIST »" }
        };

        public static object[] TestForSubSubList =
        {
            new object [] { "SUB SUB LIST »","Sub Sub Item 1" },
            new object [] { "SUB SUB LIST »","Sub Sub Item 2" }
        };
    }
}
