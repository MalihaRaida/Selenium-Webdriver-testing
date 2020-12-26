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
    class Itesing2
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        private void login()
        {
            driver.Url = "http://localhost/Hotel/admin/";
            IWebElement element = driver.FindElement(By.Name("user"));
            element.SendKeys("Admin");

            IWebElement password = driver.FindElement(By.Name("pass"));
            password.SendKeys("1234");
            driver.FindElement(By.Name("sub")).Click();
        }
        [Test]
        public void Test1()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            login();
            IWebElement element=driver.FindElement(By.CssSelector("#main-menu > li:nth-child(2) > a"));
            element.Click();
            driver.Navigate().Back();

            String title = driver.Title;
            String et = "Administrator";
            if (title == et)
            {
                Console.WriteLine("Successful");
            }
            else
            {
                Console.WriteLine("Unsuccesful");
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
