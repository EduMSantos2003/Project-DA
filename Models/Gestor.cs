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
    public class Gestor : Utilizador
    {
        public Departamento Departamento { get; set; }
        public bool GereUtilizadores { get; set; }

        // Construtor sem argumentos (obrigatório para EF)
        public Gestor() { }

        // Construtor com argumentos — para usares nos formulários
        public Gestor(string name, string username, string password, Departamento departamento, bool gereUtilizadores)
        {
            Name = name;
            Username = username;
            Password = password;
            Departamento = departamento;
            GereUtilizadores = gereUtilizadores;
        }
    }
}
