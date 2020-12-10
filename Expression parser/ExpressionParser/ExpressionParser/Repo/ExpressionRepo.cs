using ExpressionParser.Data;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace ExpressionParser.Repo
{
    public class ExpressionRepo : IExpressionRepo
    {
        protected IMongoCollection<Expression> _collection;

        public ExpressionRepo(IExpressionsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Expression>(settings.ExpressionsCollectionName);
        }
        public Expression AddExpression(Expression expression)
        {
            {
                if (expression == null)
                {
                    throw new ArgumentNullException(typeof(Expression).Name + " object is null");
                }
                _collection.InsertOne(expression);
                return expression;
            }
        }

        public Expression GetExpression(string expression)
        {
            var filter = Builders<Expression>.Filter.Eq("expresie", expression);
            var expr = _collection.Find(filter).FirstOrDefault();
            return expr;
        }
    }
}
