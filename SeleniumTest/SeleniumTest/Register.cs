using OpenQA.Selenium;

namespace SeleniumTest
{
    public class RegisterPage
    {
        // WebDriver instance
        private readonly IWebDriver driver;

        // Constructor
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        /* Page objects */
        public readonly By Username = By.Id("LastName");
        public readonly By Password = By.Name("Password");
        public readonly By ConfirmPassword = By.Id("ConfirmPassword");
        public readonly By EmailAddress = By.Id("Email");
        public readonly By RegisterButton = By.Id("register-button");
        public readonly By Result = By.ClassName("result");
        public readonly By Logout = By.ClassName("ico-logout");

        /* Page Methods */
        public void EnterUserName(string value)
        {
            driver.FindElement(Username).SendKeys(value);
        }

        public void EnterEmail(string value)
        {
            driver.FindElement(EmailAddress).SendKeys(value);
        }

        public void EnterPassword(string pass)
        {
            driver.FindElement(Password).SendKeys(pass);
        }

        public void EnterConfirmPassword(string pass)
        {
            driver.FindElement(ConfirmPassword).SendKeys(pass);
        }

        public void ClickRegisterButton()
        {
            driver.FindElement(RegisterButton).Click();
        }

        public string GetSuccessfulMessage()
        {
            return driver.FindElement(Result).Text;
        }

        public bool IsEmailAccountDisplayed(string email)
        {
            return driver.FindElement(EmailAddress).Text.Contains(email);
        }

        public void ClickLogout()
        {
            driver.FindElement(Logout).Click();
        }
    }
}
