using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Elements
{
    internal class EMTextBoxMenu
    {
        public IWebDriver driver;
         
        private readonly By textBox = By.XPath("//span[normalize-space()='Text Box']");
        private readonly By textBoxName = By.CssSelector("#userName");
        private readonly By textBoxEmail = By.CssSelector("#userEmail");
        private readonly By textBoxCurrentAddress = By.CssSelector("#currentAddress");
        private readonly By textBoxPermanentAddress = By.CssSelector("#permanentAddress");
        private readonly By clickOnSubmit = By.CssSelector("#submit");


        public EMTextBoxMenu(IWebDriver driver)
        {
            this.driver = driver;
        }
        public EMTextBoxMenu ChooseTextBoxMenu()
        {
            driver.FindElement(textBox).Click();
            return this;
        }
        public EMTextBoxMenu FillTextBoxMenu()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(textBox).Click();
            driver.FindElement(textBoxName).SendKeys("Winston");
            driver.FindElement(textBoxEmail).SendKeys("winston@gmail.com");
            driver.FindElement(textBoxCurrentAddress).SendKeys("Israel");
            driver.FindElement(textBoxPermanentAddress).SendKeys("USA");
            driver.FindElement(clickOnSubmit).Click();
            Assert.IsTrue(driver.FindElement(By.CssSelector("#name")).Displayed);
            return this;
        }


    }
}
