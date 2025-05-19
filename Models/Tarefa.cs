using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    class Tarefa
    {
        public int Id { get; set; }
        public int IdGestor { get; set; }
        public int IdProgramador { get; set; }
        public int OrdemExecucao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPrevistaInicio { get; set; }
        public DateTime DataPrevistaFim { get; set; }
        public int IdTipoTarefa { get; set; }
        public int StoryPoints { get; set; }
        public DateTime DataRealIncio { get; set; }
        public DateTime DataRealFim { get; set; }
        public DateTime DataRealCricao { get; set; }
        public string EstadoAtual { get; set; }

    }
}
