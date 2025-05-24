using iTasks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks
{
    public partial class frmGereUtilizadores : Form
    {
        public frmGereUtilizadores()
        {
            InitializeComponent();
            
        }

        private void txtIdGestor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btGravarGestor_Click(object sender, EventArgs e)

        { }
        private void btnCriarGestor_Click(object sender, EventArgs e)
        {
            string name = txtNomeGestor.Text;
            string username = txtUsernameGestor.Text;
            string password = txtPasswordGestor.Text;
            string tipo = cbDepartamento.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Utilizador utilizador = new Utilizador(name, username, password );
            //AppContext.Utilizador.Add(Utilizador);

            //AppContext.SaveChanges();
            //                                          adicionar a listbox de gestores
            //lstListaGestores.DataSource = null;
            //lstListaGestores.DataSource = AppContext.Clients.ToList();



            MessageBox.Show("Gestor criado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar os campos
                txtNomeGestor.Clear();
                txtUsernameGestor.Clear();
                txtPasswordGestor.Clear();
            }
           
        }



    }


