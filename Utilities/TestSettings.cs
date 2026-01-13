namespace PlaywrightSpecFlowSauceDemo.Utilities
{
    public class TestSettings
    {
        public string Environment { get; set; }
        public Urls Urls { get; set; }
        public Browser Browser { get; set; }
    }

    public class Urls
    {
        public string BaseUrl { get; set; }
    }

    public class Browser
    {
        public bool Headless { get; set; }
        public int SlowMo { get; set; }
        public int ViewportWidth { get; set; }
        public int ViewportHeight { get; set; }
    }
}
