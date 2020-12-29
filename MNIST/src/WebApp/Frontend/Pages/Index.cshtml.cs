using Frontend.ApiCollection.Interfaces;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IExpressionParserApi _expressionParserApi;

        public IndexModel(IExpressionParserApi expressionParserApi)
        {
            _expressionParserApi = expressionParserApi;
        }

        public ExpressionModel Expression { get; set; } = new ExpressionModel();

        public async Task<IActionResult> OnGetAsync(string expression)
        {
            //Expression = await _expressionParserApi.GetExpression(expression);
            return Page();
        }

        public async Task<IActionResult> OnPostReturnResultAsync([FromBody]string imageBase64)
        {
            Console.WriteLine("the image is");
            Console.WriteLine(imageBase64);
            // send image to ML Microservice
            // receive response from ML Microservice
            // check response from ML Microservice
            // send expression to Parser
            string expression = "4+10";
            // transform in base64
            string expressionEncoded = Convert.ToBase64String(Encoding.ASCII.GetBytes(expression));
            // receive response from Parser 
            var result = await _expressionParserApi.GetExpression(expressionEncoded);
     
            return Page();
        }
    }
}
