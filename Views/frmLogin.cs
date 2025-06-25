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
using iTasks.Data;
using iTasks.Models;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iTasks
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;

            using (var context = new AppDbContext())
            {
                // Tentar login como Gestor
                var gestor = context.Gestores
                    .FirstOrDefault(g => g.Username == name && g.Password == password);

                if (gestor != null)
                {
                    // Guardar quem fez login
                    Sessao.GestorIdLogado = gestor.Id;
                    Sessao.ProgramadorIdLogado = null; // garantir que não fica valor antigo

                    // Abrir Kanban
                    frmKanban secondForm = new frmKanban();
                    secondForm.UserName = gestor.Username;
                    secondForm.Show();
                    this.Hide();
                    return;
                }

                // Se não encontrou um Gestor → tenta como Programador
                var programador = context.Programadores
                    .FirstOrDefault(p => p.Username == name && p.Password == password);

                if (programador != null)
                {
                    // Guardar quem fez login
                    Sessao.ProgramadorIdLogado = programador.Id;
                    Sessao.GestorIdLogado = null; // garantir que não fica valor antigo

                    MessageBox.Show("Login como Programador realizado com sucesso!");

                    // Abrir Kanban
                    frmKanban secondForm = new frmKanban();
                    secondForm.UserName = programador.Username;
                    secondForm.Show();
                    this.Hide();
                    return;
                }

                // Se não encontrou nem Gestor nem Programador:
                MessageBox.Show("Login ou senha inválidos!");
            }
        }

    }
}
