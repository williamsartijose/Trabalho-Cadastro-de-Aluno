using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Biblioteca.Camadas.DAL
{
   public  class Itens_Locacao
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Itens_Locacao> Select()
        {
            List<MODEL.Itens_Locacao> lstItens_Locacao = new List<MODEL.Itens_Locacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Itens_Locacao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Itens_Locacao item_locacao = new MODEL.Itens_Locacao();
                    item_locacao.id = Convert.ToInt32(reader[0].ToString());
                    item_locacao.locacao_id = Convert.ToInt32(reader["locacao_id"].ToString());
                    item_locacao.Livro_id = Convert.ToInt32(reader["livro_id"].ToString());
                    item_locacao.status = Convert.ToChar(reader["status"].ToString());

                    lstItens_Locacao.Add(item_locacao);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Itens_Locacao...");
            }
            finally
            {
                conexao.Close();
            }

            return lstItens_Locacao;
        }



        public List<MODEL.Itens_Locacao> SelectByLocacao(int idLocacao)
        {
            List<MODEL.Itens_Locacao> lstItens_Locacao = new List<MODEL.Itens_Locacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Itens_Locacao where locacao_id=@idLocacao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idLocacao", idLocacao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Itens_Locacao item_locacao = new MODEL.Itens_Locacao();
                    item_locacao.id = Convert.ToInt32(reader[0].ToString());
                    item_locacao.locacao_id = Convert.ToInt32(reader["locacao_id"].ToString());
                    item_locacao.Livro_id = Convert.ToInt32(reader["livro_id"].ToString());
                    item_locacao.status = Convert.ToChar(reader["status"].ToString());

                    lstItens_Locacao.Add(item_locacao);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Itens_Locacao...");
            }
            finally
            {
                conexao.Close();
            }

            return lstItens_Locacao;
        }

        public void Insert(MODEL.Itens_Locacao item_locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Itens_Locacao values (@locacao_id, @livro_id, @status);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@locacao_id", item_locacao.locacao_id);
            cmd.Parameters.AddWithValue("@livro_id", item_locacao.Livro_id);
            cmd.Parameters.AddWithValue("@status", item_locacao.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Itens_Locacao...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Itens_Locacao item_locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Itens_Locacao set locacao_id=@locacao_id, ";
            sql += " livro_id=@livro_id, status=@status where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", item_locacao.id);
            cmd.Parameters.AddWithValue("@locacao_id", item_locacao.locacao_id);
            cmd.Parameters.AddWithValue("@livro_id", item_locacao.Livro_id);
            cmd.Parameters.AddWithValue("@status", item_locacao.status);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Itens_Locacao");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Itens_Locacao item_locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Itens_Locacao where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", item_locacao.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Itens_Locacao");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
