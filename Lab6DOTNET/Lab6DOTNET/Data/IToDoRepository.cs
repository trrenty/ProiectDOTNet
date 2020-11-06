using Lab6DOTNET.Model;

using System.Collections.Generic;


namespace Lab6DOTNET.Data
{
    public interface IToDoRepository
    {
        void Create(ToDo task);

        IEnumerable<ToDo> GetAll();
        ToDo GetById(int id);
        void Remove(ToDo task);

        void RemoveByID(int id);
        void Update(ToDo task);
    }
}
