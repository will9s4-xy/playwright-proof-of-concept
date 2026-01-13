using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightSpecFlowSauceDemo.Pages
{
    public class CheckoutPage : BasePage
    {
        private readonly string _firstNameField = "#first-name";
        private readonly string _lastNameField = "#last-name";
        private readonly string _postalCodeField = "#postal-code";
        private readonly string _continueButton = "#continue";
        private readonly string _finishButton = "#finish";
        private readonly string _checkoutInfoContainer = ".checkout_info";

        public CheckoutPage(IPage page) : base(page)
        {
        }

        public async Task<bool> IsLoaded()
        {
            return await IsVisible(_checkoutInfoContainer);
        }

        public async Task EnterFirstName(string firstName)
        {
            await Type(_firstNameField, firstName);
        }

        public async Task EnterLastName(string lastName)
        {
            await Type(_lastNameField, lastName);
        }

        public async Task EnterPostalCode(string postalCode)
        {
            await Type(_postalCodeField, postalCode);
        }

        public async Task Continue()
        {
            await Click(_continueButton);
        }

        public async Task FinishOrder()
        {
            await Click(_finishButton);
        }
    }
}
