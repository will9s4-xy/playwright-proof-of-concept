using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightTests.Pages;

public class HomePage
{
    private readonly IPage _page;
    private const string Url = "https://playwright.dev";

    public HomePage(IPage page)
    {
        _page = page;
    }

    public Task NavigateAsync()
    {
        return _page.GotoAsync(Url);
    }

    public Task<string> GetTitleAsync()
    {
        return _page.TitleAsync();
    }
}
