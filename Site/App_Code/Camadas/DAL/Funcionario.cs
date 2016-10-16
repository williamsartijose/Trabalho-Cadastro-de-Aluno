using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.DAL
{
    public class Funcionario
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Funcionario> Select()
        {
            List<MODEL.Funcionario> lstFuncionario = new List<MODEL.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Funcionario funcionario = new MODEL.Funcionario();
                    funcionario.id = Convert.ToInt32(reader[0].ToString());
                    funcionario.nome = reader["nome"].ToString();
                    funcionario.perfil = reader["perfil"].ToString();
                    lstFuncionario.Add(funcionario);

                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção dos Funcionarios...");
            }
            finally
            {
                conexao.Close();
            }

            return lstFuncionario;
        }


        public List<MODEL.Funcionario> SelectById(int id)
        {
            List<MODEL.Funcionario> lstFuncionario = new List<MODEL.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario where  id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);// parametros por id 
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Funcionario funcionario = new MODEL.Funcionario();
                    funcionario.id = Convert.ToInt32(reader[0].ToString());
                    funcionario.nome = reader["nome"].ToString();
                    funcionario.perfil = reader["perfil"].ToString();
                    lstFuncionario.Add(funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção no id_Funcionario...");
            }
            finally
            {
                conexao.Close();
            }

            return lstFuncionario;
        }// int id 


        public List<MODEL.Funcionario> SelectByNome(string nome)
        {
            List<MODEL.Funcionario> lstFuncionario = new List<MODEL.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");// parametros por nome
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Funcionario funcionario = new MODEL.Funcionario();
                    funcionario.id = Convert.ToInt32(reader[0].ToString());
                    funcionario.nome = reader["nome"].ToString();
                    funcionario.perfil = reader["perfil"].ToString();
                    lstFuncionario.Add(funcionario);



                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de funcionario por nomes ");
            }
            finally
            {
                conexao.Close();
            }

            return lstFuncionario;
        }// string nome 


        public void Insert(MODEL.Funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Funcionario values (@nome, @perfil);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@perfil", funcionario.perfil);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção dos Funcionarios .");
            }
            finally
            {
                conexao.Close();
            }
        }



        public void Update(MODEL.Funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Funcionario set nome=@nome,";
            sql += " perfil=@perfil,";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@perfil", funcionario.perfil);
            conexao.Open();
            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização dos Funcionarios");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Funcionario where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            conexao.Open();
            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção dos Funcionarios");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}




