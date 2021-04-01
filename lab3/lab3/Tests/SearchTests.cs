using lab3.TestHelpers;
using NUnit.Framework;

namespace lab3.Tests
{
    [TestFixture]
    class SearchTests : BaseTest
    {
        private static SearchHelper searchHelper = new SearchHelper();
        [Test]
        public void ShowTipsTest()
        {
            string searchRequest = "с";

            searchHelper.Search(searchRequest)
                .AssertTipsIsPresent();
        }

        [Test]
        public void SearchIsCorrectTest()
        {
            string searchRequest = "сумки";

            searchHelper.Search(searchRequest)
                .AssertProductListIsShown();
        }

        [Test]
        public void SearchIsNotSuccessfullTest()
        {
            string searchRequest = "аааа";

            searchHelper.Search(searchRequest)
                .AssertMeesage();
        }
    }
}
