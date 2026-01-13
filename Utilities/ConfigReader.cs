using System.Text.Json;

namespace PlaywrightSpecFlowSauceDemo.Utilities
{
    public static class ConfigReader
    {
        public static T LoadConfig<T>(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
