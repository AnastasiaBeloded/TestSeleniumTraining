using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestSeleniumTraining.Widgets
{
    internal class WMSliderMenu
    {
        private IWebDriver driver;
        private IWebElement elementToSlide;
        private readonly By sliderMenu = By.XPath("//span[normalize-space()='Slider']");
        private readonly By sliderMoving = By.XPath("//input[@type='range']");
        private readonly By sliderMovingFrom = By.CssSelector("input[value='25'][type='range']");
        private readonly By sliderMovingTo = By.CssSelector("input[value='75'][type='range']");
        public WMSliderMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        public WMSliderMenu openSliderMenu()
        {
            driver.FindElement(sliderMenu).Click();
            return this;
        }


        public WMSliderMenu MovingSlider()
        {
            var sliderAtribute = driver.FindElement(sliderMoving);
            var atribute = sliderAtribute.GetAttribute("value");
            int atri = Int32.Parse(atribute);

            IWebElement slider = driver.FindElement(sliderMoving);
          
            Actions action = new Actions(driver);
            action.Click(slider).Build().Perform();
            Thread.Sleep(5);
            for (int i = atri; i < 90-atri; i++)
            {
                action.SendKeys(Keys.ArrowRight).Build().Perform();
                Thread.Sleep(10);
            }



            return this;
        }

        
    }
}
