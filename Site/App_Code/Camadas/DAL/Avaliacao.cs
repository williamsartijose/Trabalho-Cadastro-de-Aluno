using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.DAL
{
    public class Avaliacao
    {
        private string strCon = Conexao.getConexao();






        public List<MODEL.Avaliacao> Select()
        {

            List<MODEL.Avaliacao> lstAvaliacao = new List<MODEL.Avaliacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Avaliacao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();

            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection); //chama as informacoes do banco
                while (reader.Read())
                {
                    MODEL.Avaliacao Avaliacao = new MODEL.Avaliacao();
                    Avaliacao.nota = Convert.ToInt32(reader[0].ToString());
                    Avaliacao.ano = Convert.ToDateTime(reader["aniversario"].ToString());



                    lstAvaliacao.Add(Avaliacao);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Avaliacao");
            }
            finally
            {
                conexao.Close();
            }

            return lstAvaliacao;
        }



        public List<MODEL.Avaliacao> SelectByNota(int nota)
        {
            List<MODEL.Avaliacao> lstAvaliacao = new List<MODEL.Avaliacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Avaliacao where nota=@nota;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nota", nota);// parametros por id 
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Avaliacao Avaliacao = new MODEL.Avaliacao();
                    Avaliacao.nota = Convert.ToInt32(reader[0].ToString());
                    Avaliacao.ano = Convert.ToDateTime(reader["aniversario"].ToString());



                    lstAvaliacao.Add(Avaliacao);


                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Avaliacao  por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAvaliacao;
        }// int id 


        public List<MODEL.Avaliacao> SelectByAno(string ano)
        {
            List<MODEL.Avaliacao> lstAvaliacao = new List<MODEL.Avaliacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Avaliacao where (ano like @ano);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ano", ano.Trim() + "%");// parametros por nome
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Avaliacao Avaliacao = new MODEL.Avaliacao();
                    Avaliacao.nota = Convert.ToInt32(reader[0].ToString());
                    Avaliacao.ano = Convert.ToDateTime(reader["aniversario"].ToString());



                    lstAvaliacao.Add(Avaliacao);



                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Avaliacao por Nome...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAvaliacao;
        }// string nome 


        public void Insert(MODEL.Avaliacao avaliacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Avaliacao values (@ano )";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ano", avaliacao.ano);
            cmd.Parameters.AddWithValue("@nota", avaliacao.nota);



            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção deAvaliação...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Avaliacao avaliacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Avaliacao set ano=@ano, ";
            sql += " where nota=@nota;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nota", avaliacao.nota);
            cmd.Parameters.AddWithValue("@ano", avaliacao.ano);

            conexao.Open();

            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Avaliacao");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Avaliacao avaliacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Avaliacao where nota=@nota;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nota", avaliacao.nota);
            conexao.Open();

            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Avaliacaop");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}




