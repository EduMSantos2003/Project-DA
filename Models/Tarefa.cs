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
        internal Gestor GestorId;

        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public EstadoTarefa EstadoAtual { get; set; } = EstadoTarefa.ToDo; //Enum

        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataPrevistaInicio { get; set; }
        public DateTime DataPrevistaFim { get; set; }
        public DateTime DataRealInicio { get; set; }
        public DateTime DataRealFim { get; set; }

        public int OrdemExecucao { get; set; }

        public  TipoTarefa TipoTarefa { get; set; }
        /*public int TipoTarefaId { get; set; }
        public virtual TipoTarefa TipoTarefa { get; set; }*/

        //public  Gestor Gestor { get; set; }

        public Programador Programador { get; set; }

        public int StoryPoints { get; set; }
        /*public int ProgramadorId { get; set; }
        public virtual Programador Programador { get; set; }

        public int GestorId { get; set; }
        public virtual Gestor Gestor { get; set; }

        public DateTime? DataRealInicio { get; set; }
        public DateTime? DataRealFim { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;*/
    }
}
