using NUnit.Framework;

namespace lab3.Tests
{
    [TestFixture]
    class LoginTests : BaseTest
    {
        private static LoginHelper loginHelper = new LoginHelper();

        [Test]
        public static void CorrectLoginTest()
        {
            string email = "dzmarianadz@gmail.com";
            string password = "QA_lab3_test";

            string expectedUserName = "Mariana";

            loginHelper
                .Login(email, password)
                .AssertUserName(expectedUserName);
        }


        [Test]
        public static void InCorrectLoginTest()
        {
            string email = "dzmarianadz@gmail.com";
            string password = "12345678";

            //string expectedUserName = "Mariana";

            loginHelper
                .Login(email, password)
                .AssertIncorrectData();
        }
    }
}
