using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumTraining.HelperCase
{
    internal class Helper
    {
        private IWebDriver driver;

        public Helper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void imitationclick()
        {
            button1_Click(null, null);
            void button1_Click(object sender, EventArgs e)
            {
            }
        }


    }
}
