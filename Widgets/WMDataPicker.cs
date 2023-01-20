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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(selectDateInput).Click();
            //IWebElement e = driver.FindElement(selectDatePickerContainer);
            

            IWebElement m = driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));

            Select s = new Select(m);
            s.SelectByVisibleText("Jan");
          //  Thread.Sleep(1000);
            // select day
           /* driver.findElement(By.xpath("//td[not(contains(@class,'ui−datepicker− month'))]/a[text()='" + frdate + "']")).click();
            Thread.sleep(1000);
            // choose to date
            driver.findElement(By.xpath("//input[@id='to']")).click();
            Thread.sleep(1000);
            // choose month from dropdown
            WebElement n = driver
            .findElement(By.xpath("//div/select[@class='ui− datepicker−month']"));
            Select sel = new Select(n);
            sel.selectByVisibleText("Feb");
            Thread.sleep(1000);
            // select day
            driver.findElement(By.xpath("//td[not(contains(@class,'ui−datepicker− month'))]/a[text()='" + todate + "']")).click();
            Thread.sleep(1000);





            //driver.FindElement(By.LinkText(today.Day.ToString("10/01/2021"))).Click();*/


            return this;
        }
    }
}
