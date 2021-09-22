using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Utils.DataProviders
{
     public class DataForTextBox
    {
        public static object[] TextBoxData =
        {
            new object[] {"John Doe", "john@mail.com", "Address1", "PermanentAddress2"},
            new object[] {"Person 1", "person1@mail.com", "Address2", "PermanentAddress2"},
            new object [] {"Person 2", "person2@mail.com", "Address3", "PermanentAddress3"}
            

        };

     }





    static class ConstantsForTextBox
    {
        public const string _USER_NAME_TEXTBOX = "Dimitar Stojanovski";
        public const string _EMAIL_TEXTBOX = "dimitar@mail.com";
        public const string _CURRENT_ADDRESS_TEXTBOX = "Address1";
        public const string _PERMANENT_ADDRESS_TEXTBOX = "Address2";

    }

        
}
