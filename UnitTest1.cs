using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestSeleniumTraining.Elements;

namespace TestSeleniumTraining
{
    public class Tests
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

        /* [Test]
         public void ElementsTextBoxTest()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu()
                 .FillTextBoxMenu();
             driver.Close();
         }
        /* [Test]
         public void ElementsCheckBoxTest()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu()
                 .ChooseCheckBoxMenu()
                 .FillCheckBoxMenu();
             driver.Close();
         }
         [Test]
         public void ElementsRadioButtonMenu()
         {
             var elements = new ElementsMenu(driver)
                 .ChooseElementsMenu()
                 .RadioButton();
         }*/
        [Test]
        public void ElementsButtonMenu()
        {
            var elements = new ElementsMenu(driver)
                .ChooseElementsMenu()
                .ButtonsMenu();
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}