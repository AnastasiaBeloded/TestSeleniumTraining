using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Elements
{
    internal class EMCheckBoxMenu
    {
        private IWebDriver driver;
        public EMCheckBoxMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By checkBox = By.XPath("//span[normalize-space()='Check Box']");
        private readonly By openHomeMenu = By.CssSelector("button[title='Toggle']");
        private readonly By unCheck = By.CssSelector("svg[class='rct-icon rct-icon-uncheck']");

        public EMCheckBoxMenu ChooseCheckBoxMenu()
        {
            driver.FindElement(checkBox).Click();
            return this;
        }
        public EMCheckBoxMenu FillCheckBoxMenu()
        {
            driver.FindElement(openHomeMenu).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//span[contains(text(),'Desktop')]")).Displayed);

            return this;
        }
        public EMCheckBoxMenu tryCheckbox()
        {
            driver.FindElement(unCheck).Click();
            Assert.IsTrue(driver.FindElement (By.XPath("//span[normalize-space()='You have selected :']")).Displayed);

             
            return this;
        }
    }
}
