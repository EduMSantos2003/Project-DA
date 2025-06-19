using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    public class Programador : Utilizador
    {

        public Programador()
        {
        }
        public NivelExperiencia NivelExperiencia { get; set; }

        public Programador (string name, string username, string password, NivelExperiencia nivelExperiencia) : base(name, username, password)
        {
            this.NivelExperiencia = NivelExperiencia;
           
        }
    }

}
