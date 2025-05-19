using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    public class Programador : Utilizador
    {
        public NivelExperiencia Nivel { get; set; }
        public Departamento Departamento { get; set; }

        public int GestorId { get; set; }
        public virtual Gestor Gestor { get; set; }

        public virtual ICollection<Tarefa> TarefasExecutadas { get; set; }
    }

}
