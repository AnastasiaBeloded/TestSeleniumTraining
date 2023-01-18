using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestSeleniumTraining.Alerts;
using TestSeleniumTraining.Elements;
using TestSeleniumTraining.Forms;
using TestSeleniumTraining.Widgets;

namespace TestSeleniumTraining
{
    public class Tests
    {

        public IWebDriver driver;
        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        /* [Test]
         public void ElementsTextBoxTest()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu();
             var element = new EMTextBox(driver)
                .FillTextBoxMenu();
             driver.Close();
         }*/
        /* [Test]
         public void ElementsCheckBoxTest()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu();
             var element = new EMCheckBoxMenu(driver)
                   .ChooseCheckBoxMenu()
                   .FillCheckBoxMenu()
                   .tryCheckbox();
             //driver.Close();
         }
         /*[Test]
         public void ElementsRadioButtonMenu()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu();
             var element = new EMRadioButtonMenu(driver)
                  .RadioButton();
         }
         [Test]
         public void ElementsButtonMenu()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu();
             var element = new EMButtonsMenu(driver)
                  .ButtonsMenu();
         }*/
        /*[Test]
        public void ElementsLinksMenu()
        {
            var elements = new ElementsMenu(driver)
                .ChooseElementsMenu();
            var element = new EMLinksMenu(driver)
                .ChooseLinksMenu()
                .ChooseHomeLink()
                .ChooseHomeLink2();
        }*/

        /* [Test]
         public void AlertsModalDialogsMenu()
         {
             var elements = new AlertsMenu(driver)
                 .ChooseAlertsMenu();
             var element = new  AMModalDialogs(driver)
                 .ModalDialogs();
         }*/
        /*[Test]
        public void Alerts()
        {
            var elements = new AlertsMenu(driver)
                .ChooseAlertsMenu();
            var element = new AMAlerts(driver)
               // .ClickButtonToSeeAlert()
                .ClickButtonToSeeAlertAfter5Seconds()
                .ClickButtonToSeeAlertConfirmBox()
                .ClickButtonToSeeAlertBoxWillAppear();
        }*/
        /*[Test]
        public void AlertsBrowserWindow()
        {
            var elements = new AlertsMenu(driver)
                .ChooseAlertsMenu();
            var element = new AMBrowserWindow(driver)
                //.openNewTab();
                .OpenNewWindow();
        }*/
        [Test]
        public void Slider()
        {
            var elements = new WidgetsMenu(driver)
                .openWidgetsMenu();
            var element = new WMSliderMenu(driver)
                .openSliderMenu()
                .MovingSlider();
        }




    [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}

  

