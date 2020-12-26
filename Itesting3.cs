using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration_Testing
{
    class Itesting3
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test4()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            driver.Url = "http://localhost/Hotel/";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[5]/div[1]/a"));
            Console.WriteLine(element.Displayed);
            element.Click();
            Assert.AreEqual("RESERVATION SUNRISE HOTEL", driver.Title);
            


        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
