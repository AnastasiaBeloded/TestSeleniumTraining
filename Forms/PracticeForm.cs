using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Forms
{
    internal class PracticeForm
    {
        private IWebDriver driver;
        public PracticeForm(IWebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By selectPracticeForm = By.XPath("//span[normalize-space()='Practice Form']");
        private readonly By fillName = By.CssSelector("#firstName");
        private readonly By fillLastName = By.CssSelector("#lastName");
        private readonly By fillEmail = By.CssSelector("#userEmail");
        private readonly By fillGender = By.XPath("//label[normalize-space()='Female']");
        private readonly By fillNumber = By.CssSelector("#userNumber");
        private readonly By fillDateOfBirth = By.CssSelector("#dateOfBirthInput");
        private readonly By fillSubjects = By.CssSelector("");
        private readonly By fillHobbies = By.XPath("//label[normalize-space()='Sports']");
        


        private PracticeForm openMenu()
        {
            driver.FindElement(selectPracticeForm).Click();
            return this;
        }
        private PracticeForm fillForm() {
            return this; 
        }

    }
    
}
