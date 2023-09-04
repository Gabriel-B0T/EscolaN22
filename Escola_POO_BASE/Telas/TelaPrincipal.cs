﻿using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Telas
{
    //TODO 3 - Desenhar uma tecla para alterar a senha.
    //* Esta tela devera contar um campo para colocar a senha atual.
    // a nova senha e confirmar a nova senha.
    // * Também deverá contar um botão para confirmar e outro para fechar.
    
    public partial class TelaPrincipal : Form
    {    

        private Usuario _userLogado;
        //private List<Usuario> _usuarios;

        public TelaPrincipal(Usuario usarioLogado)
        {
            InitializeComponent();
            _userLogado = usarioLogado;          
        }



        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            //TODO 1- Identificar quem esta logado, se é o aluno ou professor.
            // * Se for o aluno, mostrar o perfil "Aluno" no toolstrip, assim como
            // * o seu E-mail. O mesmo deve acontecer caso seja o professor.

            
             
                
            if (_userLogado is Aluno)
            {
                TslPerfil.Text = "Aluno";
                cadastrosToolStripMenuItem.Visible = false;
            }
            else
            {
                // DownCastomg de Usuario para Professsor exemplo
                //Professor _profLogado = (Professor)_userLogado;
                //_userLogado= _profLogado;

                TslPerfil.Text = "Professor";
                cadastrosToolStripMenuItem.Visible = true;

            }
            //If ternário.
            //Caso o obj _userLogado for do tipo Aluno, então armazanerá na 
            //propriedade Text a palavra "aluno", senao, "professor".
            //TslPerfil.Text = _userLogado is Aluno ? "Aluno" : "Professor";

            LblBemVindo.Text = $"Bem vindo {_userLogado.Nome}";
            TslNomeUserLogado.Text = _userLogado.Nome;
            TslEmailUserLogado.Text = _userLogado.Email;

            // TODO 2 - Descobrir como mostrar a data e hora completa no toolStrip.

            TslDataHora.Text = DateTime.Now.ToString();
        }

        private void TsiAlterarSenha_Click(object sender, EventArgs e)
        {
            TelaAlterarSenha telaAlterarSenha = new TelaAlterarSenha(_userLogado);
            telaAlterarSenha.ShowDialog();
        }

        private void TsiCadastrarAluno_Click(object sender, EventArgs e)
        {
            TelaCadastrarAluno telaCadastrarAluno = new TelaCadastrarAluno(_userLogado);
            telaCadastrarAluno.ShowDialog();
        }

    }                   
}