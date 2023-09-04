namespace Escola_POO_BASE.Telas
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.LblInfor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RdbAluno = new System.Windows.Forms.RadioButton();
            this.RdbProfessor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Escola_POO_BASE.Properties.Resources._4fb735450ccd37f844681e08fbaca7f8;
            this.groupBox1.Controls.Add(this.CbxMostrarSenha);
            this.groupBox1.Controls.Add(this.LblInfor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RdbAluno);
            this.groupBox1.Controls.Add(this.RdbProfessor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.LblUsuario);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acesso escola";
            // 
            // CbxMostrarSenha
            // 
            this.CbxMostrarSenha.AutoSize = true;
            this.CbxMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMostrarSenha.Location = new System.Drawing.Point(118, 165);
            this.CbxMostrarSenha.Name = "CbxMostrarSenha";
            this.CbxMostrarSenha.Size = new System.Drawing.Size(105, 19);
            this.CbxMostrarSenha.TabIndex = 9;
            this.CbxMostrarSenha.Text = "Mostrar senha";
            this.CbxMostrarSenha.UseVisualStyleBackColor = true;
            this.CbxMostrarSenha.CheckedChanged += new System.EventHandler(this.CbxMostrarSenha_CheckedChanged);
            // 
            // LblInfor
            // 
            this.LblInfor.AutoSize = true;
            this.LblInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblInfor.Location = new System.Drawing.Point(17, 171);
            this.LblInfor.Name = "LblInfor";
            this.LblInfor.Size = new System.Drawing.Size(93, 13);
            this.LblInfor.TabIndex = 8;
            this.LblInfor.Text = "Não sei meu email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Esqueceu a senha?";
            // 
            // RdbAluno
            // 
            this.RdbAluno.AutoSize = true;
            this.RdbAluno.Location = new System.Drawing.Point(20, 68);
            this.RdbAluno.Name = "RdbAluno";
            this.RdbAluno.Size = new System.Drawing.Size(64, 20);
            this.RdbAluno.TabIndex = 6;
            this.RdbAluno.TabStop = true;
            this.RdbAluno.Text = "Aluno";
            this.RdbAluno.UseVisualStyleBackColor = true;
            // 
            // RdbProfessor
            // 
            this.RdbProfessor.AutoSize = true;
            this.RdbProfessor.BackColor = System.Drawing.Color.Transparent;
            this.RdbProfessor.ForeColor = System.Drawing.Color.Black;
            this.RdbProfessor.Location = new System.Drawing.Point(20, 42);
            this.RdbProfessor.Name = "RdbProfessor";
            this.RdbProfessor.Size = new System.Drawing.Size(92, 20);
            this.RdbProfessor.TabIndex = 5;
            this.RdbProfessor.TabStop = true;
            this.RdbProfessor.Text = "Professor";
            this.RdbProfessor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(74, 139);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(143, 22);
            this.TxtSenha.TabIndex = 3;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(74, 110);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(143, 22);
            this.TxtEmail.TabIndex = 2;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(17, 116);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(51, 16);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "E-mail";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(90, 200);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(93, 29);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 278);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblInfor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RdbAluno;
        private System.Windows.Forms.RadioButton RdbProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.CheckBox CbxMostrarSenha;
    }
}

