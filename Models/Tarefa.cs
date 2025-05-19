using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public EstadoTarefa EstadoAtual { get; set; } = EstadoTarefa.ToDo;

        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataPrevistaInicio { get; set; }
        public DateTime? DataPrevistaFim { get; set; }
        public DateTime? DataRealInicio { get; set; }
        public DateTime? DataRealFim { get; set; }

        public int OrdemExecucao { get; set; }

        public int TipoTarefaId { get; set; }
        public virtual TipoTarefa TipoTarefa { get; set; }

        public int GestorId { get; set; }
        public virtual Gestor Gestor { get; set; }

        public int ProgramadorId { get; set; }
        public virtual Programador Programador { get; set; }

        public int StoryPoints { get; set; }
    }
}
