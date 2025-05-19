using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Ensure you have the Entity Framework package installed
using iTasks.Models; // Adjust the namespace according to your project structure

namespace iTasks.Data
{
    class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext") {}
        public DbSet<Utilizador> Utilizador { get; set; }
        public DbSet<Programador> Programador { get; set; }
        public DbSet<Gestor> Gestor { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<EstadoTarefa> EstadoTarefa { get; set; }
        public DbSet<NivelExperiencia> NivelExperiencia { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TipoTarefa { get; set; }

    }
}
