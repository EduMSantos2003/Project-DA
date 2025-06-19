using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iTasks
{
    public partial class frmLogin : Form
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }

        public frmLogin()
        {
            InitializeComponent();

        }
        public class AppDbContext : DbContext
        {
            public DbSet<UserLogin> UserLogins { get; set; }

            // Lembre-se de configurar sua connection string no OnConfiguring se necessário
        }
        public class UserLogin
        {
            public int Id { get; set; } // Deve ter uma chave primária
            public string UserName { get; set; }
            public DateTime LoginTime { get; set; }
        }


        /*private void btLogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;

            if (name == "" && password == "") 
           {
                MessageBox.Show("Login realizado com sucesso!");
                frmKanban secondForm = new frmKanban();
                secondForm.UserName = name;
                secondForm.Show();
                
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
                return;
            }
        }*/

        private void btLogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;

            if (name == "" && password == "")
            {
                MessageBox.Show("Login realizado com sucesso!");

                // Salvar no banco
                using (var context = new AppDbContext())
                {
                    var login = new UserLogin
                    {
                        UserName = name,
                        LoginTime = DateTime.Now
                    };

                    context.UserLogins.Add(login);
                    context.SaveChanges();
                }

                frmKanban secondForm = new frmKanban();
                secondForm.UserName = name;
                secondForm.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
                return;
            }
        }
    }
}