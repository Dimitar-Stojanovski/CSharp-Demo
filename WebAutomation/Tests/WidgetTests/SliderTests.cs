using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebAutomation.Tests.WidgetTests
{
    public class SliderTests:BaseTests
    {
        [Test]
        public void MoveSlider()
        {
            javaScriptExec.ScrollBy300();
            menuItems.ClickOnMenuCard("Widgets");
            javaScriptExec.ScrollBy300();
            widgetMenu.WidgetMenuTabs("Slider");
            slider.CheckSizeOfSlider();
            slider.MoveSlider(200, 300);
            Thread.Sleep(2000);
        }
    }
}
