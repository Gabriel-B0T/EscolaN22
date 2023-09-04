using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola_POO_BASE.Telas
{
    public partial class TelaLogin : Form
    {
        
        public TelaLogin()
        {
            InitializeComponent();         
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario userLogado = Usuario.RealizarLogin(TxtEmail.Text, TxtSenha.Text, RdbAluno.Checked);
                
                if(userLogado.Senha == Crypto.Sha256("123"))
                {
                    TelaAlterarSenha telaAlterarSenha = new TelaAlterarSenha(userLogado);                   
                    telaAlterarSenha.ShowDialog();
                    this.Show();
                    TxtSenha.Clear();
                    TxtSenha.Focus();
                }
                else
                {
                    TelaPrincipal telaPrincipal = new TelaPrincipal(userLogado);

                    this.Hide();
                    telaPrincipal.ShowDialog();
                    this.Show();
                    TxtSenha.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Escola X ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxMostrarSenha.Checked)
            {
                TxtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
