namespace iTasks
{
    partial class frmDetalhesTarefa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProgramador;
        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoTarefa;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDataPrevistaFim;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDataRealini;
        private System.Windows.Forms.Label labelDataRealInicio;
        private System.Windows.Forms.TextBox txtdataRealFim;
        private System.Windows.Forms.Label labelDataRealFim;
        private System.Windows.Forms.TextBox txtDataCriacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.TextBox txtStoryPoints;
        private System.Windows.Forms.Label label12;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProgramador = new System.Windows.Forms.ComboBox();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoTarefa = new System.Windows.Forms.ComboBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDataPrevistaFim = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataRealini = new System.Windows.Forms.TextBox();
            this.labelDataRealInicio = new System.Windows.Forms.Label();
            this.txtdataRealFim = new System.Windows.Forms.TextBox();
            this.labelDataRealFim = new System.Windows.Forms.Label();
            this.txtDataCriacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btGravar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.txtStoryPoints = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDataPrevistaInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(132, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(62, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Programador:";
            // 
            // cbProgramador
            // 
            this.cbProgramador.FormattingEnabled = true;
            this.cbProgramador.Location = new System.Drawing.Point(132, 165);
            this.cbProgramador.Name = "cbProgramador";
            this.cbProgramador.Size = new System.Drawing.Size(311, 21);
            this.cbProgramador.TabIndex = 6;
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(132, 192);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(62, 20);
            this.txtOrdem.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ordem:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(132, 112);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(425, 20);
            this.txtDesc.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo de Tarefa:";
            // 
            // cbTipoTarefa
            // 
            this.cbTipoTarefa.FormattingEnabled = true;
            this.cbTipoTarefa.Location = new System.Drawing.Point(132, 138);
            this.cbTipoTarefa.Name = "cbTipoTarefa";
            this.cbTipoTarefa.Size = new System.Drawing.Size(311, 21);
            this.cbTipoTarefa.TabIndex = 12;
            this.cbTipoTarefa.SelectedIndexChanged += new System.EventHandler(this.cbTipoTarefa_SelectedIndexChanged);
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(195, 252);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 15;
            // 
            // labelDataPrevistaFim
            // 
            this.labelDataPrevistaFim.AutoSize = true;
            this.labelDataPrevistaFim.Location = new System.Drawing.Point(18, 278);
            this.labelDataPrevistaFim.Name = "labelDataPrevistaFim";
            this.labelDataPrevistaFim.Size = new System.Drawing.Size(108, 13);
            this.labelDataPrevistaFim.TabIndex = 17;
            this.labelDataPrevistaFim.Text = "Data Prevista de Fim:";
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(195, 276);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(200, 20);
            this.dtFim.TabIndex = 16;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(426, 12);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(131, 20);
            this.txtEstado.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado Atual:";
            // 
            // txtDataRealini
            // 
            this.txtDataRealini.Location = new System.Drawing.Point(132, 38);
            this.txtDataRealini.Name = "txtDataRealini";
            this.txtDataRealini.ReadOnly = true;
            this.txtDataRealini.Size = new System.Drawing.Size(135, 20);
            this.txtDataRealini.TabIndex = 21;
            // 
            // labelDataRealInicio
            // 
            this.labelDataRealInicio.AutoSize = true;
            this.labelDataRealInicio.Location = new System.Drawing.Point(18, 45);
            this.labelDataRealInicio.Name = "labelDataRealInicio";
            this.labelDataRealInicio.Size = new System.Drawing.Size(103, 13);
            this.labelDataRealInicio.TabIndex = 20;
            this.labelDataRealInicio.Text = "Data Real de Início:";
            // 
            // txtdataRealFim
            // 
            this.txtdataRealFim.Location = new System.Drawing.Point(132, 71);
            this.txtdataRealFim.Name = "txtdataRealFim";
            this.txtdataRealFim.ReadOnly = true;
            this.txtdataRealFim.Size = new System.Drawing.Size(135, 20);
            this.txtdataRealFim.TabIndex = 23;
            // 
            // labelDataRealFim
            // 
            this.labelDataRealFim.AutoSize = true;
            this.labelDataRealFim.Location = new System.Drawing.Point(23, 71);
            this.labelDataRealFim.Name = "labelDataRealFim";
            this.labelDataRealFim.Size = new System.Drawing.Size(92, 13);
            this.labelDataRealFim.TabIndex = 22;
            this.labelDataRealFim.Text = "Data Real de Fim:";
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.Location = new System.Drawing.Point(426, 42);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.ReadOnly = true;
            this.txtDataCriacao.Size = new System.Drawing.Size(131, 20);
            this.txtDataCriacao.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Data Criação:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(8, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 2);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(8, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 2);
            this.panel2.TabIndex = 27;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(316, 317);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(141, 23);
            this.btGravar.TabIndex = 28;
            this.btGravar.Text = "Gravar Dados";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(463, 317);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(104, 23);
            this.btFechar.TabIndex = 29;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // txtStoryPoints
            // 
            this.txtStoryPoints.Location = new System.Drawing.Point(132, 218);
            this.txtStoryPoints.Name = "txtStoryPoints";
            this.txtStoryPoints.Size = new System.Drawing.Size(62, 20);
            this.txtStoryPoints.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "StoryPoints:";
            // 
            // labelDataPrevistaInicio
            // 
            this.labelDataPrevistaInicio.AutoSize = true;
            this.labelDataPrevistaInicio.Location = new System.Drawing.Point(18, 251);
            this.labelDataPrevistaInicio.Name = "labelDataPrevistaInicio";
            this.labelDataPrevistaInicio.Size = new System.Drawing.Size(117, 13);
            this.labelDataPrevistaInicio.TabIndex = 32;
            this.labelDataPrevistaInicio.Text = "Data Prevista de Inicio:";
            // 
            // frmDetalhesTarefa
            // 
            this.ClientSize = new System.Drawing.Size(782, 436);
            this.Controls.Add(this.labelDataPrevistaInicio);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProgramador);
            this.Controls.Add(this.txtOrdem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipoTarefa);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDataPrevistaFim);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDataRealini);
            this.Controls.Add(this.labelDataRealInicio);
            this.Controls.Add(this.txtdataRealFim);
            this.Controls.Add(this.labelDataRealFim);
            this.Controls.Add(this.txtDataCriacao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.txtStoryPoints);
            this.Controls.Add(this.label12);
            this.Name = "frmDetalhesTarefa";
            this.Load += new System.EventHandler(this.frmDetalhesTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDataPrevistaInicio;
    }
}