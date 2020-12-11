using Microsoft.ML;
using MLMicroservice.MLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MLMicroservice.Controllers
{
    public class ConsumeModel
    {
        private static Lazy<PredictionEngine<DigitData, DigitPrediction>> PredictionEngine = new Lazy<PredictionEngine<DigitData, DigitPrediction>>(CreatePredictionEngine);

        // For more info on consuming ML.NET models, visit https://aka.ms/mlnet-consume
        // Method for consuming model in your app
        public static DigitPrediction Predict(DigitData input)
        {
            DigitPrediction result = PredictionEngine.Value.Predict(input);
            return result;
        }

        public static PredictionEngine<DigitData, DigitPrediction> CreatePredictionEngine()
        {
            // Create new MLContext
            MLContext mlContext = new MLContext();

            // Load model & create prediction engine
            string modelPath = @"C:\Users\catalina\AppData\Local\Temp\MLVSTools\training_mareML\training_mareML.Model\MLModel.zip";
            ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<DigitData, DigitPrediction>(mlModel);

            return predEngine;
        }
    }
}
