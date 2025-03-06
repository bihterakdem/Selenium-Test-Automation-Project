using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace SeleniumTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();

            // Initialize the WebDriver

            IWebDriver driver = new ChromeDriver();

            // Navigate to a website

            driver.Navigate().GoToUrl("https://www.google.com");

            // Maximize the browser window

            driver.Manage().Window.Maximize();

            // Find a web element

            IWebElement webElement = driver.FindElement(By.Name("q"));

            // Send input to the web element

            webElement.SendKeys("Selenium");

            webElement.SendKeys(Keys.Return);

            //webElement.Click(); 

        }


        [Test]
        public void EAWebsiteTest()
        {

            // Initialize the WebDriver

            IWebDriver driver = new ChromeDriver();

            // Navigate to a website

            driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");

            // Maximize the browser window

            driver.Manage().Window.Maximize();

            // Find the login link

            //IWebElement loginlink = driver.FindElement(By.LinkText("Login"));
            //IWebElement loginlink = driver.FindElement(By.Id("loginLink"));

            driver.FindElement(By.Id("loginLink")).Click();

            // Click the login link

            //loginlink.Click();

            //Find the Username text box

            //IWebElement txtUserName = driver.FindElement(By.Name("UserName"));

            driver.FindElement(By.Name("UserName")).SendKeys("admin");

            //Typing on the txtUserName

            //txtUserName.SendKeys("admin");

            //Find the Password text box

            //IWebElement txtPassword = driver.FindElement(By.Id("Password"));

            driver.FindElement(By.Id("Password")).SendKeys("password");

            //Typing on the txtUserName

            //txtPassword.SendKeys("password");

            //Identify the login button

            //IWebElement btnLogin=driver.FindElement (By.ClassName("btn"));

            //IWebElement btnLogin = driver.FindElement(By.CssSelector("btn"));

            driver.FindElement(By.CssSelector(".btn")).Submit();

            //Click login button

            //btnLogin.Submit();   

        }

            [Test]
            public void EAWebsiteTestReduceSize()
            {

                // Initialize the WebDriver

                IWebDriver driver = new ChromeDriver();

                // Navigate to a website

                driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");

                // Maximize the browser window

                driver.Manage().Window.Maximize();

                //driver.FindElement(By.Id("loginLink")).Click();

                SeleniumCustomMethods.Click(driver, By.Id("loginLink"));

                //driver.FindElement(By.Name("UserName")).SendKeys("admin");

                SeleniumCustomMethods.EnterText(driver, By.Name("UserName"), "admin");
                Thread.Sleep(1000);

                driver.FindElement(By.Id("Password")).SendKeys("password");

                driver.FindElement(By.CssSelector(".btn")).Submit();


            driver.Navigate().GoToUrl("http://www.eaapp.somee.com/Employee/Create"); // replace with your target URL

            // Example field entering
            SeleniumCustomMethods.EnterValue(driver, "Name", "nilufer"); // replace with actual field ID
            SeleniumCustomMethods.EnterValue(driver, "Salary", "2700");
            SeleniumCustomMethods.EnterValue(driver, "DurationWorked", "20");
            SeleniumCustomMethods.SelectDropDownByText(driver, By.Name("Grade"), "Senior");
            SeleniumCustomMethods.EnterValue(driver, "Email", "nil@marun.edu.tr");

            driver.FindElement(By.CssSelector(".btn")).Submit();

            // Optionally, submit the form if needed
            // driver.FindElement(By.Id("submitBtnId")).Click(); // replace with actual button ID



        }
        
        [Test]
            public void WorkingWithAdvancedControls()
            {

                // Initialize the WebDriver

                IWebDriver driver = new ChromeDriver();

                // Navigate to a website

                driver.Navigate().GoToUrl("https://theautomationzone.blogspot.com/2020/07/basic-dropdown.html");

                // Maximize the browser window
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();

                //SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("mySelect")));

                //selectElement.SelectByText("Orange");

                SeleniumCustomMethods.SelectDropDownByText(driver,By.Id("mySelect"), "Orange");
                Thread.Sleep(1000);
                SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id("cars")));

                multiSelect.SelectByText("Saab");
                multiSelect.SelectByText("Opel");


                IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;
                
                foreach (IWebElement option in selectedOption) 
                { 
                    Console.WriteLine(option.Text);

                }

            //IWebElement loginlink = driver.FindElement(By.Id("loginLink"));

            //loginlink.Click();

            //SeleniumCustomMethods.Click(driver, By.Id("loginLink"));

        }
    }

    }
