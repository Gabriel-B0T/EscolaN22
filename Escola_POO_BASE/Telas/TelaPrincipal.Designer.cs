namespace Escola_POO_BASE.Telas
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.SspRodape = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslNomeUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslEmailUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslPerfil = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiCadastrarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblNumeroAlunoRemovidos = new System.Windows.Forms.Label();
            this.LblAlunosRemovidos = new System.Windows.Forms.Label();
            this.LblNumeroAlunosAtivos = new System.Windows.Forms.Label();
            this.LblAlunosAtivos = new System.Windows.Forms.Label();
            this.LblQtdEmNumero = new System.Windows.Forms.Label();
            this.LblQtdAlunos = new System.Windows.Forms.Label();
            this.SspRodape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SspRodape
            // 
            this.SspRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TslNomeUserLogado,
            this.toolStripStatusLabel2,
            this.TslEmailUserLogado,
            this.toolStripStatusLabel3,
            this.TslPerfil,
            this.TslDataHora});
            this.SspRodape.Location = new System.Drawing.Point(0, 460);
            this.SspRodape.Name = "SspRodape";
            this.SspRodape.Size = new System.Drawing.Size(1378, 22);
            this.SspRodape.TabIndex = 1;
            this.SspRodape.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Usuário logado: ";
            // 
            // TslNomeUserLogado
            // 
            this.TslNomeUserLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslNomeUserLogado.ForeColor = System.Drawing.Color.Maroon;
            this.TslNomeUserLogado.Name = "TslNomeUserLogado";
            this.TslNomeUserLogado.Size = new System.Drawing.Size(55, 17);
            this.TslNomeUserLogado.Text = "Joaquina";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel2.Text = "E-mail: ";
            // 
            // TslEmailUserLogado
            // 
            this.TslEmailUserLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslEmailUserLogado.ForeColor = System.Drawing.Color.Maroon;
            this.TslEmailUserLogado.Name = "TslEmailUserLogado";
            this.TslEmailUserLogado.Size = new System.Drawing.Size(123, 17);
            this.TslEmailUserLogado.Text = "Joaquina@gmail.com";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel3.Text = "Perfil: ";
            // 
            // TslPerfil
            // 
            this.TslPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslPerfil.ForeColor = System.Drawing.Color.Maroon;
            this.TslPerfil.Name = "TslPerfil";
            this.TslPerfil.Size = new System.Drawing.Size(39, 17);
            this.TslPerfil.Text = "Aluno";
            // 
            // TslDataHora
            // 
            this.TslDataHora.Name = "TslDataHora";
            this.TslDataHora.Size = new System.Drawing.Size(966, 17);
            this.TslDataHora.Spring = true;
            this.TslDataHora.Text = "15/08/2023 - 21:46";
            this.TslDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1378, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiAlterarSenha});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // TsiAlterarSenha
            // 
            this.TsiAlterarSenha.Name = "TsiAlterarSenha";
            this.TsiAlterarSenha.Size = new System.Drawing.Size(144, 22);
            this.TsiAlterarSenha.Text = "Alterar Senha";
            this.TsiAlterarSenha.Click += new System.EventHandler(this.TsiAlterarSenha_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiCadastrarAluno});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // TsiCadastrarAluno
            // 
            this.TsiCadastrarAluno.Name = "TsiCadastrarAluno";
            this.TsiCadastrarAluno.Size = new System.Drawing.Size(106, 22);
            this.TsiCadastrarAluno.Text = "Aluno";
            this.TsiCadastrarAluno.Click += new System.EventHandler(this.TsiCadastrarAluno_Click);
            // 
            // TmrRelogio
            // 
            this.TmrRelogio.Tick += new System.EventHandler(this.TmrRelogio_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblNumeroAlunoRemovidos);
            this.panel1.Controls.Add(this.LblAlunosRemovidos);
            this.panel1.Controls.Add(this.LblNumeroAlunosAtivos);
            this.panel1.Controls.Add(this.LblAlunosAtivos);
            this.panel1.Controls.Add(this.LblQtdEmNumero);
            this.panel1.Controls.Add(this.LblQtdAlunos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 436);
            this.panel1.TabIndex = 4;
            // 
            // LblNumeroAlunoRemovidos
            // 
            this.LblNumeroAlunoRemovidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNumeroAlunoRemovidos.Location = new System.Drawing.Point(59, 295);
            this.LblNumeroAlunoRemovidos.Name = "LblNumeroAlunoRemovidos";
            this.LblNumeroAlunoRemovidos.Size = new System.Drawing.Size(51, 27);
            this.LblNumeroAlunoRemovidos.TabIndex = 5;
            // 
            // LblAlunosRemovidos
            // 
            this.LblAlunosRemovidos.AutoSize = true;
            this.LblAlunosRemovidos.Location = new System.Drawing.Point(42, 269);
            this.LblAlunosRemovidos.Name = "LblAlunosRemovidos";
            this.LblAlunosRemovidos.Size = new System.Drawing.Size(93, 13);
            this.LblAlunosRemovidos.TabIndex = 4;
            this.LblAlunosRemovidos.Text = "Alunos removidos:";
            // 
            // LblNumeroAlunosAtivos
            // 
            this.LblNumeroAlunosAtivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNumeroAlunosAtivos.Location = new System.Drawing.Point(59, 191);
            this.LblNumeroAlunosAtivos.Name = "LblNumeroAlunosAtivos";
            this.LblNumeroAlunosAtivos.Size = new System.Drawing.Size(51, 27);
            this.LblNumeroAlunosAtivos.TabIndex = 3;
            // 
            // LblAlunosAtivos
            // 
            this.LblAlunosAtivos.AutoSize = true;
            this.LblAlunosAtivos.Location = new System.Drawing.Point(50, 164);
            this.LblAlunosAtivos.Name = "LblAlunosAtivos";
            this.LblAlunosAtivos.Size = new System.Drawing.Size(73, 13);
            this.LblAlunosAtivos.TabIndex = 2;
            this.LblAlunosAtivos.Text = "Alunos ativos:";
            // 
            // LblQtdEmNumero
            // 
            this.LblQtdEmNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQtdEmNumero.Location = new System.Drawing.Point(59, 82);
            this.LblQtdEmNumero.Name = "LblQtdEmNumero";
            this.LblQtdEmNumero.Size = new System.Drawing.Size(51, 27);
            this.LblQtdEmNumero.TabIndex = 1;
            // 
            // LblQtdAlunos
            // 
            this.LblQtdAlunos.AutoSize = true;
            this.LblQtdAlunos.Location = new System.Drawing.Point(33, 55);
            this.LblQtdAlunos.Name = "LblQtdAlunos";
            this.LblQtdAlunos.Size = new System.Drawing.Size(114, 13);
            this.LblQtdAlunos.TabIndex = 0;
            this.LblQtdAlunos.Text = "Quantidade de alunos:";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1378, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SspRodape);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.SspRodape.ResumeLayout(false);
            this.SspRodape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip SspRodape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TslNomeUserLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TslEmailUserLogado;
        private System.Windows.Forms.ToolStripStatusLabel TslDataHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsiAlterarSenha;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel TslPerfil;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsiCadastrarAluno;
        private System.Windows.Forms.Timer TmrRelogio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblQtdAlunos;
        private System.Windows.Forms.Label LblNumeroAlunoRemovidos;
        private System.Windows.Forms.Label LblAlunosRemovidos;
        private System.Windows.Forms.Label LblNumeroAlunosAtivos;
        private System.Windows.Forms.Label LblAlunosAtivos;
        private System.Windows.Forms.Label LblQtdEmNumero;
    }
}