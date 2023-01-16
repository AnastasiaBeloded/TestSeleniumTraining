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
        public ElementsMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ElementsMenu ChooseElementsMenu()
        {
            driver.FindElement(mainMenu).Click();
            return this;
        }
       
      
        }
  
    }

