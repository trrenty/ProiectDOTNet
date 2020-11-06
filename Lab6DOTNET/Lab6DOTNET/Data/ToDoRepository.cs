using Lab6DOTNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6DOTNET.Data
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly DataContext context;

        public ToDoRepository(DataContext dataContext)
        {
            context = dataContext;
        }
        public void Create(ToDo task)
        {
            context.Add(task);
            context.SaveChanges();
        }

        public IEnumerable<ToDo> GetAll()
        {
            return context.ToDos.ToList();
        }

        public ToDo GetById(int id)
        {
            return context.ToDos.Find(id);
        }

        public void Remove(ToDo task)
        {
            context.Remove(task);
            context.SaveChanges();
        }

        public void RemoveByID(int id)
        {
            ToDo task = context.ToDos.Find(id);
            context.Remove(task);
            context.SaveChanges();
        }

        public void Update(ToDo task)
        {
            context.Update(task);
            context.SaveChanges();
        }
    }
}
