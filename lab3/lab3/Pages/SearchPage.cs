using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace lab3.Pages
{
    public class SearchPage : BaseObject
    {

        private const string SEARCH_PAGE_LINK = ".//*[@class=\"layout-header-search-bar__text\"]";
        private const string SEARCH_FIELD_ID = "search-term";
        private const string TIPS_ID= ".topTerms > :nth-child(1)";
        private const string PRODUCT_RESULT_LIST = ".product-grid__product-list";
        private const string SEARCH_IS_NOT_SUCCESFULL_MSG = "otherResults";

        [FindsBy(How = How.XPath, Using = SEARCH_PAGE_LINK)]
        public IWebElement searchPageLink;

        [FindsBy(How = How.Id, Using = SEARCH_FIELD_ID)]
        public IWebElement searchField;


        public static SearchPage GetSearchPage()
        {
            SearchPage searchPage = new SearchPage();
            InitPage(searchPage);
            return searchPage;
        }

        public SearchPage GoToSearchPage()
        {
            searchPageLink.Click();
            //Thread.Sleep(10000);
            return GetSearchPage();  
        }

        public SearchPage PrintSerchRequest(string searchRequest)
        {
            searchField.SendKeys(searchRequest);
            return GetSearchPage();
        }

        public SearchPage AssertTips()
        {
            Thread.Sleep(2000);
            Driver.FindElement(By.Id(TIPS_ID));
            return GetSearchPage();
        }

        public SearchPage AssetsSearchList()
        {
            Driver.FindElement(By.CssSelector(PRODUCT_RESULT_LIST));
            return GetSearchPage();
        }

        public SearchPage AssetsUnseccesfullSearchMsg()
        {
            Driver.FindElement(By.Id(SEARCH_IS_NOT_SUCCESFULL_MSG));
            return GetSearchPage();
        }
    }
}
