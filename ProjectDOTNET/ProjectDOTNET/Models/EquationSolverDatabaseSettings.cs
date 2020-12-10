namespace ProjectDOTNET.Models
{
    public class EquationSolverDatabaseSettings : IEquationSolverDatabaseSettings
    {
        public string EquationsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IEquationSolverDatabaseSettings
    {
        string EquationsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
