using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Elements
{
    internal class EMLinksMenu
    {
        public IWebDriver driver;
        public EMLinksMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By links = By.XPath("//span[normalize-space()='Links']");
        private readonly By homeLink = By.CssSelector("#simpleLink");

        public EMLinksMenu ChooseLinksMenu()
        {
            driver.FindElement(links).Click();
            return this;
        }
        public EMLinksMenu ChooseHomeLink()
        {

            
            driver.FindElement(homeLink).Click();

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            //driver.FindElement (By.XPath("//h5[normalize-space()='Elements']"));
            //Assert.IsTrue(driver.FindElement(By.XPath("//h5[normalize-space()='Elements']")).Displayed);
            //driver.Close();
            driver.SwitchTo().NewWindow(WindowType.Tab);
            driver.Close();
            Assert.IsTrue(driver.FindElement(By.XPath("//h5[normalize-space()='Elements']")).Displayed);
            //driver.Navigate().GoToUrl("https://demoqa.com/");

            return this;
        }
    }
}
