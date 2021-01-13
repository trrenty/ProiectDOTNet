
namespace Frontend.Models
{
    public class ExpressionModel
    {
        public string Expresie { get; set; }
        public string Result { get; set; }

        public ExpressionModel(string expression, string result)
        {
            Expresie = expression;
            Result = result;
        }

        public ExpressionModel()
        {
        }
    }
}
