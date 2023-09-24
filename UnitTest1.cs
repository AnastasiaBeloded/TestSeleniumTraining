using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestSeleniumTraining.Alerts;
using TestSeleniumTraining.Elements;
using TestSeleniumTraining.Forms;
using TestSeleniumTraining.Interactions;
using TestSeleniumTraining.Widgets;

namespace TestSeleniumTraining
{
    [TestFixture]
    //[Parallelizable]
    [Parallelizable(scope: ParallelScope.All)]
    public class Tests:TestBase
    {

         [Test]
         public void ElementsTextBoxTest()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu();
             var element = new EMTextBoxMenu(driver)
                .FillTextBoxMenu();
             driver.Close();
         }
         [Test]
         public void ElementsCheckBoxTest()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu();
             var element = new EMCheckBoxMenu(driver)
                   .ChooseCheckBoxMenu()
                   .FillCheckBoxMenu()
                   .tryCheckbox();
             driver.Close();
         }
         [Test]
         public void ElementsRadioButtonMenu()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu();
             var element = new EMRadioButtonMenu(driver)
                  .RadioButton();
            driver.Close();
        }
         [Test]
         public void ElementsButtonMenu()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu();
             var element = new EMButtonsMenu(driver)
                  .ButtonsMenu();
            driver.Close();
        }
        [Test]
        public void ElementsLinksMenu()
        {
            var elements = new ElementsMenu(driver)
                .ChooseElementsMenu();
            var element = new EMLinksMenu(driver)
                .ChooseLinksMenu()
                .ChooseHomeLink()
                .ChooseHomeLink2();
            driver.Close();
        }

         [Test]
         public void AlertsModalDialogsMenu()
         {
             var elements = new AlertsMenu(driver)
                 .ChooseAlertsMenu();
             var element = new  AMModalDialogs(driver)
                 .ModalDialogs();
            driver.Close();
        }
        
         [Test]
        public void Alerts()
        {
            var elements = new AlertsMenu(driver)
                .ChooseAlertsMenu();
            var element = new AMAlerts(driver)
               // .ClickButtonToSeeAlert()
                .ClickButtonToSeeAlertAfter5Seconds()
                .ClickButtonToSeeAlertConfirmBox()
                .ClickButtonToSeeAlertBoxWillAppear();
            driver.Close();
        }
        [Test]
        public void AlertsBrowserWindow()
        {
            var elements = new AlertsMenu(driver)
                .ChooseAlertsMenu();
            var element = new AMBrowserWindow(driver)
                 .openNewTab()
                .OpenNewWindow();
            driver.Close();
        }
         [Test]
         public void Slider()
         {
             var elements = new WidgetsMenu(driver)
                 .openWidgetsMenu();
             var element = new WMSliderMenu(driver)
                 .openSliderMenu()
                 .MovingSlider();
            driver.Close();
        }
         [Test]
         public void DataPicker()
         {
             var elements = new WidgetsMenu(driver)
                 .openWidgetsMenu();
             var element = new WMDataPicker(driver)
                 .openDatePickerMenu()
                 //.selectAndFillDate()
                 .selectDate();
            driver.Close();
        }
        [Test]
        
        
        public void Interactions()
        {
            var elements = new IM(driver)
                .openInteractionsMenu();
            var element = new IMSelectable(driver)
                .openSelectableMenu()
                .workWithList()
                .workWithGrid();
            driver.Close();

        }



       
    }
}

  

