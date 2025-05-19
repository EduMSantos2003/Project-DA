using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iTasks.Models
{
    public class Gestor : Utilizador
    {
        public virtual ICollection<Programador> Programadores { get; set; }
        public virtual ICollection<Tarefa> TarefasCriadas { get; set; }
    }
}
