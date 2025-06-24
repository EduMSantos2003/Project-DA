using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    public class Projeto
    {
        [Key]
        public int Id { get; set; } // Chave primária

        public string Descricao { get; set; } // Nome do projeto

        // Lista de tarefas associadas
        public ICollection<Tarefa> Tarefas { get; set; }
    }
}