using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Elements
{
    internal class ElementsMenu
    {
       private IWebDriver driver;

        private readonly By mainMenu = By.XPath("//h5[normalize-space()='Elements']");
        private readonly By textBox = By.XPath("//span[normalize-space()='Text Box']");
        private readonly By textBoxName = By.CssSelector("#userName");
        private readonly By textBoxEmail = By.CssSelector("#userEmail");
        private readonly By textBoxCurrentAddress = By.CssSelector("#currentAddress");
        private readonly By textBoxPermanentAddress = By.CssSelector("#permanentAddress");
        private readonly By clickOnSubmit = By.CssSelector("#submit");


        private readonly By checkBox = By.XPath("//span[normalize-space()='Check Box']");
        private readonly By openHomeMenu = By.CssSelector("button[title='Toggle']");

        private readonly By radioButton = By.XPath("//span[normalize-space()='Radio Button']");
        private readonly By radioButtonYes = By.CssSelector("label[for='yesRadio']");
        private readonly By radioButtonImpressive = By.CssSelector("label[for='impressiveRadio']");
        private readonly By radioButtonNo = By.CssSelector("label[for='noRadio']");

        private readonly By buttonsMenu = By.XPath("//span[normalize-space()='Buttons']");
        private readonly By doubleClick = By.CssSelector("#doubleClickBtn");
        private readonly By rightClick = By.CssSelector("#rightClickBtn");
        private readonly By ClickMe = By.XPath("(//button[normalize-space()='Click Me'])[1]");

        public ElementsMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ElementsMenu ChooseElementsMenu()
        {
            driver.FindElement(mainMenu).Click();
            return this;
        }
        public ElementsMenu ChooseTextBoxMenu()
        {
            driver.FindElement(textBox).Click();
            return this;
        }
        public ElementsMenu FillTextBoxMenu()
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
        public ElementsMenu ChooseCheckBoxMenu()
        {
            driver.FindElement(checkBox).Click();
            return this;
        }
        public ElementsMenu FillCheckBoxMenu()
        {
            driver.FindElement(openHomeMenu).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//span[contains(text(),'Desktop')]")).Displayed);

            return this;
        }
        public ElementsMenu RadioButton()
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
        public ElementsMenu ButtonsMenu()
        {
            driver.FindElement(buttonsMenu).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Actions actionsDoubleClick = new Actions(driver);
            actionsDoubleClick.DoubleClick(driver.FindElement(doubleClick)).Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(driver.FindElement(By.CssSelector("#doubleClickMessage")).Displayed);
            return this;

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
