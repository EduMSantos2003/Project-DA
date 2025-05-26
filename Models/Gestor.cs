using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iTasks.Models
{
    public class Gestor : Utilizador
    {   

        public Departamento Departamento { get; set; }

        public List<string> Projetos { get; set; }

        public bool GereUtilizadores { get; set; }

        public Gestor(string name, string username, string password,Departamento departamento, bool chkGereUtilizadores) : base(name, username, password)
        {
            this.GereUtilizadores = chkGereUtilizadores;
            this.Departamento = departamento;

          
        }

        public Gestor()
        {
        }

        public void AdicionarGestor(string projeto)
        {
            Projetos.Add(projeto);
        }

    }

}
