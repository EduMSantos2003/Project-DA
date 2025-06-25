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
        private Tarefa tarefaSelecionada;
        private bool isReadOnly;

        // Construtor para criar nova Tarefa (Gestor)
        public frmDetalhesTarefa(int gestorId)
        {
            InitializeComponent();
            this.gestorIdAtual = gestorId;
            this.isReadOnly = false; // não é ReadOnly
        }

        // Construtor para Ver Detalhes (Programador ou Gestor)
        public frmDetalhesTarefa(Tarefa tarefa, bool modoReadOnly)
        {
            InitializeComponent();

            this.tarefaSelecionada = tarefa;
            this.isReadOnly = modoReadOnly;
        }

        private void frmDetalhesTarefa_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                cbTipoTarefa.DataSource = context.TiposTarefas.ToList();
                cbTipoTarefa.DisplayMember = "NomeTarefa";
                cbTipoTarefa.ValueMember = "Id";

                cbProgramador.DataSource = context.Programadores
                    .Where(p => p.GestorId == gestorIdAtual)
                    .ToList();
                cbProgramador.DisplayMember = "Name";
                cbProgramador.ValueMember = "Id";

                if (tarefaSelecionada != null)
                {
                    // Preencher os campos com os dados da Tarefa
                    txtDesc.Text = tarefaSelecionada.Descricao;
                    txtOrdem.Text = tarefaSelecionada.OrdemExecucao.ToString();
                    txtStoryPoints.Text = tarefaSelecionada.StoryPoints.ToString();

                    cbTipoTarefa.SelectedValue = tarefaSelecionada.TipoTarefaId;
                    cbProgramador.SelectedValue = tarefaSelecionada.ProgramadorId;

                    dtInicio.Value = tarefaSelecionada.DataPrevistaInicio;
                    dtFim.Value = tarefaSelecionada.DataPrevistaFim;

                    txtEstado.Text = tarefaSelecionada.EstadoAtual.ToString();
                    txtDataCriacao.Text = tarefaSelecionada.DataCriacao.ToString();
                    txtDataRealini.Text = tarefaSelecionada.DataRealInicio?.ToString() ?? "";
                    txtdataRealFim.Text = tarefaSelecionada.DataRealFim?.ToString() ?? "";

                    // Se for modo ReadOnly — bloquear os campos
                    if (isReadOnly)
                    {
                        txtDesc.ReadOnly = true;
                        txtOrdem.ReadOnly = true;
                        txtStoryPoints.ReadOnly = true;

                        cbTipoTarefa.Enabled = false;
                        cbProgramador.Enabled = false;

                        dtInicio.Enabled = false;
                        dtFim.Enabled = false;

                        btGravar.Enabled = false; // não pode gravar!
                    }
                }
                else
                {
                    // Nova Tarefa — valores default
                    dtInicio.Value = DateTime.Today;
                    dtFim.Value = DateTime.Today.AddDays(10);
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

                if (tarefaSelecionada == null)
                {
                    dtInicio.Value = DateTime.Today;
                    dtFim.Value = DateTime.Today.AddDays(10);
                }
            }
        }
    }
}
