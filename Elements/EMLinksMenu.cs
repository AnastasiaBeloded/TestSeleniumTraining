using OpenQA.Selenium;


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
        private readonly By homeLink2 = By.CssSelector("#dynamicLink");

        public EMLinksMenu ChooseLinksMenu()
        {
            driver.FindElement(links).Click();
            return this;
        }
        public EMLinksMenu ChooseHomeLink()
        {
            
            driver.FindElement(homeLink).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Assert.IsTrue(driver.FindElement(By.XPath("//h5[normalize-space()='Elements']")).Displayed);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            return this;
  }
        public EMLinksMenu ChooseHomeLink2()
        {
            driver.FindElement(homeLink2).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Assert.IsTrue(driver.FindElement(By.XPath("//h5[normalize-space()='Elements']")).Displayed);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            return this;
        }

        }
        
    }

