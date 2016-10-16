using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Biblioteca.Camadas.DAL
{
   public  class Locacao
    {

        private string strCon = Conexao.getConexao();

        public List<MODEL.Locacao> Select()
        {
            List<MODEL.Locacao> lstLocacao = new List<MODEL.Locacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Locacao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Locacao locacao = new MODEL.Locacao();
                    locacao.id = Convert.ToInt32(reader[0].ToString());
                    locacao.data = Convert.ToDateTime(reader["data"].ToString());
                    locacao.cliente_id = Convert.ToInt32(reader["cliente_id"].ToString());

                    lstLocacao.Add(locacao);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Locacao...");
            }
            finally
            {
                conexao.Close();
            }

            return lstLocacao;
        }

        public void Insert(MODEL.Locacao locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Locacao values (@data, @cliente_id);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", locacao.data);
            cmd.Parameters.AddWithValue("@cliente_id", locacao.cliente_id);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Locacao...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Locacao locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Locacao set data=@data, ";
            sql += " cliente_id=@cliente_id where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", locacao.id);
            cmd.Parameters.AddWithValue("@data", locacao.data);
            cmd.Parameters.AddWithValue("@cliente_id", locacao.cliente_id);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Locacao");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Locacao locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Locacao where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", locacao.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Locacao");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}