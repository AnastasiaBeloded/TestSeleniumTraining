using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Alerts
{
    internal class AMBrowserWindow
    {
        private IWebDriver driver;
        private object wait;

        public AMBrowserWindow(IWebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By browserWindow = By.XPath("//span[normalize-space()='Browser Windows']");
        private readonly By newTab = By.XPath("//button[@id='tabButton']");
        private readonly By newWindow = By.CssSelector("#windowButton");

        public AMBrowserWindow openNewTab()
        {
            driver.FindElement(browserWindow).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.Sleep(1000);
            driver.FindElement(newTab).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Close();
            return this;
        }
        public AMBrowserWindow OpenNewWindow()
        {
            driver.FindElement(browserWindow).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(newWindow).Click();
            Thread.Sleep(1000);
            string originalWindow = driver.CurrentWindowHandle;
          //  Assert.AreEqual(driver.WindowHandles.Count, 1);
           // driver.FindElement(newWindow).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.WindowHandles.Count == 2);
            Thread.Sleep(1000);
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }

            driver.Close();
            return this;
        }
    }
}
    
    

