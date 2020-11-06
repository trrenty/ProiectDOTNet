using System;

namespace Lab6DOTNET.Model
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public bool IsDone { get; set; } = false;
    }
}