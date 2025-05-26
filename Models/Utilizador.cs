using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace iTasks.Models
{
    public class Utilizador  
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public IList<Utilizador> utilizadores { get; set; }


        public Utilizador()
        {
            utilizadores = new List<Utilizador>();
        }

        public Utilizador(string name, string username, string password) : this()
        {
            Name = name;
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return Username;
        }

    }

     


}
    