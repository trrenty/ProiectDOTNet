using Lab6DOTNET.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6DOTNET.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ToDo>().HasData(
                new ToDo { Description = "Termina Lab DOTNET", IsDone = true, Id = 1},
                new ToDo { Description = "Continua Tema SI", Id = 2 },
                new ToDo { Description = "Tema ML", Id = 3 },
                new ToDo { Description = "Tema AI", Id = 4 },
                new ToDo { Description = "IMR", Id = 5 }
            ) ;
        }
    }
}
