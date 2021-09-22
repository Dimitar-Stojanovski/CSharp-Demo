using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebAutomation.Utils.DataProviders.DataForWidgets;

namespace WebAutomation.Tests.WidgetTests
{
    
    public class SelectMenuTests : BaseTests
    {
        [Test]
        public void ClickOnDropDowns()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.ClickOnValueDropDown();
            selectMenuObjects.ClickOnOneDropDown();
            selectMenuObjects.ClickOnOldStyleDropDown();
            selectMenuObjects.ClickOnMultySelectDropDown();
            javaScriptExec.ScrollBy300();
            selectMenuObjects.ClickOnOldStyleMultySelectDropDown();


        }

        [TestCase("Group 1, option1")]
        [TestCase("Group 1, option2")]
        [TestCase("A root option")]
        public void PopulateSelectValueDropDown(string _value)
        {
            javaScriptExec.ScrollBy500();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.PopulateSelectValueDropDown(_value);
            Thread.Sleep(2000);
        }
        [Test]
        public void PopulateSelectOneValueDropDownFromData()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.PopulateOldStyleDropDownWithIndex("Blue");
            Thread.Sleep(1000);
        }

        [TestCase("Dr")]
        [TestCase("Mr")]
        [TestCase("Mrs")]
        [TestCase("Ms")]
        [TestCase("Prof")]
        [TestCase("Othe")]
        public void PopulateSelectOneValueDrop(string _value)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.PopulateSelectOneValueDropDown(_value);
            Thread.Sleep(2000);
        }

        [TestCaseSource(typeof(DataForSelectMenu), nameof(DataForSelectMenu.ValueDropDowns))]
        public void ClickOnValuesFromOldStyleDrop(string _values)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.PopulateOldStyleDropDownValues(_values);
            Thread.Sleep(2000);

        }

        [TestCaseSource(typeof(DataForSelectMenu), nameof(DataForSelectMenu.ValueDropDowns))]
        public void SelectOldStyleDropDownWithIndex(string _values)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.PopulateOldStyleDropDownWithIndex(_values);
            Thread.Sleep(1000);
        }

        [TestCaseSource(typeof(DataForSelectMenu), nameof(DataForSelectMenu.SelectSingleValueDropDownValue))]
        public void PopulateMultiSelectDropDown(string _value)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.PopulateSelectValueDropDown(_value);
            Thread.Sleep(1000);
        }

        [TestCase("volvo", "saab", "opel", "audi")]
        public void ClickOnOldStyleMulValuesDropdown(string _volvo, string _saab, string _opel, string _audi)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.PopulateStandartMultiSelectDropdown(_volvo);
            selectMenuObjects.PopulateStandartMultiSelectDropdown(_saab);
            selectMenuObjects.PopulateStandartMultiSelectDropdown(_opel);
            selectMenuObjects.PopulateStandartMultiSelectDropdown(_audi);
            Thread.Sleep(2000);
        }

        [TestCaseSource(typeof(DataForSelectMenu), nameof(DataForSelectMenu.TestCasesForOldyStyle))]
        public void PopuladeOldStyleWithIEnumerable(string _car1, string _car2)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            javaScriptExec.ScrollBy300();
            selectMenuObjects.PopulateStandartMultiSelectDropdown(_car1);
            selectMenuObjects.PopulateStandartMultiSelectDropdown(_car2);
            Thread.Sleep(2000);
        }
        
        [Test]
        public void PopulateAndClearMultiSelect()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Select Menu");
            selectMenuObjects.PopulateMultiSelectDropDown();
            selectMenuObjects.ClearMultSelectDropDownValues();
            selectMenuObjects.ClearMultSelectDropDownValues();
            selectMenuObjects.ClearMultSelectDropDownValues();
            selectMenuObjects.ClearMultSelectDropDownValues();
            Thread.Sleep(1000);
        }
    }
}
