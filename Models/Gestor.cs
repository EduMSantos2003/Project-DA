using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    class Gestor : Utilizador
    {
        public ICollection<Programador> Programadores { get; set; }
        public ICollection<Tarefa> TarefasCriadas { get; set; }
    }
}
