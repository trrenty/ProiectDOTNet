
namespace Frontend.Settings
{
    public interface IApiSettings
    {
        string BaseAddress { get; set; }
        string ExpressionParserPath { get; set; }
        string ImageRecognizerPath { get; set; }
    }
}
