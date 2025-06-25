using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Models;
using iTasks.Data;

namespace iTasks
{
    public partial class frmGereTiposTarefas : Form
    {
        int proximoId = 1;

        public frmGereTiposTarefas()
        {
            InitializeComponent();

            lstLista.SelectedIndexChanged += lstLista_SelectedIndexChanged; 

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Escreve uma descrição para o Tipo de Tarefa!");
                return;
            }

            using (var context = new AppDbContext())
            {
                TipoTarefa novaTipo = new TipoTarefa
                {
                    NomeTarefa = txtDesc.Text
                };

                context.TiposTarefas.Add(novaTipo);
                context.SaveChanges();

                // Atualizar a lista
                lstLista.DataSource = null;
                lstLista.DataSource = context.TiposTarefas.ToList();
                lstLista.DisplayMember = "NomeTarefa";
            }

            // Limpar campos
            txtDesc.Clear();
            txtDesc.Focus();
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
{
            if (lstLista.SelectedIndex == -1)
            {
                // Nada selecionado
                return;
            }

            // Obter o item selecionado e converter para TipoTarefa (ou o tipo correto)
            TipoTarefa tipoSelecionado = (TipoTarefa)lstLista.SelectedItem;

            // Preencher os campos do formulário
            txtId.Text = tipoSelecionado.Id.ToString();
            txtDesc.Text = tipoSelecionado.NomeTarefa;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
