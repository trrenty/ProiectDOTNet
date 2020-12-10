using ExpressionParser.Parser;
using NUnit.Framework;

namespace PTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
                string testExp = "a+b*c-d";

                string result = EqParser.ConvertToPostfix(testExp);

                Assert.AreEqual(result, "abc*+d-");
        }

        [Test]

        public void Test2()
        {
            string exp = "123*+4-";
            double result = EqParser.EvaluateExpr(exp);

            Assert.AreEqual(result, 3);
        }
    }
}