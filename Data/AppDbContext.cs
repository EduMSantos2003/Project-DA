using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Ensure you have the Entity Framework package installed
using iTasks.Models; // Adjust the namespace according to your project structure

//Install-Package EntityFramework

namespace iTasks.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext") { }

        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Programador> Programadores { get; set; }
        public DbSet<Gestor> Gestores { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TiposTarefas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .HasRequired(t => t.Programador)
                .WithMany()
                .HasForeignKey(t => t.ProgramadorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tarefa>()
                .HasRequired(t => t.Gestor)
                .WithMany()
                .HasForeignKey(t => t.GestorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tarefa>()
                .HasRequired(t => t.TipoTarefa)
                .WithMany()
                .HasForeignKey(t => t.TipoTarefaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Programador>()
                .HasRequired(p => p.Gestor)
                .WithMany()
                .HasForeignKey(p => p.GestorId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

        /*
        Enable-Migrations
        Add-Migration InitialCreate
        Update-Database
        */
    }
}

