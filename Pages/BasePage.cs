using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightSpecFlowSauceDemo.Pages
{
    public class BasePage
    {
        protected readonly IPage _page;

        public BasePage(IPage page)
        {
            _page = page;
        }

        public async Task NavigateTo(string url)
        {
            await _page.GotoAsync(url);
        }

        public async Task Click(string selector)
        {
            await _page.ClickAsync(selector);
        }

        public async Task Type(string selector, string text)
        {
            await _page.FillAsync(selector, text);
        }

        public async Task WaitForSelector(string selector)
        {
            await _page.WaitForSelectorAsync(selector);
        }

        public async Task<bool> IsVisible(string selector)
        {
            return await _page.IsVisibleAsync(selector);
        }
        public async Task WaitForPageLoad()
{
    await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
}

public async Task WaitForElementVisible(string selector)
{
    await _page.Locator(selector).WaitForAsync(new LocatorWaitForOptions
    {
        State = WaitForSelectorState.Visible
    });
}

public async Task WaitForElementHidden(string selector)
{
    await _page.Locator(selector).WaitForAsync(new LocatorWaitForOptions
    {
        State = WaitForSelectorState.Hidden
    });
}

public async Task<string> GetText(string selector)
{
    return await _page.InnerTextAsync(selector);
}

public async Task<int> CountElements(string selector)
{
    return await _page.Locator(selector).CountAsync();
}
    }
}   