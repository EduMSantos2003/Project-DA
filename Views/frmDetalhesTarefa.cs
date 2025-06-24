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
        private int gestorIdAtual;

        public Tarefa TarefaParaEditar { get; set; }



        public frmDetalhesTarefa(int gestorId)
        {
            InitializeComponent();
            this.gestorIdAtual = gestorId;

            cbTipoTarefa.SelectedIndexChanged += cbTipoTarefa_SelectedIndexChanged;


        }

        private void frmDetalhesTarefa_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {

                cbTipoTarefa.DataSource = context.TiposTarefas.ToList();
                cbTipoTarefa.DisplayMember = "NomeTarefa";
                cbTipoTarefa.ValueMember = "Id";

                cbProgramador.DataSource = context.Programadores.ToList();
                cbProgramador.DisplayMember = "Name";
                cbProgramador.ValueMember = "Id";

                cbProjeto.DataSource = context.Projetos.ToList();
                cbProjeto.DisplayMember = "Descricao";
                cbProjeto.ValueMember = "Id";

                if (TarefaParaEditar != null)
                {
                    txtDesc.Text = TarefaParaEditar.Descricao;
                    txtOrdem.Text = TarefaParaEditar.OrdemExecucao.ToString();
                    txtStoryPoints.Text = TarefaParaEditar.StoryPoints.ToString();

                    cbTipoTarefa.SelectedValue = TarefaParaEditar.TipoTarefaId;
                    cbProgramador.SelectedValue = TarefaParaEditar.ProgramadorId;
                    cbProjeto.SelectedValue = TarefaParaEditar.ProjetoId;

                    dtInicio.Value = TarefaParaEditar.DataPrevistaInicio;
                    dtFim.Value = TarefaParaEditar.DataPrevistaFim;

                }
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("A descrição é obrigatória.");
                return;
            }

            if (cbTipoTarefa.SelectedItem == null || cbProgramador.SelectedItem == null || cbProjeto.SelectedItem == null)
            {
                MessageBox.Show("Seleciona o Tipo de Tarefa, o Programador e o Projeto.");
                return;
            }

            int ordem = 0;
            if (!int.TryParse(txtOrdem.Text, out ordem))
            {
                MessageBox.Show("Ordem de execução inválida!");
                return;
            }

            int storyPoints = 0;
            if (!int.TryParse(txtStoryPoints.Text, out storyPoints))
            {
                MessageBox.Show("StoryPoints inválidos!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    int programadorId = (int)cbProgramador.SelectedValue;

                    bool ordemDuplicada = context.Tarefas.Any(t => t.ProgramadorId == programadorId
                                                                && t.OrdemExecucao == ordem);

                    if (ordemDuplicada)
                    {
                        MessageBox.Show("Já existe uma tarefa com esta Ordem de Execução para este Programador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var novaTarefa = new Tarefa
                    {
                        Descricao = txtDesc.Text,
                        EstadoAtual = EstadoTarefa.ToDo,
                        DataCriacao = DateTime.Now,
                        DataPrevistaInicio = dtInicio.Value,
                        DataPrevistaFim = dtFim.Value,

                        TipoTarefaId = (int)cbTipoTarefa.SelectedValue,
                        ProgramadorId = programadorId,
                        ProjetoId = (int)cbProjeto.SelectedValue,

                        StoryPoints = storyPoints,
                        OrdemExecucao = ordem,

                        GestorId = gestorIdAtual
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

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbProgramador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoTarefa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoTarefa.SelectedItem is TipoTarefa tipoSelecionado)
            {
                txtId.Text = tipoSelecionado.Id.ToString();

               
                    txtId.Text = tipoSelecionado.Id.ToString();

                    // Só alterar datas se for uma nova tarefa
                    if (TarefaParaEditar == null)
                    {
                        dtInicio.Value = DateTime.Today;
                        dtFim.Value = DateTime.Today.AddDays(10);
                    }
                
            }

        }


    }
}
