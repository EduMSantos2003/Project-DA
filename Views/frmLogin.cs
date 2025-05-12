using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iTasks
{
    public partial class frmLogin : Form
    {
        public int Id { get; set; }
        public int User { get; set; }
        public int Username { get; set; }
        public int Password { get; set; }

        public frmLogin()
        {
            InitializeComponent();

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            Form secondForm = new frmKanban();
            //secondForm.Show();

            // Validação Logina

            if (name == "abc" && password == "123") 
            {
                MessageBox.Show("Login realizado com sucesso!");
                Hide();
                secondForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
                return;
            }
        }

    }
}