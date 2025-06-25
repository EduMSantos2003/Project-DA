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
    public partial class frmConsultaTarefasEmCurso : Form
    {
        public frmConsultaTarefasEmCurso()
        {
            InitializeComponent();
            this.Load += frmConsultaTarefasEmCurso_Load;
        }

        private void frmConsultaTarefasEmCurso_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (Sessao.GestorIdLogado == null)
                {
                    MessageBox.Show("Apenas Gestores podem aceder a esta lista!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                int gestorId = Sessao.GestorIdLogado.Value;

                var tarefas = context.Tarefas
                    .Where(t => t.GestorId == gestorId && t.EstadoAtual != EstadoTarefa.Done)
                    .Select(t => new
                    {
                        t.Id,
                        t.Descricao,
                        Estado = t.EstadoAtual.ToString(),
                        Programador = t.Programador.Name,
                        TipoTarefa = t.TipoTarefa.NomeTarefa,
                        t.DataPrevistaInicio,
                        t.DataPrevistaFim,
                        DiasEmFalta = DbFunctions.DiffDays(DateTime.Today, t.DataPrevistaFim),
                        DiasAtraso = DbFunctions.DiffDays(t.DataPrevistaFim, DateTime.Today) > 0
                            ? DbFunctions.DiffDays(t.DataPrevistaFim, DateTime.Today)
                            : 0
                    })
                    .OrderBy(t => t.Estado)
                    .ThenBy(t => t.DiasEmFalta)
                    .ToList();

                gvTarefasEmCurso.DataSource = tarefas;
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvTarefasEmCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmConsultaTarefasEmCurso_Load_1(object sender, EventArgs e)
        {

        }
    }
}