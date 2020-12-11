using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using MLMicroservice.MLModels;
using System;
using System.Collections.Generic;

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

        [HttpGet, Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "image", "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" };
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
