using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    public class TipoTarefa
    {
        public TipoTarefa()
        {
        }
        
        [Key]
        public int IdTarefa { get; set; }
        public string NomeTarefa { get; set; }

    }
}
