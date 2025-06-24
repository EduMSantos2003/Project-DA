using iTasks.Data;
using iTasks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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


            lstListaGestores.DataSource = null;
            lstListaGestores.DataSource = AppContext.Gestores.ToList();

            lstListaProgramadores.DataSource = null;
            lstListaProgramadores.DataSource = AppContext.Programadores.ToList();
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
                    /*String name = txtNomeGestor.Text;
                    String Username = txtUsernameGestor.Text;
                    String Password = txtPasswordGestor.Text;
                    gestor.Departamento = (Departamento)cbDepartamento.SelectedItem;
                    gestor.GereUtilizadores = chkGereUtilizadores.Checked;*/

                    gestor.Name = txtNomeGestor.Text;
                    gestor.Username = txtUsernameGestor.Text;
                    gestor.Password = txtPasswordGestor.Text;
                    gestor.Departamento = (Departamento) cbDepartamento.SelectedItem;
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



        private void btGravarProg_Click(object sender, EventArgs e)
        {
            using (var DbContext = new AppDbContext())
            {
                string name = txtNomeProg.Text;
                string username = txtUsernameProg.Text;
                string password = txtPasswordProg.Text;
                NivelExperiencia selectedItem = (NivelExperiencia)cbNivelProg.SelectedItem;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Programador programador = new Programador(name, username, password, selectedItem);
                DbContext.Programadores.Add(programador);
              
                DbContext.SaveChanges();

                lstListaProgramadores.DataSource = null;
                lstListaProgramadores.DataSource = DbContext.Programadores.ToList();

                // Limpar os campos (opcional)
                txtNomeProg.Clear();
                txtUsernameProg.Clear();
                txtPasswordProg.Clear();
                cbNivelProg.SelectedIndex = 0;

                MessageBox.Show("Programador criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstListaGestores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstListaGestores.SelectedIndex;
            if (index == -1)
            {
                //  por dados a vazio

                return;
            }


            // Converter o item selecionado para Gestor
            Gestor gestorSelecionado = (Gestor)lstListaGestores.SelectedItem;

            // Preencher os campos do formulário com os dados do gestor
            txtIdGestor.Text = gestorSelecionado.Id.ToString();
            txtNomeGestor.Text = gestorSelecionado.Name;
            txtUsernameGestor.Text = gestorSelecionado.Username;
            txtPasswordGestor.Text = gestorSelecionado.Password;
            cbDepartamento.SelectedItem = gestorSelecionado.Departamento;
            chkGereUtilizadores.Checked = gestorSelecionado.GereUtilizadores;





        }

        public void upDate_load()
        {
            cbGestorProg.DataSource = null;
            cbGestorProg.DataSource = AppContext.Gestores.ToList();
            cbGestorProg.DisplayMember = "Nome"; // para mostrar o nome


        }

        private void frmGereUtilizadores_Load(object sender, EventArgs e)
        {
            upDate_load();
        }


        private void cbGestorProg_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new AppDbContext()) 
            {
                cbGestorProg.DataSource = context.Gestores.ToList();
                cbGestorProg.DisplayMember = "Username";
                cbGestorProg.ValueMember = "Id";
            }

        }


        private void btEditarProg_Click(object sender, EventArgs e)
        {
            if (lstListaProgramadores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um gestor da lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var DbContext = new AppDbContext())
            {
                Programador selecionado = (Programador)lstListaProgramadores.SelectedItem;
                Programador programador = DbContext.Programadores.FirstOrDefault(g => g.Id == selecionado.Id);

                if (programador != null)
                {


                    programador.Name = txtNomeProg.Text;
                    programador.Username = txtUsernameProg.Text;
                    programador.Password = txtPasswordProg.Text;

                    DbContext.SaveChanges();

                    lstListaProgramadores.DataSource = null;
                    lstListaProgramadores.DataSource = DbContext.Programadores.ToList();
                    //AtualizarLista();
                    //LimparCampos();

                    MessageBox.Show("Gestor editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lstListaProgramadores_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
            int index = lstListaProgramadores.SelectedIndex;
            if (index == -1)
            {
                //  por dados a vazio

                return;
            }


            // Converter o item selecionado para Prog
            Programador programadorSelecionado = (Programador)lstListaProgramadores.SelectedItem;

            // Preencher os campos do formulário com os dados do prog
            txtIdProg.Text = programadorSelecionado.Id.ToString();
            txtNomeProg.Text = programadorSelecionado.Name;
            txtUsernameProg.Text = programadorSelecionado.Username;
            txtPasswordProg.Text = programadorSelecionado.Password;
            cbNivelProg.SelectedItem = programadorSelecionado.NivelExperiencia;
            cbGestorProg.SelectedItem = programadorSelecionado.Username;

        }

        private void btApagarProg_Click(object sender, EventArgs e)
        {
            if (lstListaProgramadores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um programador para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var DbContext = new AppDbContext())
            {
                Programador selecionado = (Programador)lstListaProgramadores.SelectedItem;
                Programador programador = DbContext.Programadores.FirstOrDefault(g => g.Id == selecionado.Id);

                if (programador != null)
                {
                    var confirm = MessageBox.Show("Tem certeza que deseja remover este programador?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        DbContext.Programadores.Remove(programador);
                        DbContext.SaveChanges();

                        lstListaProgramadores.DataSource = null;
                        lstListaProgramadores.DataSource = DbContext.Programadores.ToList();
                        //AtualizarLista();
                        //LimparCampos();

                        MessageBox.Show("Programador removido com sucesso.", "Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

       
    }
}


