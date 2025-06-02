using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Data.iTasks.Data;
using iTasks.Models;

namespace iTasks
{
    public partial class frmDetalhesTarefa : Form
    {
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
            try
            {
                using (var DbContext = new AppDbContext())
                {
                    string descricao = txtDesc.Text;

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar tarefa: " + ex.Message);
            }
        }
    }
}
