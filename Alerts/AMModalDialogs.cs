using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumTraining.Forms;

namespace TestSeleniumTraining.Alerts
{
    internal class AMModalDialogs
    {
        private IWebDriver driver;
        public AMModalDialogs(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By modalDialogs = By.XPath("//span[normalize-space()='Modal Dialogs']");
        private readonly By smallModal = By.XPath("//button[@id='showSmallModal']");
        private readonly By closeSmallModal = By.CssSelector("#closeSmallModal");
        private readonly By largeModal = By.XPath("//button[@id='showLargeModal']");
        private readonly By closeLargeModal = By.CssSelector("#closeLargeModal");

        public AMModalDialogs ModalDialogs()
        {
            driver.FindElement(modalDialogs).Click();

            driver.FindElement(smallModal).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           
            driver.FindElement(closeSmallModal).Click();

            driver.FindElement(largeModal).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            driver.FindElement(closeLargeModal).Click();


            return this;
        }

    }
    

}
