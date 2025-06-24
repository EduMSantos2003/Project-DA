using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; } // Chave primária da tarefa

        public string Descricao { get; set; } // Descrição da tarefa

        public EstadoTarefa EstadoAtual { get; set; } = EstadoTarefa.ToDo; // Estado (Enum)

        public DateTime DataCriacao { get; set; } = DateTime.Now; // Data de criação

        public DateTime DataPrevistaInicio { get; set; } // Previsto
        public DateTime DataPrevistaFim { get; set; }

        public DateTime? DataRealInicio { get; set; } // Real (nullable)
        public DateTime? DataRealFim { get; set; }

        public int OrdemExecucao { get; set; } // Ordem definida pelo gestor

        // Foreign key para TipoTarefa
        public int TipoTarefaId { get; set; }
        public TipoTarefa TipoTarefa { get; set; }

        // Foreign key para Programador
        public int ProgramadorId { get; set; }
        public Programador Programador { get; set; }

        // Foreign key para Gestor
        public int GestorId { get; set; }
        public Gestor Gestor { get; set; }

        // Foreign key para Projeto
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }

        public int StoryPoints { get; set; } // SP da tarefa
    }
}
