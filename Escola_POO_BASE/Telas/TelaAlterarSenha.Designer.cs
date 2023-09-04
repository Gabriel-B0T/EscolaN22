namespace Escola_POO_BASE.Telas
{
    partial class TelaAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarSenha));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtConfiSenhaNova = new System.Windows.Forms.TextBox();
            this.TxtSenhaNova = new System.Windows.Forms.TextBox();
            this.TxtSenhaAtual = new System.Windows.Forms.TextBox();
            this.LblConfirmaSenhaNova = new System.Windows.Forms.Label();
            this.LblSenhaNova = new System.Windows.Forms.Label();
            this.LblSenhaAtual = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnConfirmar);
            this.groupBox1.Controls.Add(this.TxtConfiSenhaNova);
            this.groupBox1.Controls.Add(this.TxtSenhaNova);
            this.groupBox1.Controls.Add(this.TxtSenhaAtual);
            this.groupBox1.Controls.Add(this.LblConfirmaSenhaNova);
            this.groupBox1.Controls.Add(this.LblSenhaNova);
            this.groupBox1.Controls.Add(this.LblSenhaAtual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Senha";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(141, 194);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(101, 23);
            this.BtnConfirmar.TabIndex = 6;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtConfiSenhaNova
            // 
            this.TxtConfiSenhaNova.Location = new System.Drawing.Point(142, 141);
            this.TxtConfiSenhaNova.Name = "TxtConfiSenhaNova";
            this.TxtConfiSenhaNova.PasswordChar = '*';
            this.TxtConfiSenhaNova.Size = new System.Drawing.Size(100, 22);
            this.TxtConfiSenhaNova.TabIndex = 5;
            // 
            // TxtSenhaNova
            // 
            this.TxtSenhaNova.Location = new System.Drawing.Point(142, 101);
            this.TxtSenhaNova.Name = "TxtSenhaNova";
            this.TxtSenhaNova.PasswordChar = '*';
            this.TxtSenhaNova.Size = new System.Drawing.Size(100, 22);
            this.TxtSenhaNova.TabIndex = 4;
            // 
            // TxtSenhaAtual
            // 
            this.TxtSenhaAtual.Location = new System.Drawing.Point(142, 64);
            this.TxtSenhaAtual.Name = "TxtSenhaAtual";
            this.TxtSenhaAtual.PasswordChar = '*';
            this.TxtSenhaAtual.Size = new System.Drawing.Size(100, 22);
            this.TxtSenhaAtual.TabIndex = 3;
            // 
            // LblConfirmaSenhaNova
            // 
            this.LblConfirmaSenhaNova.AutoSize = true;
            this.LblConfirmaSenhaNova.BackColor = System.Drawing.Color.Transparent;
            this.LblConfirmaSenhaNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmaSenhaNova.Location = new System.Drawing.Point(17, 144);
            this.LblConfirmaSenhaNova.Name = "LblConfirmaSenhaNova";
            this.LblConfirmaSenhaNova.Size = new System.Drawing.Size(124, 15);
            this.LblConfirmaSenhaNova.TabIndex = 2;
            this.LblConfirmaSenhaNova.Text = "Confirme a senha:";
            // 
            // LblSenhaNova
            // 
            this.LblSenhaNova.AutoSize = true;
            this.LblSenhaNova.BackColor = System.Drawing.Color.Transparent;
            this.LblSenhaNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenhaNova.Location = new System.Drawing.Point(17, 108);
            this.LblSenhaNova.Name = "LblSenhaNova";
            this.LblSenhaNova.Size = new System.Drawing.Size(86, 15);
            this.LblSenhaNova.TabIndex = 1;
            this.LblSenhaNova.Text = "Nova senha:";
            // 
            // LblSenhaAtual
            // 
            this.LblSenhaAtual.AutoSize = true;
            this.LblSenhaAtual.BackColor = System.Drawing.Color.Transparent;
            this.LblSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenhaAtual.Location = new System.Drawing.Point(17, 71);
            this.LblSenhaAtual.Name = "LblSenhaAtual";
            this.LblSenhaAtual.Size = new System.Drawing.Size(88, 15);
            this.LblSenhaAtual.TabIndex = 0;
            this.LblSenhaAtual.Text = "Senha atual:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(29, 194);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 23);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TelaAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 276);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaAlterarSenha";
            this.Text = "TelaAlterarSenha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtConfiSenhaNova;
        private System.Windows.Forms.TextBox TxtSenhaNova;
        private System.Windows.Forms.TextBox TxtSenhaAtual;
        private System.Windows.Forms.Label LblConfirmaSenhaNova;
        private System.Windows.Forms.Label LblSenhaNova;
        private System.Windows.Forms.Label LblSenhaAtual;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}