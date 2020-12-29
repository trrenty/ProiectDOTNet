using Frontend.Models;
using System.Threading.Tasks;

namespace Frontend.ApiCollection.Interfaces
{
    public interface IExpressionParserApi
    {
        Task<ExpressionModel> GetExpression(string expression);
        Task<ExpressionModel> CreateExpression(ExpressionModel model);
    }
}
