using TechTalk.SpecFlow;
using Microsoft.Playwright;
using PlaywrightSpecFlowSauceDemo.Drivers;

namespace PlaywrightSpecFlowSauceDemo.Hooks
{
    [Binding]
    public class TestHooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly PlaywrightDriver _driver;
        public IPage Page { get; private set; }

        public TestHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = new PlaywrightDriver();
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            Page = await _driver.InitializePlaywright();
            _scenarioContext["Page"] = Page;

            await Page.Context.Tracing.StartAsync(new TracingStartOptions
            {
                Screenshots = true,
                Snapshots = true,
                Sources = true
            });
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            var scenarioName = _scenarioContext.ScenarioInfo.Title.Replace(" ", "_");

            await Page.Context.Tracing.StopAsync(new TracingStopOptions
            {
                Path = $"Traces/{scenarioName}_trace.zip"
            });

            if (_scenarioContext.TestError != null)
            {
                await Page.ScreenshotAsync(new PageScreenshotOptions
                {
                    Path = $"Screenshots/{scenarioName}_FAILED.png"
                });
            }

            await _driver.DisposeAsync();
        }
    }
}
