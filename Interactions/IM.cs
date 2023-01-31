using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumTraining.Forms;

namespace TestSeleniumTraining.Interactions
{
    internal class IM
    {
        private IWebDriver driver;
        public IM(IWebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By selectInteractionsMenu = By.XPath("//div[normalize-space()='Interactions']");

        public IM openInteractionsMenu()
        {
            driver.FindElement(selectInteractionsMenu).Click();
            return this;
        }
    }
}
