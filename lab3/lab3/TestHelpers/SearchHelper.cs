using lab3.Pages;
using System.Threading;

namespace lab3.TestHelpers
{
    class SearchHelper
    {

        private SearchPage searchPage = new SearchPage();

        public SearchHelper Search(string searchRequest)
        {
            BaseObject.InitPage(searchPage);
            searchPage.
                GoToSearchPage().
                PrintSerchRequest(searchRequest);
            return this;
        }

        public SearchHelper AssertTipsIsPresent()
        {
            searchPage.AssertTips();
            return this;
        }
        public SearchHelper AssertProductListIsShown()
        {
            Thread.Sleep(2000);
            searchPage.AssetsSearchList();
            return this;
        }

        public SearchHelper AssertMeesage()
        {
            Thread.Sleep(2000);
            searchPage.AssetsUnseccesfullSearchMsg();
            return this;
        }


    }
}
