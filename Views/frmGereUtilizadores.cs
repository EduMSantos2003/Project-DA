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

        private void btGravarGestor_Click(object sender, EventArgs e)
        {   
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


        private void btEditarGestor_Click(object sender, EventArgs e)
        {
            if (lstListaGestores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um gestor da lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var DbContext = new AppDbContext())
            {
                Gestor selecionado = (Gestor)lstListaGestores.SelectedItem;
                Gestor gestor = DbContext.Gestores.FirstOrDefault(g => g.Id == selecionado.Id);

                if (gestor != null)
                {
                    String name = txtNomeGestor.Text;
                    String Username = txtUsernameGestor.Text;
                    String Password = txtPasswordGestor.Text;
                    gestor.Departamento = (Departamento)cbDepartamento.SelectedItem;
                    gestor.GereUtilizadores = chkGereUtilizadores.Checked;

                    DbContext.SaveChanges();

                    lstListaGestores.DataSource = null;
                    lstListaGestores.DataSource = DbContext.Gestores.ToList();
                    //AtualizarLista();
                    //LimparCampos();

                    MessageBox.Show("Gestor editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //String name = txtNomeGestor.Text;
        //gestor.Username = txtUsernameGestor.Text;
        //gestor.Password = txtPasswordGestor.Text;
        //gestor.Departamento = (Departamento) cbDepartamento.SelectedItem;
        //gestor.GereUtilizadores = chkGereUtilizadores.Checked;

        private void btApagarGestor_Click(object sender, EventArgs e)
        {
            if (lstListaGestores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um gestor para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var DbContext = new AppDbContext())
            {
                Gestor selecionado = (Gestor)lstListaGestores.SelectedItem;
                Gestor gestor = DbContext.Gestores.FirstOrDefault(g => g.Id == selecionado.Id);

                if (gestor != null)
                {
                    var confirm = MessageBox.Show("Tem certeza que deseja remover este gestor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        DbContext.Gestores.Remove(gestor);
                        DbContext.SaveChanges();

                        lstListaGestores.DataSource = null;
                        lstListaGestores.DataSource = DbContext.Gestores.ToList();
                        //AtualizarLista();
                        //LimparCampos();

                        MessageBox.Show("Gestor removido com sucesso.", "Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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


