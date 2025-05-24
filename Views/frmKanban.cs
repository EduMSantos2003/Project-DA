using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks
{

    public partial class frmKanban : Form
    {
        public string UserName { get; set; }
        public frmKanban()
        {
            InitializeComponent();
            this.Load += frmKanbam_Load;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btNova_Click(object sender, EventArgs e)
        {
            Form frmDetalhesTarefa = new frmDetalhesTarefa();
            frmDetalhesTarefa.ShowDialog();
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
        public void frmKanbam_Load(object sender, EventArgs e)
        {
            label1.Text = "Bem-vindo, " + UserName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gerirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGereUtilizadores = new frmGereUtilizadores();
            frmGereUtilizadores.ShowDialog();
        }
    }
}
