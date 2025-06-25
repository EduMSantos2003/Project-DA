using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Data;
using iTasks.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iTasks
{
    public partial class frmKanban : Form
    {
        public string UserName { get; set; }

        public frmKanban()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmKanban_Load);
        }

        private void frmKanban_Load(object sender, EventArgs e)
        {
            lstTodo.SelectionMode = SelectionMode.One;
            lstDoing.SelectionMode = SelectionMode.One;
            lstDone.SelectionMode = SelectionMode.One;
            label1.Text = "Bem-vindo, " + UserName;
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            using (var context = new AppDbContext())
            {
                // ToDo
                lstTodo.DataSource = context.Tarefas
                    .Where(t => t.EstadoAtual == EstadoTarefa.ToDo)
                    .ToList();
                lstTodo.DisplayMember = "Descricao";

                // Doing
                lstDoing.DataSource = context.Tarefas
                    .Where(t => t.EstadoAtual == EstadoTarefa.Doing)
                    .ToList();
                lstDoing.DisplayMember = "Descricao";

                // Done
                lstDone.DataSource = context.Tarefas
                    .Where(t => t.EstadoAtual == EstadoTarefa.Done)
                    .ToList();
                lstDone.DisplayMember = "Descricao";
            }
        }

        private void btNova_Click(object sender, EventArgs e)
        {
            if (Sessao.GestorIdLogado != null)
            {
                int gestorId = Sessao.GestorIdLogado.Value;

                frmDetalhesTarefa frm = new frmDetalhesTarefa(gestorId);
                frm.ShowDialog();

                CarregarTarefas(); // Atualizar o Kanban
            }
            else
            {
                MessageBox.Show("Apenas um Gestor pode criar novas Tarefas!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gerirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGereUtilizadores = new frmGereUtilizadores();
            frmGereUtilizadores.ShowDialog();
        }

        private void gerirTiposDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGereTiposTarefas = new frmGereTiposTarefas();
            frmGereTiposTarefas.ShowDialog();
        }

        private void tarefasTerminadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmConsultarTarefasConcluidas = new frmConsultarTarefasConcluidas();
            frmConsultarTarefasConcluidas.ShowDialog();
        }

        private void tarefasEmCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmConsultaTarefasEmCurso = new frmConsultaTarefasEmCurso();
            frmConsultaTarefasEmCurso.ShowDialog();
        }

        private void lstTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se quiseres no futuro, aqui podes mostrar detalhes da Tarefa selecionada
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // opcional
        }

        private void btSetDoing_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = (Tarefa)lstTodo.SelectedItem;

            if (tarefa == null)
            {
                MessageBox.Show("Selecione uma Tarefa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tarefa.EstadoAtual == EstadoTarefa.Done)
            {
                MessageBox.Show("Esta Tarefa está concluída e não pode ser alterada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new AppDbContext())
            {
                var t = context.Tarefas.FirstOrDefault(x => x.Id == tarefa.Id);

                if (t != null)
                {
                    // Verificar máx 2 Doing
                    int countDoing = context.Tarefas
                        .Count(task => task.ProgramadorId == t.ProgramadorId && task.EstadoAtual == EstadoTarefa.Doing);

                    if (countDoing >= 2)
                    {
                        MessageBox.Show("Este Programador já tem 2 Tarefas em Doing!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Verificar Ordem de Execução
                    bool existeTarefaPendente = context.Tarefas
                        .Any(task => task.ProgramadorId == t.ProgramadorId
                                  && task.EstadoAtual != EstadoTarefa.Done
                                  && task.OrdemExecucao < t.OrdemExecucao);

                    if (existeTarefaPendente)
                    {
                        MessageBox.Show("Este Programador tem Tarefas anteriores que ainda não foram concluídas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Passar para Doing
                    t.EstadoAtual = EstadoTarefa.Doing;

                    if (t.DataRealInicio == null)
                    {
                        t.DataRealInicio = DateTime.Now;
                    }

                    context.SaveChanges();
                    CarregarTarefas();
                }
            }
        }




        private void btSetTodo_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = (Tarefa)lstDoing.SelectedItem;

            if (tarefa == null)
            {
                MessageBox.Show("Selecione uma Tarefa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tarefa.EstadoAtual == EstadoTarefa.Done)
            {
                MessageBox.Show("Esta Tarefa está concluída e não pode ser alterada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new AppDbContext())
            {
                var t = context.Tarefas.FirstOrDefault(x => x.Id == tarefa.Id);

                if (t != null)
                {
                    t.EstadoAtual = EstadoTarefa.ToDo;

                    context.SaveChanges();
                    CarregarTarefas();
                }
            }
        }


        private void btSetDone_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = (Tarefa)lstDoing.SelectedItem;

            if (tarefa == null)
            {
                MessageBox.Show("Selecione uma Tarefa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tarefa.EstadoAtual == EstadoTarefa.Done)
            {
                MessageBox.Show("Esta Tarefa já está concluída!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new AppDbContext())
            {
                var t = context.Tarefas.FirstOrDefault(x => x.Id == tarefa.Id);

                if (t != null)
                {
                    // Verificar Ordem de Execução
                    bool existeTarefaPendente = context.Tarefas
                        .Any(task => task.ProgramadorId == t.ProgramadorId
                                  && task.EstadoAtual != EstadoTarefa.Done
                                  && task.OrdemExecucao < t.OrdemExecucao);

                    if (existeTarefaPendente)
                    {
                        MessageBox.Show("Este Programador tem Tarefas anteriores que ainda não foram concluídas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Passar para Done
                    t.EstadoAtual = EstadoTarefa.Done;

                    if (t.DataRealFim == null)
                    {
                        t.DataRealFim = DateTime.Now;
                    }

                    context.SaveChanges();
                    CarregarTarefas();
                }
            }
        }



        private void btVerDetalhes_Click(object sender, EventArgs e)
        {
            // Ver se alguma tarefa está selecionada em qualquer lista
            Tarefa tarefaSelecionada = null;

            if (lstTodo.SelectedItem != null)
                tarefaSelecionada = (Tarefa)lstTodo.SelectedItem;
            else if (lstDoing.SelectedItem != null)
                tarefaSelecionada = (Tarefa)lstDoing.SelectedItem;
            else if (lstDone.SelectedItem != null)
                tarefaSelecionada = (Tarefa)lstDone.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Tarefa para ver os detalhes!");
                return;
            }

            // Abrir Detalhes em modo ReadOnly
            frmDetalhesTarefa frm = new frmDetalhesTarefa(tarefaSelecionada, modoReadOnly: true);
            frm.ShowDialog();
        }

        private void btPrevisao_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                // Passo 1 — calcular médias reais por StoryPoints
                var mediasPorSP = context.Tarefas
                    .Where(t => t.EstadoAtual == EstadoTarefa.Done && t.DataRealInicio != null && t.DataRealFim != null)
                    .GroupBy(t => t.StoryPoints)
                    .Select(g => new
                    {
                        StoryPoints = g.Key,
                        MediaHoras = g.Average(t => DbFunctions.DiffHours(t.DataRealInicio, t.DataRealFim))
                    })
                    .ToList();

                // Passo 2 — somar previsão para as ToDo
                var tarefasToDo = context.Tarefas
                    .Where(t => t.EstadoAtual == EstadoTarefa.ToDo)
                    .ToList();

                double totalHoras = 0;

                foreach (var tarefa in tarefasToDo)
                {
                    // Procurar média com StoryPoints exatos
                    var media = mediasPorSP.FirstOrDefault(m => m.StoryPoints == tarefa.StoryPoints);

                    if (media == null)
                    {
                        // Se não existe → procurar mais próximo
                        media = mediasPorSP.OrderBy(m => Math.Abs(m.StoryPoints - tarefa.StoryPoints)).FirstOrDefault();
                    }

                    if (media != null)
                    {
                        totalHoras += media.MediaHoras ?? 0;
                    }
                }

                MessageBox.Show($"Tempo estimado para concluir as tarefas ToDo: {totalHoras:F1} horas", "Previsão de Conclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exportarParaCSVToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Sessao.GestorIdLogado == null)
            {
                MessageBox.Show("Apenas Gestores podem exportar para CSV!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                int gestorId = Sessao.GestorIdLogado.Value;

                var lista = context.Tarefas
                    .Where(t => t.GestorId == gestorId && t.EstadoAtual == EstadoTarefa.Done)
                    .Select(t => new
                    {
                        Programador = t.Programador.Name,
                        t.Descricao,
                        t.DataPrevistaInicio,
                        t.DataPrevistaFim,
                        TipoTarefa = t.TipoTarefa.NomeTarefa,
                        t.DataRealInicio,
                        t.DataRealFim
                    })
                    .OrderBy(t => t.DataRealFim)
                    .ToList();

                if (!lista.Any())
                {
                    MessageBox.Show("Não existem Tarefas concluídas para exportar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Guardar o ficheiro
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "TarefasConcluidas.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    // Cabeçalho
                    sb.AppendLine("Programador;Descricao;DataPrevistaInicio;DataPrevistaFim;TipoTarefa;DataRealInicio;DataRealFim");

                    // Linhas
                    foreach (var t in lista)
                    {
                        sb.AppendLine($"{t.Programador};{t.Descricao};{t.DataPrevistaInicio:yyyy-MM-dd};{t.DataPrevistaFim:yyyy-MM-dd};{t.TipoTarefa};{t.DataRealInicio:yyyy-MM-dd HH:mm};{t.DataRealFim:yyyy-MM-dd HH:mm}");
                    }

                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show("CSV exportado com sucesso!", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}