namespace Escola_POO_BASE.Telas
{
    partial class TelaCadastrarAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.CkbAtivo = new System.Windows.Forms.CheckBox();
            this.LblId = new System.Windows.Forms.Label();
            this.DtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.DtpDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNomeAluno = new System.Windows.Forms.TextBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbbBuscar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnReativar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReativar);
            this.groupBox1.Controls.Add(this.BtnAlterar);
            this.groupBox1.Controls.Add(this.BtnNovo);
            this.groupBox1.Controls.Add(this.CkbAtivo);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.DtpDataNascimento);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.LblMatricula);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.DtpDataMatricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtNomeAluno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de alunos";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(330, 310);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(127, 23);
            this.BtnAlterar.TabIndex = 19;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(330, 281);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(127, 23);
            this.BtnNovo.TabIndex = 18;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // CkbAtivo
            // 
            this.CkbAtivo.AutoSize = true;
            this.CkbAtivo.Checked = true;
            this.CkbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbAtivo.Location = new System.Drawing.Point(381, 41);
            this.CkbAtivo.Name = "CkbAtivo";
            this.CkbAtivo.Size = new System.Drawing.Size(61, 20);
            this.CkbAtivo.TabIndex = 17;
            this.CkbAtivo.Text = "Ativo";
            this.CkbAtivo.UseVisualStyleBackColor = true;
            // 
            // LblId
            // 
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblId.Location = new System.Drawing.Point(163, 76);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(218, 23);
            this.LblId.TabIndex = 16;
            // 
            // DtpDataNascimento
            // 
            this.DtpDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataNascimento.Location = new System.Drawing.Point(163, 155);
            this.DtpDataNascimento.Name = "DtpDataNascimento";
            this.DtpDataNascimento.Size = new System.Drawing.Size(218, 22);
            this.DtpDataNascimento.TabIndex = 15;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(105, 310);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(127, 23);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(105, 281);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(127, 23);
            this.BtnCadastrar.TabIndex = 13;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(14, 83);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(70, 16);
            this.LblMatricula.TabIndex = 12;
            this.LblMatricula.Text = "Matricula";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(163, 77);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(140, 22);
            this.TxtId.TabIndex = 11;
            // 
            // DtpDataMatricula
            // 
            this.DtpDataMatricula.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataMatricula.Location = new System.Drawing.Point(163, 195);
            this.DtpDataMatricula.Name = "DtpDataMatricula";
            this.DtpDataMatricula.Size = new System.Drawing.Size(218, 22);
            this.DtpDataMatricula.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data da matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome aluno";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(163, 235);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(218, 22);
            this.TxtEmail.TabIndex = 3;
            // 
            // TxtNomeAluno
            // 
            this.TxtNomeAluno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeAluno.Location = new System.Drawing.Point(163, 117);
            this.TxtNomeAluno.Name = "TxtNomeAluno";
            this.TxtNomeAluno.Size = new System.Drawing.Size(218, 22);
            this.TxtNomeAluno.TabIndex = 1;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(518, 129);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(820, 248);
            this.DgvUsuarios.TabIndex = 1;
            this.DgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellDoubleClick);
            this.DgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.TxtBuscar);
            this.groupBox2.Controls.Add(this.CbbBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(518, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Painel de busca";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(505, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(304, 20);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(175, 24);
            this.TxtBuscar.TabIndex = 2;
            // 
            // CbbBuscar
            // 
            this.CbbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbBuscar.FormattingEnabled = true;
            this.CbbBuscar.Items.AddRange(new object[] {
            "Nome",
            "E-mail",
            "Matrícula"});
            this.CbbBuscar.Location = new System.Drawing.Point(98, 20);
            this.CbbBuscar.Name = "CbbBuscar";
            this.CbbBuscar.Size = new System.Drawing.Size(182, 24);
            this.CbbBuscar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Buscar por:";
            // 
            // BtnReativar
            // 
            this.BtnReativar.Location = new System.Drawing.Point(243, 310);
            this.BtnReativar.Name = "BtnReativar";
            this.BtnReativar.Size = new System.Drawing.Size(75, 23);
            this.BtnReativar.TabIndex = 20;
            this.BtnReativar.Text = "Reativar";
            this.BtnReativar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaCadastrarAluno";
            this.Text = "TelaCadastrarAluno";
            this.Load += new System.EventHandler(this.TelaCadastrarAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNomeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpDataMatricula;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.DateTimePicker DtpDataNascimento;
        private System.Windows.Forms.CheckBox CkbAtivo;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CbbBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnReativar;
    }
}