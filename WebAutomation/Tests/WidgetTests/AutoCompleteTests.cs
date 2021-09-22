
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.WidgetTests
{
    public class AutoCompleteTests:BaseTests
    {
        [Test]
        public void PopulateTheAutoCompleteInputs()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            widgetMenu.WidgetMenuTabs("Auto Complete");
            
            autoCompleteObject.PopulateMultiColourInput("Green");
            autoCompleteObject.PopulateMultiColourInput("Yellow");
            autoCompleteObject.PopulateMultiColourInput("Black");
            autoCompleteObject.PopulateSingleColourInput("Red");
            Thread.Sleep(2000);

        }

        [Test]
        public void PopulateAutoCompleteInputsWithVariables()
        {   
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            widgetMenu.WidgetMenuTabs("Auto Complete");
            autoCompleteObject.PopulateMultiColourWithDataFromArray();
            autoCompleteObject.PopulateSingleColourInput("Brown");
            Thread.Sleep(2000);

        }


        [TestCase("Black", "Yellow", "Green", "Indigo", "Blue")]
        [TestCase("Green", "Yellow", "Black", "Purple", "Red")]
        [TestCase("Green", "Yellow", "Black", "Green", "Purple")]
        public void PopulateCombobox(string _colour, string _colour2, string _colour3, string _colour4, string _colour5)
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            widgetMenu.WidgetMenuTabs("Auto Complete");
            autoCompleteObject.PopulateMultiColourInput(_colour);
            autoCompleteObject.PopulateMultiColourInput(_colour2);
            autoCompleteObject.PopulateMultiColourInput(_colour3);
            autoCompleteObject.PopulateMultiColourInput(_colour4);
            autoCompleteObject.PopulateMultiColourInput(_colour5);
            autoCompleteObject.PopulateSingleColourInput("Brown");
        }
    }
}
