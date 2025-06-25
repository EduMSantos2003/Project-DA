using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Data;
using iTasks.Models;

namespace iTasks
{
    public partial class frmConsultarTarefasConcluidas : Form
    {
        public frmConsultarTarefasConcluidas()
        {
            InitializeComponent();
            this.Load += frmConsultarTarefasConcluidas_Load;
        }

        private void frmConsultarTarefasConcluidas_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var query = context.Tarefas
                    .Where(t => t.EstadoAtual == EstadoTarefa.Done);

                if (Sessao.ProgramadorIdLogado != null)
                {
                    // PONTO 25 — Programador → só as SUAS
                    int progId = Sessao.ProgramadorIdLogado.Value;
                    query = query.Where(t => t.ProgramadorId == progId);

                    var lista = query
                        .Select(t => new
                        {
                            t.Id,
                            t.Descricao,
                            TipoTarefa = t.TipoTarefa.NomeTarefa,
                            DataRealInicio = t.DataRealInicio,
                            DataRealFim = t.DataRealFim,
                            DiasExecucao = DbFunctions.DiffDays(t.DataRealInicio, t.DataRealFim)
                        })
                        .OrderBy(t => t.DataRealFim)
                        .ToList();

                    gvTarefasConcluidas.DataSource = lista;
                }
                else if (Sessao.GestorIdLogado != null)
                {
                    // PONTO 26 — Gestor → tarefas que ele criou
                    int gestorId = Sessao.GestorIdLogado.Value;
                    query = query.Where(t => t.GestorId == gestorId);

                    var lista = query
                        .Select(t => new
                        {
                            t.Id,
                            t.Descricao,
                            Programador = t.Programador.Name,
                            DataPrevistaInicio = t.DataPrevistaInicio,
                            DataPrevistaFim = t.DataPrevistaFim,
                            DataRealInicio = t.DataRealInicio,
                            DataRealFim = t.DataRealFim,
                            DiasPrevistos = DbFunctions.DiffDays(t.DataPrevistaInicio, t.DataPrevistaFim),
                            DiasReais = DbFunctions.DiffDays(t.DataRealInicio, t.DataRealFim)
                        })
                        .OrderBy(t => t.DataRealFim)
                        .ToList();

                    gvTarefasConcluidas.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("Acesso Negado!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}