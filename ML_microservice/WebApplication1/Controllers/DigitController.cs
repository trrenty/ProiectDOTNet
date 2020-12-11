using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using MLMicroservice.MLModels;
using System;

namespace MLMicroservice.Controllers
{
    [Route("api/v1/predictions")]
    [ApiController]
    public class DigitController : ControllerBase
    {

        private readonly PredictionEnginePool<DigitData, DigitPrediction> _predictionEnginePool;

        public DigitController(PredictionEnginePool<DigitData,DigitPrediction> predictionEnginePool)
        {
            this._predictionEnginePool = predictionEnginePool;
        }
        [HttpPost]
        public ActionResult<string> Post([FromBody] DigitData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            DigitPrediction predictedValue=new DigitPrediction();
     
            predictedValue = _predictionEnginePool.Predict(modelName: "DigitAnalysisModel", example: data);
            Console.WriteLine(predictedValue.Prediction);
               
            return Ok(predictedValue.Prediction);
            
            
         
        }
    }
}
