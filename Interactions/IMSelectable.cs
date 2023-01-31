using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.Interactions
{
    internal class IMSelectable
    {
        private IWebDriver driver;
        public IMSelectable(IWebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By selectSelectableMenu = By.XPath("//span[normalize-space()='Selectable']");

        private readonly By selectFirst = By.XPath("//li[normalize-space()='Cras justo odio']");
        private readonly By selectFirstIsDisplayed = By.XPath("(//li[normalize-space()='Cras justo odio'])[1]");

        private readonly By selectSecond = By.XPath("//li[normalize-space()='Dapibus ac facilisis in']");
        private readonly By selectSecondIsDisplayed = By.XPath("(//li[normalize-space()='Dapibus ac facilisis in'])[1]");

        private readonly By selectThird = By.XPath("//li[normalize-space()='Morbi leo risus']");
        private readonly By selectThirdIsDisplayed = By.XPath("(//li[normalize-space()='Morbi leo risus'])[1]");

        private readonly By selectFourth = By.XPath("//li[normalize-space()='Porta ac consectetur ac']");
        private readonly By selectFourthIsDisplayed = By.XPath("(//li[normalize-space()='Porta ac consectetur ac'])[1]");

        private readonly By selectGridMenu = By.CssSelector("#demo-tab-grid");

        private readonly By selectOne = By.XPath("//li[normalize-space()='One']");
        private readonly By selectOneIsDisplayed = By.XPath("(//li[normalize-space()='One'])[1]");

        private readonly By selectTwo = By.XPath("//li[normalize-space()='Two']");
        private readonly By selectTwoIsDisplayed = By.XPath("(//li[normalize-space()='Two'])[1]");

        private readonly By selectThree = By.XPath("//li[normalize-space()='Three']");
        private readonly By selectThreeIsDisplayed = By.XPath("(//li[normalize-space()='Three'])[1]");

        private readonly By selectFour = By.XPath("//li[normalize-space()='Four']");
        private readonly By selectFourIsDisplayed = By.XPath("(//li[normalize-space()='Four'])[1]");

        private readonly By selectFive = By.XPath("//li[normalize-space()='Five']");
        private readonly By selectFiveIsDisplayed = By.XPath("(//li[normalize-space()='Five'])[1]");

        private readonly By selectSix = By.XPath("//li[normalize-space()='Six']");
        private readonly By selectSixIsDisplayed = By.XPath("(//li[normalize-space()='Six'])[1]");

        private readonly By selectSeven = By.XPath("//li[normalize-space()='Seven']");
        private readonly By selectSevenIsDisplayed = By.XPath("(//li[normalize-space()='Seven'])[1]");

        private readonly By selectEight = By.XPath("//li[normalize-space()='Eight']");
        private readonly By selectEightIsDisplayed = By.XPath("(//li[normalize-space()='Eight'])[1]");

        private readonly By selectNine = By.XPath("//li[normalize-space()='Nine']");
        private readonly By selectNineIsDisplayed = By.XPath("(//li[normalize-space()='Nine'])[1]");




        public IMSelectable openSelectableMenu()
        {
            driver.FindElement(selectSelectableMenu).Click();
            return this;
        }
        public IMSelectable workWithList()
        {
            driver.FindElement(selectFirst).Click();
            Assert.IsTrue(driver.FindElement(selectFirstIsDisplayed).Displayed);

            driver.FindElement(selectSecond).Click();
            Assert.IsTrue(driver.FindElement(selectSecondIsDisplayed).Displayed);

            driver.FindElement(selectThird).Click();
            Assert.IsTrue(driver.FindElement(selectThirdIsDisplayed).Displayed);

            driver.FindElement(selectFourth).Click();
            Assert.IsTrue(driver.FindElement(selectFourthIsDisplayed).Displayed);

            return this;
        }
        public IMSelectable workWithGrid()
        {
            driver.FindElement(selectGridMenu).Click();

            driver.FindElement(selectOne).Click();
            Assert.IsTrue(driver.FindElement(selectOneIsDisplayed).Displayed);

            driver.FindElement(selectTwo).Click();
            Assert.IsTrue(driver.FindElement(selectTwoIsDisplayed).Displayed);

            driver.FindElement(selectThree).Click();
            Assert.IsTrue(driver.FindElement(selectThreeIsDisplayed).Displayed);

            driver.FindElement(selectFour).Click();
            Assert.IsTrue(driver.FindElement(selectFourIsDisplayed).Displayed);

            driver.FindElement(selectFive).Click();
            Assert.IsTrue(driver.FindElement(selectFiveIsDisplayed).Displayed);

            driver.FindElement(selectSix).Click();
            Assert.IsTrue(driver.FindElement(selectSixIsDisplayed).Displayed);

            driver.FindElement(selectSeven).Click();
            Assert.IsTrue(driver.FindElement(selectSevenIsDisplayed).Displayed);

            driver.FindElement(selectEight).Click();
            Assert.IsTrue(driver.FindElement(selectEightIsDisplayed).Displayed);

            driver.FindElement(selectNine).Click();
            Assert.IsTrue(driver.FindElement(selectNineIsDisplayed).Displayed);


            return this;
        }
    }
}
