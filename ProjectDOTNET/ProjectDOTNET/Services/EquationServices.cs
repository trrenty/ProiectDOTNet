using MongoDB.Driver;
using ProjectDOTNET.Models;
using System.Collections.Generic;

namespace ProjectDOTNET.Services
{
    public class EquationServices
    {
        private readonly IMongoCollection<Equation> _equations;

        public EquationServices(IEquationSolverDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _equations = database.GetCollection<Equation>(settings.EquationsCollectionName);
        }

        public List<Equation> Get() => _equations.Find(equation => true).ToList();

        public Equation Get(string id) => _equations.Find<Equation>(equation => equation.Id == id).FirstOrDefault();

        public List<Equation> FindByTitle(string title) => _equations.Find(equation => equation.EquationToBeSolved.ToLower().Contains(title.ToLower())).ToList();

        public Equation Create(Equation equation)
        {
            _equations.InsertOne(equation);
            return equation;
        }

        public void Update(string id, Equation newEquation) => _equations.ReplaceOne(equation => equation.Id == id, newEquation);

        public void Remove(Equation newEquation) => _equations.DeleteOne(equation => equation.Id == newEquation.Id);

        public void Remove(string id) => _equations.DeleteOne(equation => equation.Id == id);
    }
}
