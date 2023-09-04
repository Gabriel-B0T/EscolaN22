using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Telas
{
    public partial class TelaCadastrarAluno : Form
    {
        private List<Aluno> _alunos;
        private Usuario _userLogado;
        private Aluno _alunoSelecionado;

        public TelaCadastrarAluno(Usuario userLogado)
        {
            InitializeComponent();
            _userLogado = userLogado;

            try
            {
                _alunos = Usuario.BuscarUsusarios().ConvertAll(a => (Aluno)a);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método de formulário que irá configurar o DvgUsuarios

        private void ConfigDgvUsuario()
        {
            //Criação das colunas do DvgUsuario
            DgvUsuarios.Columns.Add("Id", "Matrícula");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("DtNascimento", "Data de Nascimento");
            DgvUsuarios.Columns.Add("DtMatricula", "Data da Matrícula");
            DgvUsuarios.Columns.Add("Email", "E-mail");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");

            //Config dos alinhamentos de cada coluna do DgvUsuario
            DgvUsuarios.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvUsuarios.Columns["DtNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["DtMatricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Config dos tamanhos de cada coluna do DgvUsuario

            DgvUsuarios.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["DtMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            //Config tamanho em altura cde colunas e linhas

            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvUsuarios.ColumnHeadersHeight = 30;


            //Definindo uma cor para intercalar linhas

            //DgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;


        }

        private void CarregaDgvUsuarios(List<Aluno> alunos = null)
        {
            DgvUsuarios.Rows.Clear();

            foreach (Aluno aluno in alunos == null ? _alunos : alunos) //se aluno for null ele vai usar a lista completa "_alunos" se nao for null ele usa "alunos"
            {
                DgvUsuarios.Rows.Add(aluno.Id, aluno.Nome, aluno.DtNascimento.ToString("dd/MM/yyyy"), aluno.DtMatricula, aluno.Email, aluno.Ativo);
                if (!aluno.Ativo)
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;                              
            }

        }

        private void LimpaCampos()
        {
            LblId.Text = string.Empty;
            TxtNomeAluno.Clear();
            TxtEmail.Clear();
            DtpDataMatricula.Value = new DateTime(1990, 1, 1);
            DtpDataNascimento.Value = DateTime.Now;
            CkbAtivo.Checked = true;
            DgvUsuarios.ClearSelection();
            BtnAlterar.Enabled = false;
            BtnCadastrar.Enabled = true;

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = (Professor)_userLogado;

                if (professor.NivelAcesso != 1)
                {
                    BtnCadastrar.Enabled = false;
                    MessageBox.Show("Você não possui permissão para cadastrar", "Erro de Permissão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    Aluno aluno = new Aluno(0, TxtNomeAluno.Text, DtpDataNascimento.Value, DtpDataMatricula.Value, TxtEmail.Text, Crypto.Sha256("123"), true);

                    aluno.Cadastrar(_alunos);
                    CarregaDgvUsuarios();
                    LimpaCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaCadastrarAluno_Load(object sender, EventArgs e)
        {

            try
            {

                ConfigDgvUsuario();
                CarregaDgvUsuarios();
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {

            if (DgvUsuarios.Rows.Count < 1 || DgvUsuarios.SelectedRows.Count < 1)
                return;

            try
            {
                _alunoSelecionado = _alunos.Find(a => a.Id == (int)DgvUsuarios.SelectedRows[0].Cells[0].Value);
                LblId.Text = _alunoSelecionado.Id.ToString();
                TxtNomeAluno.Text = _alunoSelecionado.Nome;
                TxtEmail.Text = _alunoSelecionado.Email;
                DtpDataNascimento.Value = _alunoSelecionado.DtNascimento;
                DtpDataMatricula.Value = _alunoSelecionado.DtMatricula;
                CkbAtivo.Checked = _alunoSelecionado.Ativo;

                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                _alunoSelecionado.Nome = TxtNomeAluno.Text;
                _alunoSelecionado.Email = TxtEmail.Text;
                _alunoSelecionado.DtMatricula = DtpDataMatricula.Value;
                _alunoSelecionado.DtNascimento = DtpDataNascimento.Value;

                _alunoSelecionado.AlterarDados();

                CarregaDgvUsuarios();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você deseja remover {_alunoSelecionado.Nome}?", "Remover aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _alunoSelecionado.Ativo = false;

                    _alunoSelecionado.Remover();

                    CarregaDgvUsuarios();
                }
                else
                {
                    Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Aluno> listaAlunosFiltrada = Aluno.BuscarAluno(_alunos, CbbBuscar.SelectedIndex, TxtBuscar.Text);

        }



        //private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{

        //    if (e.RowIndex >= 0 && e.ColumnIndex == DgvUsuarios.Columns["Ativo"].Index) // Verifica se é uma célula válida na coluna "Ativo"
        //    {
        //        DataGridViewRow row = DgvUsuarios.Rows[e.RowIndex];
        //        bool ativo = Convert.ToBoolean(row.Cells["Ativo"].Value);

        //        if (!ativo)
        //        {
        //            // Define o estilo da linha correspondente para vermelho claro
        //            row.DefaultCellStyle.BackColor = Color.LightCoral;
        //        }
        //    }
        //}
    }
}
