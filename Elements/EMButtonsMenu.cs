using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Elements
{
    internal class EMButtonsMenu
    {
        private IWebDriver driver;

        public EMButtonsMenu(IWebDriver driver)
        {
            this.driver = driver;
        }


        private readonly By buttonsMenu = By.XPath("//span[normalize-space()='Buttons']");
        private readonly By doubleClick = By.CssSelector("#doubleClickBtn");
        private readonly By rightClick = By.CssSelector("#rightClickBtn");
        private readonly By ClickMe = By.XPath("(//button[normalize-space()='Click Me'])[1]");



        public EMButtonsMenu ButtonsMenu()
        {
            driver.FindElement(buttonsMenu).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Actions actionsDoubleClick = new Actions(driver);
            actionsDoubleClick.DoubleClick(driver.FindElement(doubleClick)).Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(driver.FindElement(By.CssSelector("#doubleClickMessage")).Displayed);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions actionsRightClickMe = new Actions(driver);
            actionsRightClickMe.ContextClick(driver.FindElement(rightClick)).Perform();
            Assert.IsTrue(driver.FindElement(By.CssSelector("#rightClickMessage")).Displayed);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(ClickMe).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(driver.FindElement(By.CssSelector("#dynamicClickMessage")).Displayed);

            return this;
        }
    }
}
