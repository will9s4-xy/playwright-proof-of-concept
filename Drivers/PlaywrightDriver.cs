using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightSpecFlowSauceDemo.Drivers
{
    public class PlaywrightDriver
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IBrowserContext _context;
        private IPage _page;

        public async Task<IPage> InitializePlaywright()
        {
            if (_page != null)
                return _page;

            _playwright = await Playwright.CreateAsync();

            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false, // set true in CI
                SlowMo = 50
            });

            _context = await _browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = new ViewportSize { Width = 1280, Height = 720 },
                RecordVideoDir = "Videos",
                RecordVideoSize = new RecordVideoSize { Width = 1280, Height = 720 }
            });

            _page = await _context.NewPageAsync();
            return _page;
        }

        public async Task DisposeAsync()
        {
            if (_context != null)
                await _context.CloseAsync();

            if (_browser != null)
                await _browser.CloseAsync();

            _playwright?.Dispose();
        }
    }
}
