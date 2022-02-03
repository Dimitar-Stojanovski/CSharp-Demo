using NUnit.Framework;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
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


        public static IEnumerable<TestCaseData> ReadContentFromExcelFile()
        {
            string _currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string _sfile = Path.Combine(_currentDirectory, @"..\..\TestData.xlsx");
            string _sfilePath = Path.GetFullPath(_sfile);
            string _fullPath = @"C:\Users\user\source\repos\CSharp-Demo\WebAutomation\Framework\DataProviders\DataForElements\TestData.xlsx";




            using (var sheet = new SLDocument(_fullPath))
            {
                int endRowIndex = sheet.GetWorksheetStatistics().EndRowIndex;

                for (int row = 2; row < endRowIndex; row++)
                {
                    string _fullName = sheet.GetCellValueAsString(row, 1);
                    string _email = sheet.GetCellValueAsString(row, 2);
                    string _address = sheet.GetCellValueAsString(row, 3);
                    string _perAddress = sheet.GetCellValueAsString(row, 4);

                    yield return new TestCaseData(_fullName, _email, _address, _perAddress);
                }
            }
        }

     }





    static class ConstantsForTextBox
    {
        public const string _USER_NAME_TEXTBOX = "Dimitar Stojanovski";
        public const string _EMAIL_TEXTBOX = "dimitar@mail.com";
        public const string _CURRENT_ADDRESS_TEXTBOX = "Address1";
        public const string _PERMANENT_ADDRESS_TEXTBOX = "Address2";

    }

        
}
