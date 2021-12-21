using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Text;
using WebAutomation.Framework;
using NUnit;
using NUnit.Framework;

using OpenQA.Selenium.Support.UI;
using WebAutomation.Objects;
using OpenQA.Selenium.Interactions;
using WebAutomation.Utils;
using WebAutomation.Objects.FormObjects;
using WebAutomation.Utils.ActionsMethods;
using WebAutomation.Objects.WidgetObjects;
using WebAutomation.Objects.ElementObjects;
using WebAutomation.Objects.AFW_Objects;
using WebAutomation.Objects.InteractionObjects;
using WebAutomation.Objects.BookStoreAppObjects;
using System.Configuration;


namespace WebAutomation.Tests
{  
    public  class BaseTests
    {
        
        public IWebDriver driver;
        public WebDriverWait wait;
       
        public string ChromeBrs = "chrome";
        public string FirefoxBrs = "gecko";
        public string IExplorBrs = "explorer";
        public string url = "https://demoqa.com/";
        public string URL = ConfigurationManager.AppSettings["URL"];


        public Actions action;
        public IAlert alert;
        public IJavaScriptExecutor js;
        public SelectElement select;
        Browser browser;
        
        public TextBox textBox;
        public CheckBox checkBox;
        public MenuItems menuItems;
        public ElementsMenuTabs elementsMenuTabs;
        public RadioButtons radioButtons;
        public WebTables webTables;
        public Buttons buttons;
        public Links links;
        public PractiseForm practiseForm;
        public JavaScriptExec javaScriptExec;
        public WidgetsMenuItems widgetMenu;
        public WidgetTabs widgetTabs;
        public WidgetAccordian widgetAccordian;
        public BrokenLinks brokenLinks;
        public AFWMenuItems aFWMenuItems;
        public InteractionMenuItems interactionMenuItems;
        public BookStoreTabs bookStoreTabs;
        public UpploadsAndDownloads upploadsAndDownloads;
        public DynamicProporties dynamicProporties;
        public BrowserWindows browserWindows;
        public AlertsObjects alertsObjects;
        public ModalDialogs modalDialogs;
        public FramesObject framesObject;
        public DatePicker datePicker;
        public ProgressBarObject progressBar;
        public ToolTipObjects toolTip;
        public MenuObject menuObject;
        public SelectMenuObjects selectMenuObjects;
        public SortableObjects sortable;
        public SelectableObject selectable;
        public DroppableObjects droppable;
        public DraggableObjects draggable;
        public LoginObjects login;
        public BookStoreObjects bookStore;
        public ProfileObjects profile;
        public NestedFrames nestedFrames;
        public AutoCompleteObject autoCompleteObject;
        public Slider slider;
        public Scroll scroll;
        

        [SetUp]

        public void Initiate()
        {
            
            browser = new Browser();
            driver = browser.SetUp(this.ChromeBrs);
            action = new Actions(driver);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            
            textBox = new TextBox(driver , wait, action);
            checkBox = new CheckBox(driver, wait);
            menuItems = new MenuItems(driver, wait);
            elementsMenuTabs = new ElementsMenuTabs(driver, wait);
            radioButtons = new RadioButtons(driver, wait);
            webTables = new WebTables(driver, wait);
            buttons = new Buttons(driver, wait, action);
            links = new Links(driver, wait);
            practiseForm = new PractiseForm(driver, wait, action, select);
            javaScriptExec = new JavaScriptExec(js, driver);
            widgetMenu = new WidgetsMenuItems(driver, wait);
            widgetTabs = new WidgetTabs(driver, wait);
            widgetAccordian = new WidgetAccordian(driver, wait);
            brokenLinks = new BrokenLinks(driver, wait);
            aFWMenuItems = new AFWMenuItems(driver, wait);
            interactionMenuItems = new InteractionMenuItems(driver, wait, action);
            bookStoreTabs = new BookStoreTabs(driver, wait);
            upploadsAndDownloads = new UpploadsAndDownloads(driver, wait);
            dynamicProporties = new DynamicProporties(driver, wait);
            browserWindows = new BrowserWindows(driver, wait, action);
            alertsObjects = new AlertsObjects(driver, wait, alert);
            modalDialogs = new ModalDialogs(driver, wait, alert);
            framesObject = new FramesObject(driver, wait);
            datePicker = new DatePicker(driver, wait, action, select, js);
            progressBar = new ProgressBarObject(driver, wait);
            toolTip = new ToolTipObjects(driver, wait, action);
            menuObject = new MenuObject(driver, wait, action);
            selectMenuObjects = new SelectMenuObjects(driver, wait, select, action);
            sortable = new SortableObjects(driver, wait);
            selectable = new SelectableObject(driver, wait);
            droppable = new DroppableObjects(driver, wait, action);
            draggable = new DraggableObjects(driver, wait);
            login = new LoginObjects(driver, wait, action);
            bookStore = new BookStoreObjects(driver, wait, select);
            profile = new ProfileObjects(driver, wait);
            nestedFrames = new NestedFrames(driver, wait);
            autoCompleteObject = new AutoCompleteObject(driver, wait, action);
            slider = new Slider(driver, wait, action);
            scroll = new Scroll(driver, action);
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        

       

        
    }
}
