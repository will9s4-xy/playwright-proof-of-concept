using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightSpecFlowSauceDemo.Pages
{
    public class InventoryPage : BasePage
    {
        private readonly string _inventoryContainer = ".inventory_list";
        private readonly string _cartIcon = ".shopping_cart_link";
        private readonly string _addToCartButton = "button[data-test='add-to-cart-sauce-labs-backpack']";

        public InventoryPage(IPage page) : base(page)
        {
        }

        public async Task<bool> IsLoaded()
        {
            return await IsVisible(_inventoryContainer);
        }

        public async Task AddBackpackToCart()
        {
            await Click(_addToCartButton);
        }

        public async Task GoToCart()
        {
            await Click(_cartIcon);
        }
    }
}
