using Frontend.ApiCollection.Interfaces;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IExpressionParserApi _expressionParserApi;
        private readonly IImageRecognizerApi _imageRecognizerApi;
        [BindProperty]
        public string Result { get; set; }

        public IndexModel(IExpressionParserApi expressionParserApi, IImageRecognizerApi imageRecognizerApi)
        {
            _expressionParserApi = expressionParserApi;
            _imageRecognizerApi = imageRecognizerApi;
        }

        public ExpressionModel Expression { get; set; } = new ExpressionModel();

        public async Task<IActionResult> OnGetAsync(string expression)
        {
            return Page();
        }

        public async Task<ActionResult> OnPostReturnResultAsync([FromBody]string imagesBase64)
        {
            Console.WriteLine("the image is");
            Console.WriteLine(imagesBase64); //"data:image/png;base64,"

            String[] encodings = imagesBase64.Split("data:image/png;base64,");
            encodings = encodings.Skip(1).ToArray();
            var predictedExpression = "";
            // send image and receive response to ML Microservice
            for (int index=0; index <6; index++)
            {
                var expression = await _imageRecognizerApi.SendImage(encodings[index]);
                if ((expression.Prediction).ToString() == "11")
                {
                    predictedExpression += "+";
                }
                else if ((expression.Prediction).ToString() == "10")
                {
                    predictedExpression += "x";
                }
                else if ((expression.Prediction).ToString() == "12")
                {
                    predictedExpression += "=";
                }
                else {
                    predictedExpression += expression.Prediction;
                }
            }
            Console.WriteLine(predictedExpression);
            // transform in base64
            string expressionEncoded = Convert.ToBase64String(Encoding.ASCII.GetBytes(predictedExpression));
            // receive response from Parser 
            var result = await _expressionParserApi.GetExpression(expressionEncoded);
            this.Result = result.Result;
            return Content(this.Result);
        }
    }
}
