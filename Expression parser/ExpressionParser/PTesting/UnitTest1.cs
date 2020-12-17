using ExpressionParser.Parser;
using NUnit.Framework;
using System.Collections.Generic;

namespace PTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertToPostfixTest1()
        {
                string testExp = "a+b*c-d";

                string result = EqParser.ConvertToPostfix(testExp);

                Assert.AreEqual(result, "abc*+d-");
        }


        [Test]
        public void StringToTokensTest1()
        {
            string testExp = "-10+12x=13x+4";

            var resultT = Token.StringToTokens(testExp);
            string result = "";
            foreach (Token t in resultT) {
                result += t.ToString();
            }
            Assert.AreEqual(result, "(-10)(+)(12)(*)(x)(=)(13)(*)(x)(+)(4)");
        }

        [Test]

        public void ConvertToPostFixTokensTest1()
        {
            string exp = "-10+5*4-6";

            List<Token> result = EqParser.ConvertToPostfixToken(exp);

            string resultS = "";
            foreach (var t in result)
            {
                resultS += t;
            }
            Assert.AreEqual(resultS, "(-10)(5)(4)(*)(+)(6)(-)");
        }

        [Test]

        public void ExpressionEvaluationTest1()
        {
            string exp = "123*+4-";
            double result = EqParser.EvaluateExpr(exp);

            Assert.AreEqual(result, 3);
        }


        [Test]
        public void ExpressionEvaluationTokenTest1()
        {
            List<Token> tokens = new List<Token>(new Token[] {
                new Token(1), new Token(2), new Token(3), new Token('*'), new Token('+'), new Token(4), new Token('-')
            });
            double result = EqParser.EvaluateExprTokens(tokens);

            Assert.AreEqual(result, 3);
        }
    }
}