
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace lab3.Tests
{
    class BaseTest : BaseObject
    {
        //public IWebDriver driver;

        private string baseUrl = "https://www.zara.com/ua/";

        [OneTimeSetUp]
        public void beforeClass()
        {

            Driver = new FirefoxDriver();
            /*Driver = new ChromeDriver("D:/Fork/qa-course/lab3/resources");*/

        }

        [SetUp]
        public void beforeTest()
        {
            Driver.Navigate().GoToUrl(baseUrl);
        }

        [OneTimeTearDown]
        public void afterClass()
        {
            Driver.Close();
        }


    }
}
