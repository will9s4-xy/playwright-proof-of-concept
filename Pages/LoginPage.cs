using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightSpecFlowSauceDemo.Pages
{
    public class LoginPage : BasePage
    {
        // Selectors
        private readonly string _usernameField = "#user-name";
        private readonly string _passwordField = "#password";
        private readonly string _loginButton = "#login-button";
        private readonly string _errorMessage = "[data-test='error']";

        public LoginPage(IPage page) : base(page)
        {
        }

        public async Task NavigateToLoginPage(string baseUrl)
        {
            await NavigateTo(baseUrl);
        }

        public async Task EnterUsername(string username)
        {
            await Type(_usernameField, username);
        }

        public async Task EnterPassword(string password)
        {
            await Type(_passwordField, password);
        }

        public async Task ClickLogin()
        {
            await Click(_loginButton);
        }

        public async Task<bool> IsErrorDisplayed()
        {
            return await IsVisible(_errorMessage);
        }
    }
}
