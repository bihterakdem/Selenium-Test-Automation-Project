using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
   
    public class n11com
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void test3() { 

        IWebDriver driver = new ChromeDriver();
        

        driver.Navigate().GoToUrl("http://www.n11.com/");
        driver.Manage().Window.Maximize();

        driver.FindElement(By.Id("searchData")).SendKeys("Samsung");
        driver.FindElement(By.ClassName("searchBtn")).Click();

        driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[2]/div[2]/a[2]")).Click();
       // driver.FindElement(By.XPath(".//*[@id='p-600231995']/div[1]/a")).Click();

            // driver.FindElement(By.ClassName("btnAddBasket")).Click();
        }

    }
}
