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

        public int GestorId { get; set; } // FK para o Gestor
        public Gestor Gestor { get; set; } // Navegação para o Gestor

        // Construtor sem argumentos (obrigatório para EF)
        public Programador() { }

        // Construtor com argumentos — para usares nos formulários
        public Programador(string name, string username, string password, NivelExperiencia nivelExperiencia, int gestorId)
        {
            Name = name;
            Username = username;
            Password = password;
            NivelExperiencia = nivelExperiencia;
            GestorId = gestorId;
        }
    }
}