using ExpressionParser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressionParser.Repo
{
    public interface IExpressionRepo
    {
        Expression GetExpression(string expression);
        Expression AddExpression(Expression expression);
    }
}
