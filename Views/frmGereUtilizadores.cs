using iTasks.Data.iTasks.Data;
using iTasks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks
{
    public partial class frmGereUtilizadores : Form
    {
        AppDbContext AppContext;
        private readonly NivelExperiencia nivelExperiencia;

        public Gestor Gestor { get; set; }
        public Programador Programador { get; set; }
        public frmGereUtilizadores()
        {
            InitializeComponent();
            AppContext = new AppDbContext();
            cbDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
            cbNivelProg.DataSource = Enum.GetValues(typeof(NivelExperiencia));
        }

        private void txtIdGestor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btGravarGestor_Click(object sender, EventArgs e){

            
        
            using (var DbContext = new AppDbContext())
            {
                String name = txtNomeGestor.Text;
                String username = txtUsernameGestor.Text;
                String password = txtPasswordGestor.Text;     // declarar gestor


                Departamento Departamento = (Departamento)cbDepartamento.SelectedItem;
                bool gereUtilizadores = chkGereUtilizadores.Checked;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Gestor gestor = new Gestor (name, username, password, Departamento, gereUtilizadores);
                DbContext.Gestores.Add(gestor);

                DbContext.SaveChanges();

                lstListaGestores.DataSource = null; 
                lstListaGestores.DataSource = DbContext.Gestores.ToList();

                //txtNomeGestor.Clear();
                //txtUsernameGestor.Clear();
                //txtPasswordGestor.Clear();

                
            }
        }


        private void btnCriarGestor_Click(object sender, EventArgs e)
        {
      
        }

        private void btGravarProg_Click(object sender, EventArgs e)
        {
            String name = txtNomeProg.Text;
            String username = txtUsernameProg.Text;
            String password = txtPasswordProg.Text;
            NivelExperiencia selectedItem = (NivelExperiencia)cbNivelProg.SelectedItem;
         
            

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Programador programador = new Programador(name, username, password, nivelExperiencia);
            AppContext.Programadores.Add(programador);

        }
    }



    }


