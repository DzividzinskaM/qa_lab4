using lab3.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace lab3
{
    class LoginPage : BaseObject
    {

        private const string LOGIN_PAGE_LINK = "(.//*[@href=\"https://www.zara.com/ua/uk/logon\"]//span)[1]";
       //  private const string EMAIL_FIELD = ".//*[@name=\"email\"]";
        private const string EMAIL_FIELD = "email";
        private const string PASSWORD_FIELD = ".//*[@type=\"password\"]";
        private const string LOGIN_BUTTON = ".form__footer > .button";
        private const string MODAL_WINDOW = ".modal__container";


        [FindsBy(How = How.XPath, Using = LOGIN_PAGE_LINK)]
        public IWebElement loginLink;

        [FindsBy(How = How.Name, Using = EMAIL_FIELD)]
        public IWebElement emailField;

        [FindsBy(How = How.XPath, Using = PASSWORD_FIELD)]
        public IWebElement passwordField;

        [FindsBy(How = How.CssSelector, Using = LOGIN_BUTTON)]
        public IWebElement loginBtn;

        public static LoginPage GetLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            InitPage(loginPage);
            return loginPage;
        }

        public LoginPage GoToLoginPage()
        {
            loginLink.Click();
            Thread.Sleep(1000);
            return GetLoginPage();

        }

        public LoginPage PrintEmail(string email)
        {
            emailField.SendKeys(email);
            return GetLoginPage();
        }

        public LoginPage PrintPassword(string password)
        {
            passwordField.SendKeys(password);
            return GetLoginPage();
        }

        public StartPage ClickLoginBtn()
        {
            loginBtn.Click();
            return StartPage.GetStartPage();
        }

        public LoginPage AssertIncorrectModal()
        {
            Thread.Sleep(2000);
            Driver.FindElement(By.CssSelector(MODAL_WINDOW));
            return this;
        }


    }
}
