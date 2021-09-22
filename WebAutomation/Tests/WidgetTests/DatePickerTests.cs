using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.WidgetTests
{
    public class DatePickerTests:BaseTests
    {
        [Test]
        public void ClickOnDatesInputs()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            widgetMenu.WidgetMenuTabs("Date Picker");
            datePicker.ClickOnDateAndTimePicInput();




        }

        [Test]
        public void SendDataToInputs()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            widgetMenu.WidgetMenuTabs("Date Picker");
            //datePicker.SendDateMonthYearInput("07/07/1991");
            datePicker.SendDateTimeAndHourInput("August 26, 2021, 11:06 AM");
            Thread.Sleep(2000);
        }

        [Test]
        public void PickADateFromSelectDate()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            widgetMenu.WidgetMenuTabs("Date Picker");
            datePicker.ClickOnDatePickerInput();
            datePicker.SelectMonth("July");
            datePicker.SelectYear(1991);
            datePicker.SelectDay(25);
            Thread.Sleep(2000);
        }

        [Test]
        public void PickDateFromReactCombobox()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            widgetMenu.WidgetMenuTabs("Date Picker");
            datePicker.ClickOnDateAndTimePicInput();
            datePicker.SelectMonthFromCombo("August");
            datePicker.SelectYearFromCombo(2022);
            datePicker.SelectTimeFromCombo("00:00");
            Thread.Sleep(2000);
        }
    }
}
