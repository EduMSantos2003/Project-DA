using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Data;
using iTasks.Models;

namespace iTasks
{

    public partial class frmDetalhesTarefa : Form
    {
        private void frmDetalhesTarefa_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                cbTipoTarefa.DataSource = context.TiposTarefas.ToList();
                cbTipoTarefa.DisplayMember = "NomeTarefa";

                cbProgramador.DataSource = context.Programadores.ToList();
                cbProgramador.DisplayMember = "Name";
            }
        }

        public frmDetalhesTarefa()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var novaTarefa = new Tarefa
                {
                    Descricao = txtDesc.Text,
                    TipoTarefa = (TipoTarefa)cbTipoTarefa.SelectedItem,
                    Programador = (Programador)cbProgramador.SelectedItem,
                    DataPrevistaInicio = dtInicio.Value,
                    DataPrevistaFim = dtFim.Value,
                    //OrdemExecucao = txtOrdem.Value,
                    //StoryPoints = txtStoryPoints.Text,
                    EstadoAtual = EstadoTarefa.ToDo,
                    DataCriacao = DateTime.Now
                };

                context.Tarefas.Add(novaTarefa);
                //context.SaveChanges();

                MessageBox.Show("Tarefa criada com sucesso!");
                this.Close();
            }
        }

    }
}
