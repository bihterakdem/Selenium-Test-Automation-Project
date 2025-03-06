using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTest
{
    [TestFixture]
    public class RegisterPageTests
    {
        private IWebDriver driver;
        private RegisterPage registerPage;

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void Test2()
        {

            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("http://eaapp.somee.com/Account/Register");

                driver.FindElement(By.Name("UserName")).SendKeys("sena ayse");
                driver.FindElement(By.Id("Password")).SendKeys("Password1-");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Password1-");
                driver.FindElement(By.Id("Email")).SendKeys("niluferakdem@marun.edu.tr");
                driver.FindElement(By.CssSelector(".btn")).Submit();

                // Wait for the success message to appear
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement successMessage = wait.Until(d => d.FindElement(By.CssSelector(".alert-success")));

                // Check the content of the success message
                if (successMessage.Text.Contains("successfully"))
                {
                    Console.WriteLine("Registration was successful.");
                }
                else
                {
                    Console.WriteLine("Registration failed. Success message not found.");
                }
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("An element was not found: " + ex.Message);
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("Timed out waiting for the success message: " + ex.Message);
            }
            finally
            {
                //driver.Quit();
            }
        }
    }

      
    
}
