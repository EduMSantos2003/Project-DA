﻿namespace iTasks
{
    partial class frmGereUtilizadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGravarGestor = new System.Windows.Forms.Button();
            this.txtNomeGestor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdGestor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstListaGestores = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btApagarGestor = new System.Windows.Forms.Button();
            this.btEditarGestor = new System.Windows.Forms.Button();
            this.chkGereUtilizadores = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordGestor = new System.Windows.Forms.TextBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameGestor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btApagarProg = new System.Windows.Forms.Button();
            this.btEditarProg = new System.Windows.Forms.Button();
            this.btApagarProgramador = new System.Windows.Forms.Button();
            this.btEditarProgramador = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbGestorProg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btGravarProg = new System.Windows.Forms.Button();
            this.txtPasswordProg = new System.Windows.Forms.TextBox();
            this.cbNivelProg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsernameProg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstListaProgramadores = new System.Windows.Forms.ListBox();
            this.txtIdProg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeProg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGravarGestor
            // 
            this.btGravarGestor.Location = new System.Drawing.Point(295, 283);
            this.btGravarGestor.Name = "btGravarGestor";
            this.btGravarGestor.Size = new System.Drawing.Size(201, 23);
            this.btGravarGestor.TabIndex = 37;
            this.btGravarGestor.Text = "Gravar Dados";
            this.btGravarGestor.UseVisualStyleBackColor = true;
            this.btGravarGestor.Click += new System.EventHandler(this.btGravarGestor_Click);
            // 
            // txtNomeGestor
            // 
            this.txtNomeGestor.Location = new System.Drawing.Point(294, 80);
            this.txtNomeGestor.Name = "txtNomeGestor";
            this.txtNomeGestor.Size = new System.Drawing.Size(201, 20);
            this.txtNomeGestor.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nome:";
            // 
            // txtIdGestor
            // 
            this.txtIdGestor.Location = new System.Drawing.Point(294, 35);
            this.txtIdGestor.Name = "txtIdGestor";
            this.txtIdGestor.ReadOnly = true;
            this.txtIdGestor.Size = new System.Drawing.Size(62, 20);
            this.txtIdGestor.TabIndex = 34;
            this.txtIdGestor.TextChanged += new System.EventHandler(this.txtIdGestor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListaGestores);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 455);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // lstListaGestores
            // 
            this.lstListaGestores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaGestores.FormattingEnabled = true;
            this.lstListaGestores.Location = new System.Drawing.Point(3, 16);
            this.lstListaGestores.Name = "lstListaGestores";
            this.lstListaGestores.Size = new System.Drawing.Size(268, 436);
            this.lstListaGestores.TabIndex = 0;
            this.lstListaGestores.SelectedIndexChanged += new System.EventHandler(this.lstListaGestores_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btApagarGestor);
            this.groupBox2.Controls.Add(this.btEditarGestor);
            this.groupBox2.Controls.Add(this.chkGereUtilizadores);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btGravarGestor);
            this.groupBox2.Controls.Add(this.txtPasswordGestor);
            this.groupBox2.Controls.Add(this.cbDepartamento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUsernameGestor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtIdGestor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomeGestor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 480);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestores";
            // 
            // btApagarGestor
            // 
            this.btApagarGestor.Location = new System.Drawing.Point(295, 341);
            this.btApagarGestor.Name = "btApagarGestor";
            this.btApagarGestor.Size = new System.Drawing.Size(201, 23);
            this.btApagarGestor.TabIndex = 45;
            this.btApagarGestor.Text = "Apagar Dados";
            this.btApagarGestor.UseVisualStyleBackColor = true;
            this.btApagarGestor.Click += new System.EventHandler(this.btApagarGestor_Click);
            // 
            // btEditarGestor
            // 
            this.btEditarGestor.Location = new System.Drawing.Point(294, 312);
            this.btEditarGestor.Name = "btEditarGestor";
            this.btEditarGestor.Size = new System.Drawing.Size(201, 23);
            this.btEditarGestor.TabIndex = 44;
            this.btEditarGestor.Text = "Editar Dados";
            this.btEditarGestor.UseVisualStyleBackColor = true;
            this.btEditarGestor.Click += new System.EventHandler(this.btEditarGestor_Click);
            // 
            // chkGereUtilizadores
            // 
            this.chkGereUtilizadores.AutoSize = true;
            this.chkGereUtilizadores.Location = new System.Drawing.Point(294, 240);
            this.chkGereUtilizadores.Name = "chkGereUtilizadores";
            this.chkGereUtilizadores.Size = new System.Drawing.Size(106, 17);
            this.chkGereUtilizadores.TabIndex = 43;
            this.chkGereUtilizadores.Text = "Gere Utilizadores";
            this.chkGereUtilizadores.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Departamento:";
            // 
            // txtPasswordGestor
            // 
            this.txtPasswordGestor.Location = new System.Drawing.Point(294, 159);
            this.txtPasswordGestor.Name = "txtPasswordGestor";
            this.txtPasswordGestor.Size = new System.Drawing.Size(201, 20);
            this.txtPasswordGestor.TabIndex = 40;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(295, 203);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(201, 21);
            this.cbDepartamento.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // txtUsernameGestor
            // 
            this.txtUsernameGestor.Location = new System.Drawing.Point(294, 119);
            this.txtUsernameGestor.Name = "txtUsernameGestor";
            this.txtUsernameGestor.Size = new System.Drawing.Size(201, 20);
            this.txtUsernameGestor.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Username:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btFechar);
            this.groupBox3.Controls.Add(this.btApagarProg);
            this.groupBox3.Controls.Add(this.btEditarProg);
            this.groupBox3.Controls.Add(this.btApagarProgramador);
            this.groupBox3.Controls.Add(this.btEditarProgramador);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbGestorProg);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btGravarProg);
            this.groupBox3.Controls.Add(this.txtPasswordProg);
            this.groupBox3.Controls.Add(this.cbNivelProg);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUsernameProg);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtIdProg);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtNomeProg);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(529, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 480);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Programadores";
            // 
            // btApagarProg
            // 
            this.btApagarProg.Location = new System.Drawing.Point(293, 341);
            this.btApagarProg.Name = "btApagarProg";
            this.btApagarProg.Size = new System.Drawing.Size(201, 23);
            this.btApagarProg.TabIndex = 49;
            this.btApagarProg.Text = "Apagar Dados";
            this.btApagarProg.UseVisualStyleBackColor = true;
            this.btApagarProg.Click += new System.EventHandler(this.btApagarProg_Click);
            // 
            // btEditarProg
            // 
            this.btEditarProg.Location = new System.Drawing.Point(294, 312);
            this.btEditarProg.Name = "btEditarProg";
            this.btEditarProg.Size = new System.Drawing.Size(201, 23);
            this.btEditarProg.TabIndex = 48;
            this.btEditarProg.Text = "Editar Dados";
            this.btEditarProg.UseVisualStyleBackColor = true;
            this.btEditarProg.Click += new System.EventHandler(this.btEditarProg_Click);
            // 
            // btApagarProgramador
            // 
            this.btApagarProgramador.Location = new System.Drawing.Point(440, 525);
            this.btApagarProgramador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btApagarProgramador.Name = "btApagarProgramador";
            this.btApagarProgramador.Size = new System.Drawing.Size(302, 35);
            this.btApagarProgramador.TabIndex = 47;
            this.btApagarProgramador.Text = "Apagar Dados";
            this.btApagarProgramador.UseVisualStyleBackColor = true;
            // 
            // btEditarProgramador
            // 
            this.btEditarProgramador.Location = new System.Drawing.Point(439, 480);
            this.btEditarProgramador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEditarProgramador.Name = "btEditarProgramador";
            this.btEditarProgramador.Size = new System.Drawing.Size(302, 35);
            this.btEditarProgramador.TabIndex = 46;
            this.btEditarProgramador.Text = "Editar Dados";
            this.btEditarProgramador.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Gestor:";
            // 
            // cbGestorProg
            // 
            this.cbGestorProg.FormattingEnabled = true;
            this.cbGestorProg.Location = new System.Drawing.Point(294, 246);
            this.cbGestorProg.Name = "cbGestorProg";
            this.cbGestorProg.Size = new System.Drawing.Size(201, 21);
            this.cbGestorProg.TabIndex = 43;
            this.cbGestorProg.SelectedIndexChanged += new System.EventHandler(this.cbGestorProg_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nível de Experiência:";
            // 
            // btGravarProg
            // 
            this.btGravarProg.Location = new System.Drawing.Point(294, 283);
            this.btGravarProg.Name = "btGravarProg";
            this.btGravarProg.Size = new System.Drawing.Size(201, 23);
            this.btGravarProg.TabIndex = 37;
            this.btGravarProg.Text = "Gravar Dados";
            this.btGravarProg.UseVisualStyleBackColor = true;
            this.btGravarProg.Click += new System.EventHandler(this.btGravarProg_Click);
            // 
            // txtPasswordProg
            // 
            this.txtPasswordProg.Location = new System.Drawing.Point(294, 159);
            this.txtPasswordProg.Name = "txtPasswordProg";
            this.txtPasswordProg.Size = new System.Drawing.Size(201, 20);
            this.txtPasswordProg.TabIndex = 40;
            // 
            // cbNivelProg
            // 
            this.cbNivelProg.FormattingEnabled = true;
            this.cbNivelProg.Location = new System.Drawing.Point(294, 203);
            this.cbNivelProg.Name = "cbNivelProg";
            this.cbNivelProg.Size = new System.Drawing.Size(201, 21);
            this.cbNivelProg.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Password:";
            // 
            // txtUsernameProg
            // 
            this.txtUsernameProg.Location = new System.Drawing.Point(294, 119);
            this.txtUsernameProg.Name = "txtUsernameProg";
            this.txtUsernameProg.Size = new System.Drawing.Size(201, 20);
            this.txtUsernameProg.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Username:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstListaProgramadores);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 455);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista";
            // 
            // lstListaProgramadores
            // 
            this.lstListaProgramadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaProgramadores.FormattingEnabled = true;
            this.lstListaProgramadores.Location = new System.Drawing.Point(3, 16);
            this.lstListaProgramadores.Name = "lstListaProgramadores";
            this.lstListaProgramadores.Size = new System.Drawing.Size(268, 436);
            this.lstListaProgramadores.TabIndex = 0;
            this.lstListaProgramadores.SelectedIndexChanged += new System.EventHandler(this.lstListaProgramadores_SelectedIndexChanged);
            // 
            // txtIdProg
            // 
            this.txtIdProg.Location = new System.Drawing.Point(294, 35);
            this.txtIdProg.Name = "txtIdProg";
            this.txtIdProg.ReadOnly = true;
            this.txtIdProg.Size = new System.Drawing.Size(62, 20);
            this.txtIdProg.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Id:";
            // 
            // txtNomeProg
            // 
            this.txtNomeProg.Location = new System.Drawing.Point(294, 80);
            this.txtNomeProg.Name = "txtNomeProg";
            this.txtNomeProg.Size = new System.Drawing.Size(201, 20);
            this.txtNomeProg.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Nome:";
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(404, 440);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(86, 23);
            this.btFechar.TabIndex = 50;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // frmGereUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmGereUtilizadores";
            this.Text = "frmListaUtilizadores";
            this.Load += new System.EventHandler(this.frmGereUtilizadores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGravarGestor;
        private System.Windows.Forms.TextBox txtNomeGestor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdGestor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstListaGestores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPasswordGestor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameGestor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkGereUtilizadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btGravarProg;
        private System.Windows.Forms.TextBox txtPasswordProg;
        private System.Windows.Forms.ComboBox cbNivelProg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsernameProg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstListaProgramadores;
        private System.Windows.Forms.TextBox txtIdProg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeProg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbGestorProg;
        private System.Windows.Forms.Button btEditarGestor;
        private System.Windows.Forms.Button btApagarGestor;
        private System.Windows.Forms.Button btApagarProgramador;
        private System.Windows.Forms.Button btEditarProgramador;
        private System.Windows.Forms.Button btApagarProg;
        private System.Windows.Forms.Button btEditarProg;
        private System.Windows.Forms.Button btFechar;
    }
}