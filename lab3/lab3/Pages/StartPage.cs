
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;


namespace lab3.Pages
{
    public class StartPage : BaseObject
    {
        private const string USER_NAME = "(//a[contains(text(),\"#\")])[1]";

        [FindsBy(How = How.XPath, Using = USER_NAME)]
        public IWebElement userName;

        public static StartPage GetStartPage()
        {
            StartPage startPage = new StartPage();
            InitPage(startPage);
            return startPage;
        }

        public StartPage AssertUserName(string expectedUserName)
        {
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(USER_NAME.Replace("#", expectedUserName)));
            return GetStartPage();
        }
    }
}
