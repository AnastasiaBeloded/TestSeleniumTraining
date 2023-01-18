using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Widgets
{
    internal class WidgetsMenu
    {
        private IWebDriver driver;

        private readonly By widgetsMenu = By.XPath("//div[normalize-space()='Widgets']");
        public WidgetsMenu(IWebDriver driver)
        {
            this.driver = driver;
        }
            
    public WidgetsMenu openWidgetsMenu()
        {
            driver.FindElement(widgetsMenu).Click();
            return this;
        }

    }
}
