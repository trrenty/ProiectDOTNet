using Frontend.Models;
using System.Threading.Tasks;

namespace Frontend.ApiCollection.Interfaces
{
    public interface IImageRecognizerApi
    {
        Task<PredictionModel> SendImage(string imageBase64);
    }
}
