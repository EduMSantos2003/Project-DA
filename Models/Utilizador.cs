using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    class Utilizador
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public TipoUtilizador Tipo { get; set; }  

    }
}
