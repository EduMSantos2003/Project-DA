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


    }
}
