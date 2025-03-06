using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTest
{
    [TestFixture]
    public class EmployeeTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void SetUp()
        {
           
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestEmployeeByName()
        {
            IWebDriver driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/Employee");



            driver.FindElement(By.Name("searchTerm")).SendKeys("Ramesh");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".btn")).Submit();
            Thread.Sleep(2000);
            //driver.FindElement(By.ClassName("table")).Selected("");
            //driver.FindElement(By.XPath(".//*[@class='container body-content']/tbody/td/a")).GetCssValue("http://eaapp.somee.com/Benefit/Details/3");
            driver.Navigate().GoToUrl("http://eaapp.somee.com/Benefit/Details/3");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://eaapp.somee.com/Employee");
            // Optionally handle confirmation dialog
            // IWebElement confirmButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("confirmDeleteButtonId")));
            // confirmButton.Click();


        }
    }
}
