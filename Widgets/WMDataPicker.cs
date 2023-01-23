using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestSeleniumTraining.Widgets
{
    internal class WMDataPicker
    {
        private IWebDriver driver;
        public WMDataPicker(IWebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By selectDatePickerMenu = By.XPath("//span[normalize-space()='Date Picker']");
        private readonly By selectDateInput = By.CssSelector("#datePickerMonthYearInput");
        private readonly By selectDatePickerContainer = By.XPath("//div[@class='react-datepicker__month-container']");
        private readonly By selectDatePickerMonthContainer = By.XPath("//select[@class='react-datepicker__month-select']");
        private readonly By selectDatePickerYearContainer = By.XPath("//select[@class='react-datepicker__year-select']");
        private readonly By selectDateListBox = By.XPath("//div[@role='listbox']");

        public WMDataPicker openDatePickerMenu()
        {
            driver.FindElement(selectDatePickerMenu).Click();
            return this;
        }
        public WMDataPicker selectAndFillDate()
        {
            IWebElement selectDateAndSend = driver.FindElement(selectDateInput);
            selectDateAndSend.Click();
            
            selectDateAndSend.SendKeys(Keys.Control+"A"+Keys.Backspace);

            selectDateAndSend.SendKeys("09/01/2025");

            return this;
        }
        public WMDataPicker selectDate()
        {
            driver.FindElement(selectDateInput).Click();
            Thread.Sleep(100);
            driver.FindElement(selectDatePickerMonthContainer).Click();
            Thread.Sleep(100);
            driver.FindElement(By.XPath("//option[@value='11']")).Click();
            Thread.Sleep(100);
            driver.FindElement(selectDatePickerYearContainer).Click();
            Thread.Sleep(100);
            driver.FindElement(By.XPath("//option[@value='2025']")).Click();
            Thread.Sleep(100);
            driver.FindElement (selectDateListBox).Click();
            Thread.Sleep(100);
            driver.FindElement(By.CssSelector("div[class$='react-datepicker__day react-datepicker__day--027 react-datepicker__day--weekend']")).Click() ;



            return this;
        }
    }
}
