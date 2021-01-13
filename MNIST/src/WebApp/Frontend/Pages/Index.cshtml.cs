using Frontend.ApiCollection.Interfaces;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
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

        public async Task<ActionResult> OnPostReturnResultAsync([FromBody]string imageBase64)
        {
            Console.WriteLine("the image is");
            Console.WriteLine(imageBase64); //"data:image/png;base64,"
            imageBase64 = imageBase64.Replace("data:image/png;base64,", "");
            // send image and receive response to ML Microservice
            var predictedExpression = await _imageRecognizerApi.SendImage(imageBase64);
            // check response from ML Microservice
            //ExpressionModel model = new ExpressionModel("5+30", "35");
            //create expression with post
            //var result = await _expressionParserApi.CreateExpression(model);
            // transform in base64
            string expressionEncoded = Convert.ToBase64String(Encoding.ASCII.GetBytes((predictedExpression.Prediction).ToString()));
            //receive response from Parser 
            var result = await _expressionParserApi.GetExpression(expressionEncoded);
            this.Result = result.Result;
            return Content(this.Result);
        }
    }
}
