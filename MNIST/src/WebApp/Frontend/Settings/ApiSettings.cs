
namespace Frontend.Settings
{
    public class ApiSettings : IApiSettings
    {
        public string BaseAddress { get; set; }
        public string ExpressionParserPath { get; set; }
        public string ImageRecognizerPath { get; set; }

    }
}
