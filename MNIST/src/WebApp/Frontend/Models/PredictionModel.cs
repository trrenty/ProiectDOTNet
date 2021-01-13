using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class PredictionModel
    {
        public int Prediction { get; set; }
        public double[] Scores { get; set; }
        public string PixelValues { get; set; }
    }
}
