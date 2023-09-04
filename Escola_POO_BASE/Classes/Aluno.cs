using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola_POO_BASE.Classes
{
    public class Aluno : Usuario
    {
        #region Proriedades

        public DateTime DtMatricula { get; set; }

        #endregion

        #region Construtores
        public Aluno()
        {

        }
        public Aluno(int id, string nome, DateTime dtNascimento, DateTime dtMtricula, string email, string senha, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {

            DtMatricula = dtMtricula;

        }
        #endregion

        #region Métodos

        public void Cadastrar(List<Aluno> alunos)
        {
            string query = string.Format($"insert into Aluno values ('{Nome}','{DtNascimento}','{DtMatricula}','{Email}','{Senha}',1)");
            query += ";SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);



            try
            {
                cn.AbriConexao();
                this.Id = Convert.ToInt32(cn.comando.ExecuteScalar());

                alunos.Add(this);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }

        public void AlterarDados()
        {
            string query = string.Format($"Update Aluno Set Nome = '{Nome}', DtNascimento = '{DtNascimento}', DtMatricula = '{DtMatricula}', Email = '{Email}' Where Id = {Id}");
            Conexao cn = new Conexao(query);


            try
            {
                cn.AbriConexao();
                cn.comando.ExecuteNonQuery();
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Remover()
        {
            string query = string.Format($"Update Aluno Set Ativo = '0'  Where Id = {Id}");
            Conexao cn = new Conexao(query);


            try
            {
                cn.AbriConexao();
                cn.comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Aluno> BuscarAluno(List<Aluno> alunos, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:
                    //Buscar por nome

                 return alunos.Where(a => a.Nome.ToUpper().Contains(texto.ToUpper())).ToList();

                //break; quando não for return, é obrigatório o uso do break. 
                
                case 1:
                    // Buscar por e-mail

                 return alunos.Where(a => a.Email.ToUpper().Contains(texto.ToUpper())).ToList();

                //break; quando não for return, é obrigatório o uso do break. 

                case 2:
                    //Buscar por matricula (Id)
                 return alunos.Where(a => a.Id == Convert.ToInt32(texto)).ToList();

                //break; quando não for return, é obrigatório o uso do break. 
                default:
                    return alunos;
                
                 //break; quando não for return, é obrigatório o uso do break. 
            }
        }
        #endregion
    }

}