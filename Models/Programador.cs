using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTasks.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace iTasks.Models
{
    public class Programador : Utilizador
    {
        public NivelExperiencia NivelExperiencia { get; set; } // Enum: Junior / Senior


        // Construtor sem argumentos (obrigatório para EF)
        public Programador() { }

        // Construtor com argumentos — para usares nos formulários
        public Programador(string name, string username, string password, NivelExperiencia nivelExperiencia)
        {
            Name = name;
            Username = username;
            Password = password;
            NivelExperiencia = nivelExperiencia;
        }
    }
}