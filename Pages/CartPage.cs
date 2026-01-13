using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightSpecFlowSauceDemo.Pages
{
    public class CartPage : BasePage
    {
        private readonly string _cartItem = ".cart_item";
        private readonly string _checkoutButton = "#checkout";

        public CartPage(IPage page) : base(page)
        {
        }

        public async Task<bool> IsLoaded()
        {
            return await IsVisible(_cartItem);
        }

        public async Task ProceedToCheckout()
        {
            await Click(_checkoutButton);
        }
    }
}
