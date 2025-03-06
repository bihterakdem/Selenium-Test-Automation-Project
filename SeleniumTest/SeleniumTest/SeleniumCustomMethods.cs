using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class SeleniumCustomMethods
    {

        public static void Click(IWebDriver driver, By locator) 
        { 
            driver.FindElement(locator).Click();
        
        }

        public static void EnterText(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);

        }

        public static void SelectDropDownByText(IWebDriver driver, By locator, string text)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));

            selectElement.SelectByText(text);
        }

        public static void SelectDropDownByValue(IWebDriver driver, By locator, string value)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));

            selectElement.SelectByValue(value);
        }

        public static void EnterValue(IWebDriver driver, string fieldId, string value)
        {
            var field = driver.FindElement(By.Id(fieldId));
            field.SendKeys(value);
        }


    }
}
