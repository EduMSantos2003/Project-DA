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
        private void FrmDetalhesTarefa_Load(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("A descrição é obrigatória.");
                return;
            }

            if (cbTipoTarefa.SelectedItem == null || cbProgramador.SelectedItem == null)
            {
                MessageBox.Show("Seleciona o tipo de tarefa e o programador.");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var tipoTarefaSelecionado = (TipoTarefa)cbTipoTarefa.SelectedItem;
                    var programadorSelecionado = (Programador)cbProgramador.SelectedItem;
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
                    context.SaveChanges();

                    MessageBox.Show("Tarefa criada com sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                var erroInterno = ex.InnerException?.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Erro ao gravar: " + erroInterno);
            }
        }







        /*private void btGravar_Click(object sender, EventArgs e)
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
                //this.Close();
            }

            /*private void btnGravar_Click(object sender, EventArgs e)
            {
            using (var context = new AppDbContext())
            {
                var tarefa = new Tarefa
                {
                    DataPrevistaInicio = dtpPrevistaInicio.Value,
                    DataPrevistaFim = dtpPrevistaFim.Value,
                    StoryPoints = (int)numStoryPoints.Value,
                    OrdemExecucao = (int)numOrdemExecucao.Value,
                    TipoTarefaId = ((TipoTarefa)cbTipoTarefa.SelectedItem).IdTarefa,
                    Estado = EstadoAtual.ToDo,
                    GestorId = ((Gestor)FrmLogin.UtilizadorLogado).Id,
                    ProgramadorId = ((Programador)cbProgramador.SelectedItem).Id,
                };
            }
        }
        }*/

    }
}
