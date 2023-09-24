using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestSeleniumTraining
{
	public class TestBase
	{
        public IWebDriver driver;
        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

