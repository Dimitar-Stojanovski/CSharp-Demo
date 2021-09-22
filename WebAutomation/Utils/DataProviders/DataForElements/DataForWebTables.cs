using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils.DataProviders
{
    public  class DataForWebTables
    {
        public static object [] WebTablesData =
        {
            new object [] {"John", "Doe", "JohnDoe@mail.com", 30, 12000, "Banking and Finance" },
            new object [] {"David", "Smith", "Dave@hotmail.com", 45, 30000, "Oracle"},
            new object [] {"Peter", "Corso", "peter.corso@gmail.com", 20, 45000, "Microsoft"}

        };
       
    }

    public class ConstantsForWebTables
    {
       public const string _FIRST_NAME_WT = "Dimitar";
       public const string _LAST_NAME_WT = "Stojanovski";
       public const string _EMAIL_WT = "Dimitar@mail.com";
       public const int _AGE_WT = 30;
       public const int __SALARY_WT = 250000;
       public const string _DEPARTMENT_WT = "Banking And Finance";
    }
}
