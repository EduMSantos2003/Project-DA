using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Escreve uma descrição para a tarefa!");
                return;
            }

            // Criar o texto da tarefa com o ID automático
            string tarefa = "ID: " + proximoId + " - " + txtDesc.Text;
            lstLista.Items.Add(tarefa);

            // Aumentar o ID para a próxima tarefa
            proximoId++;

            // Limpar o campo de descrição
            txtDesc.Clear();
            txtDesc.Focus();

            // Atualizar o campo txtId para mostrar o ID (opcional)
            txtId.Text = proximoId.ToString();
        }

    }
}
