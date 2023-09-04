using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Classes
{
    public class Usuario
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        #endregion

        #region Construtores

        public Usuario()
        {

        }

        public Usuario(int id, string nome, DateTime dtNascimento, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            DtNascimento = dtNascimento;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        #endregion

        #region Métodos

        #region Antigo Realizar login sem banco
        //public static Usuario RealizarLogin(string email, string senha, List<Usuario> usuarios)
        //{
        //    Usuario usuario = usuarios.Find(a => a.Email == email);

        //    try
        //    {
        //        if (usuario == null)
        //        {
        //            // sera lançado um erro pq o email nao foi encotrado.
        //            throw new Exception("E-mail inexistente!");
        //        }
        //        else
        //        {
        //            if (usuario.Senha == senha)
        //            {
        //                if (usuario.Ativo)
        //                {
        //                    //com acesso
        //                    return usuario;
        //                }
        //                else
        //                {
        //                    // usuario bloqueado
        //                    throw new Exception("Usuário bloqueado");

        //                }
        //            }
        //            else
        //            {
        //                // senha errada
        //                throw new Exception("Senha incorreta");
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion
        public static Usuario RealizarLogin(string email, string senha, bool tipoAcesso)
        {
            if (tipoAcesso)
            {
                string query = string.Format($"SELECT * FROM Aluno WHERE Email = '{email}'");
                Conexao cn = new Conexao(query);

                Aluno usuario = new Aluno();

                //Bloco - try..catch
                try
                {
                    cn.AbriConexao();
                    cn.dr = cn.comando.ExecuteReader(); // p/ select! ExecuteReader()!

                    if (cn.dr.HasRows)
                    {
                        //Achou os dados do usuário de acordo com o e-mail pesquisado
                        while (cn.dr.Read())
                        {
                            usuario.Id = Convert.ToInt32(cn.dr[0]);
                            usuario.Nome = cn.dr[1].ToString();
                            usuario.DtNascimento = Convert.ToDateTime(cn.dr[2]);
                            usuario.DtMatricula = Convert.ToDateTime(cn.dr[3]);
                            usuario.Email = cn.dr[4].ToString();
                            usuario.Senha = cn.dr[5].ToString();
                            usuario.Ativo = Convert.ToBoolean(cn.dr[6]);
                        }
                        if (usuario == null)
                        {
                            //E-mail é inexistente
                            throw new Exception("E-mail inexistente!");
                        }
                        else
                        {
                            if (usuario.Senha == Crypto.Sha256(senha))
                            {
                                if (usuario.Ativo)
                                {
                                    //Deu tudo certo
                                    return usuario;
                                }
                                else
                                {
                                    //Usuário bloqueado
                                    throw new Exception("Usuário bloqueado");
                                }
                            }
                            else
                            {
                                //Senha incorreta
                                throw new Exception("Senha incorreta!");
                            }
                        }
                    }
                    else
                    {
                        //Não teve retorno de linhas
                        throw new Exception("E-mail inexistente!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {

                string query = string.Format($"SELECT * FROM Professor WHERE Email = '{email}'");
                Conexao cn = new Conexao(query);

                Professor usuario = new Professor();

                //Bloco - try..catch
                try
                {
                    cn.AbriConexao();
                    cn.dr = cn.comando.ExecuteReader(); // p/ select! ExecuteReader()!

                    if (cn.dr.HasRows)
                    {
                        //Achou os dados do usuário de acordo com o e-mail pesquisado
                        while (cn.dr.Read())
                        {
                            usuario.Id = Convert.ToInt32(cn.dr[0]);
                            usuario.Nome = cn.dr[1].ToString();
                            usuario.DtNascimento = Convert.ToDateTime(cn.dr[2]);
                            usuario.CPF = cn.dr[3].ToString();
                            usuario.Email = cn.dr[4].ToString();
                            usuario.Senha = cn.dr[5].ToString();
                            usuario.NivelAcesso = Convert.ToInt32(cn.dr[6]);
                            usuario.Ativo = Convert.ToBoolean(cn.dr[7]);
                        }

                        if (usuario == null)
                        {
                            //E-mail é inexistente
                            throw new Exception("E-mail inexistente!");
                        }
                        else
                        {
                            if (usuario.Senha == Crypto.Sha256(senha))
                            {
                                if (usuario.Ativo)
                                {
                                    //Deu tudo certo
                                    return usuario;
                                }
                                else
                                {
                                    //Usuário bloqueado
                                    throw new Exception("Usuário bloqueado");
                                }
                            }
                            else
                            {
                                //Senha incorreta
                                throw new Exception("Senha incorreta!");
                            }
                        }
                    }
                    else
                    {
                        //Não teve retorno de linhas
                        throw new Exception("E-mail inexistente!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        //public static List<Usuario> GerarUsuarios()
        //{
        //    List<Usuario> usuarios = new List<Usuario>();
        //    Usuario aluno1 = new Aluno(1, "João Pereira", Convert.ToDateTime("12/02/1995"), Convert.ToDateTime("20/05/2020"), "joao@gmail", "123", true);
        //    Usuario aluno2 = new Aluno(2, "Ana Júlia", Convert.ToDateTime("28/06/1993"), Convert.ToDateTime("20/02/2020"), "ana@gmail", "123", true);
        //    Usuario aluno3 = new Aluno(3, "Kayena Almeida", Convert.ToDateTime("20/08/1997"), Convert.ToDateTime("10/05/2020"), "kayena@gmail", "123", true);

        //    Usuario professor1 = new Professor(1, "Guilherme Almeida", Convert.ToDateTime("10/05/1981"), ("284.648.954-55"), "g.almeida@gmail", "123", 3, true);
        //    Usuario professor2 = new Professor(2, "Paulo Andrade", Convert.ToDateTime("20/11/1973"), ("357.188.984-16"), "pauloandrade@gmail", "123", 3, true);
        //    Usuario professor3 = new Professor(3, "João Carlos", Convert.ToDateTime("16/05/1977"), ("261.166.481-35"), "joaocarlos@gmail", "123", 3, true);




        //    usuarios.Add(aluno1);
        //    usuarios.Add(aluno2);
        //    usuarios.Add(aluno3);

        //    usuarios.Add(professor1);
        //    usuarios.Add(professor2);
        //    usuarios.Add(professor3);

        //    return usuarios;

        //}
        public void AlterarSenha(string senhaAtual, string novaSenha, string confSenha)
        {
            
            
                //string query = string.Format($"Update Alunos set Senha = '{Crypto.Sha256(novaSenha)}' where Id = {Id}");
                //Conexao cn = new Conexao(query);

                string query = string.Format("UPDATE {0} SET Senha = '{1}' WHERE Id = {2}", this is Aluno ? "Aluno" : "Professor", Crypto.Sha256(novaSenha), Id);
                Conexao cn = new Conexao(query);

                try
                {
                    if (Senha == Crypto.Sha256(senhaAtual))
                    {
                        if (novaSenha == confSenha)
                        {
                            cn.AbriConexao();
                            cn.comando.ExecuteNonQuery();
                            Senha = Crypto.Sha256(novaSenha);
                        }
                        else
                        {
                            throw new Exception("Nova senha não confere!");
                        }
                    }
                    else
                    {
                        throw new Exception("Senha atual não confere!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }                                        
        }
        
        public static List<Usuario> BuscarUsusarios()
        {
            string query = string.Format("Select * from Aluno ");
            Conexao cn = new Conexao(query);

            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                cn.AbriConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    usuarios.Add(new Aluno() 
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),
                        DtNascimento = Convert.ToDateTime(cn.dr[2]),
                        DtMatricula = Convert.ToDateTime(cn.dr[3]),
                        Email = cn.dr[4].ToString(),
                        Senha = cn.dr[5].ToString(),
                        Ativo = Convert.ToBoolean(cn.dr[6])
                    });
                }
                return usuarios;
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


        #endregion
    }
}

