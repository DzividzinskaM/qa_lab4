using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium;

namespace lab3
{
    public class BaseObject
    {
        public static IWebDriver Driver;
        public static WebDriverBackedSelenium Selenium;

        public static void InitPage<T>(T pageClass) where T : BaseObject
        {
            PageFactory.InitElements(Driver, pageClass);
        }
    }
}
