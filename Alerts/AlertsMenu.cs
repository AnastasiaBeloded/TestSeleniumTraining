using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumTraining.Elements;

namespace TestSeleniumTraining.Forms
{
    internal class AlertsMenu
    {
        private IWebDriver driver;
        public AlertsMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By alertsMenu = By.XPath("//div[normalize-space()='Alerts, Frame & Windows']");

        public AlertsMenu ChooseAlertsMenu()
        {
            driver.FindElement(alertsMenu).Click();
            return this;
        }
    }
}
