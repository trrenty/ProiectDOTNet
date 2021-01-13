
using Frontend.ApiCollection.Infrastructure;
using Frontend.ApiCollection.Interfaces;
using Frontend.Models;
using Frontend.Settings;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.ApiCollection
{
    public class ExpressionParserApi : BaseHttpClientWithFactory, IExpressionParserApi
    {
        private readonly IApiSettings _settings;

        public ExpressionParserApi(IHttpClientFactory factory, IApiSettings settings) : base(factory)
        {
            _settings = settings;
        }

        public async Task<ExpressionModel> GetExpression(string expressionEncoded)
        {
            var message = new HttpRequestBuilder(_settings.BaseAddress)
                               .SetPath(_settings.ExpressionParserPath)
                               .AddToPath(expressionEncoded)
                               .HttpMethod(HttpMethod.Get)
                               .GetHttpMessage();
            return await SendRequest<ExpressionModel>(message);
        }

        public async Task<ExpressionModel> CreateExpression(ExpressionModel model)
        {
            var message = new HttpRequestBuilder(_settings.BaseAddress)
                                .SetPath(_settings.ExpressionParserPath)
                                .HttpMethod(HttpMethod.Post)
                                .GetHttpMessage();

            var json = JsonConvert.SerializeObject(model);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return await SendRequest<ExpressionModel>(message);
        }
    }
}
