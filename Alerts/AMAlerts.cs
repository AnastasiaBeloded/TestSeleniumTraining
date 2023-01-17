using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Alerts
{
    internal class AMAlerts
    {
        private IWebDriver driver;
        public AMAlerts(IWebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By alerts = By.XPath("//span[normalize-space()='Alerts']");
        private readonly By clickMe1 = By.CssSelector("#alertButton");
        private readonly By clickMe2 = By.CssSelector("#timerAlertButton");
        private readonly By clickMe3 = By.CssSelector("#confirmButton");
        private readonly By clickMe4 = By.CssSelector("#promtButton");

        public AMAlerts ClickButtonToSeeAlert()
        {
            driver.FindElement(alerts).Click();
            driver.FindElement(clickMe1).Click();
            IAlert alert = driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Accept();
            return this;
        }
        public AMAlerts ClickButtonToSeeAlertAfter5Seconds() {
            driver.FindElement(alerts).Click();
            driver.FindElement(clickMe2).Click();
            bool IsAlertShown(WebDriver driver)
            {
                try
                {
                    driver.SwitchTo().Alert();
                }catch(NoAlertPresentException e)
                {
                    return false;
                }return true;
            }

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(drv => IsAlertShown((WebDriver)drv));
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            return this;
        }

        private void IsAlertShown(IWebDriver drv)
        {
            throw new NotImplementedException();
        }

        public AMAlerts ClickButtonToSeeAlertConfirmBox()
        {
            driver.FindElement(alerts).Click();
            driver.FindElement(clickMe3).Click();
            IAlert alert = driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Accept();
            Assert.IsTrue(driver.FindElement(By.CssSelector("#confirmResult")).Displayed);

            driver.FindElement(clickMe3).Click();
            IAlert alert1 = driver.SwitchTo().Alert();
            string text2 = alert.Text;
            alert.Dismiss();


            return this;

        }
        public AMAlerts ClickButtonToSeeAlertBoxWillAppear()
        {
            driver.FindElement(alerts).Click();
            driver.FindElement(clickMe4).Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys("Winston");
            alert.Accept();
            Assert.IsTrue(driver.FindElement(By.CssSelector("#promtButton")).Displayed);

            return this;
        }
    }
}
