using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Ensure you have the Entity Framework package installed
using iTasks.Models; // Adjust the namespace according to your project structure

namespace iTasks.Data
{
    namespace iTasks.Data
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext() { }

            public DbSet<Utilizador> Utilizadores { get; set; }
            public DbSet<Programador> Programadores { get; set; }
            public DbSet<Gestor> Gestores { get; set; }
            public DbSet<Tarefa> Tarefas { get; set; }
            public DbSet<TipoTarefa> TiposTarefas { get; set; }

            
        }
    }

}
