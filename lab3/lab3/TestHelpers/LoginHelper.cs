using lab3.Pages;

namespace lab3
{
    public class LoginHelper
    {
        private LoginPage loginPage = new LoginPage();

        private StartPage startPage = new StartPage();


        public LoginHelper Login(string email, string password)
        {
            
            BaseObject.InitPage(loginPage);
            loginPage.
                GoToLoginPage().
                PrintEmail(email).
                PrintPassword(password).
                ClickLoginBtn();
            return this;
        }

        public LoginHelper AssertUserName(string userName)
        {
            startPage.AssertUserName(userName);
            return this;
        }

        public LoginHelper AssertIncorrectData()
        {
            BaseObject.InitPage(loginPage);
            loginPage.AssertIncorrectModal();
            return this;
        }
    }
}
