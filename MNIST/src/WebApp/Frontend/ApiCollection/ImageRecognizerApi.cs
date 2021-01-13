using Frontend.ApiCollection.Infrastructure;
using Frontend.ApiCollection.Interfaces;
using Frontend.Models;
using Frontend.Settings;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.ApiCollection
{
    public class ImageRecognizerApi : BaseHttpClientWithFactory, IImageRecognizerApi
    {
        private readonly IApiSettings _settings;
        public ImageRecognizerApi(IHttpClientFactory factory, IApiSettings settings) : base(factory)
        {
            _settings = settings;
        }

        public async Task<PredictionModel> SendImage(string imageBase64)
        {
            var message = new HttpRequestBuilder(_settings.BaseAddress)
                                .SetPath(_settings.ImageRecognizerPath)
                                .HttpMethod(HttpMethod.Post)
                                .GetHttpMessage();
            var json = JsonConvert.SerializeObject(imageBase64);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return await SendRequest<PredictionModel>(message);
        }
    }
}
