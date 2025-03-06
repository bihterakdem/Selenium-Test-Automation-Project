using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class EmployeePage
    {
        // WebDriver instance
        private readonly IWebDriver driver;

        // Constructor
        public EmployeePage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        /* Page objects */
        public readonly By SearchBox = By.Id("searchBox"); // Adjust this as per actual ID
        public readonly By DeleteButton = By.XPath("//td/a[contains(text(), 'Delete')]"); // Common XPath for delete buttons

        /* Page Methods */
        public void SearchEmployee(string name)
        {
            driver.FindElement(SearchBox).Clear();
            driver.FindElement(SearchBox).SendKeys(name);
            driver.FindElement(SearchBox).SendKeys(Keys.Enter); // Assuming pressing Enter will trigger the search
        }

        public void ClickDeleteButton(string name)
        {
            string xpath = $"//tr[td[text()='{name}']]/td/a[contains(text(), 'Delete')]";
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public bool IsEmployeePresent(string name)
        {
            try
            {
                string xpath = $"//tr[td[text()='{name}']]";
                return driver.FindElement(By.XPath(xpath)).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
