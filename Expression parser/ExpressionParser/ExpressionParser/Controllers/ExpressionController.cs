using ExpressionParser.Data;
using ExpressionParser.Parser;
using ExpressionParser.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExpressionParser.Controllers
{
    [Route("expression")]
    [ApiController]
    public class ExpressionController : ControllerBase
    {
        private readonly IExpressionRepo _repository;
        public ExpressionController(IExpressionRepo repository)
        {
            _repository = repository;
        }

        [HttpPost("get")]
        public ActionResult<Expression> GetExpression(Expression expr)
        {
            var tmp = _repository.GetExpression(expr.Expresie);
            if (tmp != null)
            {
                Console.WriteLine(EqParser.ConvertToPostfix(expr.Expresie));
            }
            return tmp;
        }

        [HttpPost]

        public IActionResult AddExpression(Expression expr)
        {
            _repository.AddExpression(expr);
            return CreatedAtAction(nameof(GetExpression), new { exp = expr.Expresie }, expr);
        }


        [HttpPost("test")]

        public ActionResult<Expression> Test(Expression expr)
        {
            string expression = expr.Expresie;

            List<Token> postfix = EqParser.ConvertToPostfixToken(expression);

            double result = EqParser.EvaluateExprTokens(postfix);

            string postfixRex = "";

            foreach (var t in postfix)
            {
                postfixRex += t;
            }

            Expression ret = new Expression { Expresie = postfixRex, Result = result.ToString() };

            return ret;
        }
    }
}
