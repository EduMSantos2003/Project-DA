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
        public int Name { get; set; }
        public int Username { get; set; }
        public int Password { get; set; }

        public frmLogin()
        {
            InitializeComponent();

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Form secondForm = new frmKanban();
            //secondForm.Show();

            Hide();
            secondForm.ShowDialog();

        }

    }
}