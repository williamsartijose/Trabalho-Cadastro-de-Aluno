using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Biblioteca.Camadas.DAL
{
    public class Aluno
    {
        private string strCon = Conexao.getConexao();

        // nesses metodo criarei 3 select um para buscar por todos , por nome e por codigo tudo dentro do formulario buscar





        public List<MODEL.Aluno> Select()
        {

            List<MODEL.Aluno> lstAluno = new List<MODEL.Aluno>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluno";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection); //chama as informacoes do banco
                while (reader.Read())
                {
                    MODEL.Aluno aluno = new MODEL.Aluno();

                    aluno.id = Convert.ToInt32(reader[0].ToString());
                    aluno.nome = reader["nome"].ToString();
                    aluno.endereco = reader["endereco"].ToString();
                    aluno.email = reader["email"].ToString();
                    aluno.cidade = reader["cidade"].ToString();
                    aluno.estado = reader["estado"].ToString();



                    lstAluno.Add(aluno);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Aluno");
            }
            finally
            {
                conexao.Close();
            }

            return lstAluno;
        }



        public List<MODEL.Aluno> SelectById(int id)
        {
            List<MODEL.Aluno> lstAluno = new List<MODEL.Aluno>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluno where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);// parametros por id 
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                   
                    MODEL.Aluno aluno = new MODEL.Aluno();
                    aluno.id = Convert.ToInt32(reader[0].ToString());
                    aluno.nome = reader["nome"].ToString();
                    aluno.endereco = reader["endereco"].ToString();
                    aluno.email = reader["email"].ToString();
                    aluno.cidade = reader["cidade"].ToString();
                    aluno.estado = reader["estado"].ToString();



                    lstAluno.Add(aluno);


                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Alunos por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAluno;
        }// int id 


        public List<MODEL.Aluno> SelectByNome(string nome)
        {
            List<MODEL.Aluno> lstAluno = new List<MODEL.Aluno>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluno where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");// parametros por nome
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Aluno aluno = new MODEL.Aluno();
                    aluno.id = Convert.ToInt32(reader[0].ToString());
                    aluno.nome = reader["nome"].ToString();
                    aluno.endereco = reader["endereco"].ToString();
                    aluno.email = reader["email"].ToString();
                    aluno.cidade = reader["cidade"].ToString();
                    aluno.estado = reader["estado"].ToString();



                    lstAluno.Add(aluno);

                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Alunos por Nome...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAluno;
        }// string nome 


        public void Insert(MODEL.Aluno aluno)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Aluno values (@nome, @endereco, @email, @cidade, @estado )";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", aluno.nome);
            cmd.Parameters.AddWithValue("@endereco", aluno.endereco);
            cmd.Parameters.AddWithValue("@email", aluno.email);
            cmd.Parameters.AddWithValue("@cidade", aluno.cidade);
            cmd.Parameters.AddWithValue("@estado", aluno.estado);


            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Alunos...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Aluno aluno)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Aluno set nome=@nome, ";
            sql += " endereco=@endereco, email=@email,    ";
            sql += " cidade=@cidade, estado=@estado ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", aluno.id);
            cmd.Parameters.AddWithValue("@nome", aluno.nome);
            cmd.Parameters.AddWithValue("@endereco", aluno.endereco);
            cmd.Parameters.AddWithValue("@email", aluno.email);
            cmd.Parameters.AddWithValue("@cidade", aluno.cidade);
            cmd.Parameters.AddWithValue("@estado", aluno.estado);
            conexao.Open();

            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Aluno");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Aluno aluno)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Aluno where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", aluno.id);
            conexao.Open();

            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Aluno");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}



