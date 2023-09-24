using System;
using TestSeleniumTraining.Alerts;
using TestSeleniumTraining.Forms;

namespace TestSeleniumTraining
{
    [TestFixture]
    // [Parallelizable]
    [Parallelizable(scope: ParallelScope.All)]
    public class Tests1:TestBase
	{
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
        public void AlertsModalDialogsMenu()
        {
            var elements = new AlertsMenu(driver)
                .ChooseAlertsMenu();
            var element = new AMModalDialogs(driver)
                .ModalDialogs();
            driver.Close();
        }
    }
}

