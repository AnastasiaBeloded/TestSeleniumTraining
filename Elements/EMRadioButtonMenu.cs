using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Elements
{
    internal class EMRadioButtonMenu
    {
        private IWebDriver driver;
        public EMRadioButtonMenu(IWebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By radioButton = By.XPath("//span[normalize-space()='Radio Button']");
        private readonly By radioButtonYes = By.CssSelector("label[for='yesRadio']");
        private readonly By radioButtonImpressive = By.CssSelector("label[for='impressiveRadio']");
        private readonly By radioButtonNo = By.CssSelector("label[for='noRadio']");

        public EMRadioButtonMenu RadioButton()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(radioButton).Click();
            driver.FindElement(radioButtonYes).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//span[normalize-space()='Yes']")).Displayed);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(radioButtonImpressive).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//span[normalize-space()='Impressive']")).Displayed);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(radioButtonNo).Click();

            return this;
        }
    }
}
