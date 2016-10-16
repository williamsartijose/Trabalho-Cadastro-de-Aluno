using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.Camadas.DAL
{
    public class Curso
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Curso> Select()
        {
            List<MODEL.Curso> lstCurso = new List<MODEL.Curso>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Curso";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Curso Curso = new MODEL.Curso();
                    Curso.id = Convert.ToInt32(reader[0].ToString());
                    Curso.descricao = reader["descricao"].ToString();


                    lstCurso.Add(Curso);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção dos cursos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCurso;
        }



        public List<MODEL.Curso> SelectById(int id)
        {
            List<MODEL.Curso> lstCurso = new List<MODEL.Curso>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Curso where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);// parametros por id 
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Curso Curso = new MODEL.Curso();
                    Curso.id = Convert.ToInt32(reader[0].ToString());
                    Curso.descricao = reader["descricao"].ToString();


                    lstCurso.Add(Curso);
                }


            }

            catch
            {
                Console.WriteLine("Deu erro na Seleção de Curso  por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCurso;
        }// int id 


        public List<MODEL.Curso> SelectByDescricao(string descricao)
        {
            List<MODEL.Curso> lstCurso = new List<MODEL.Curso>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Curso where (descricao like @descricao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", descricao.Trim() + "%");// parametros por nome
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Curso Curso = new MODEL.Curso();
                    Curso.id = Convert.ToInt32(reader[0].ToString());
                    Curso.descricao = reader["descricao"].ToString();


                    lstCurso.Add(Curso);


                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Curso por Nome...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCurso;
        }// string da descriçao 


        public void Insert(MODEL.Curso Curso)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Curso values (@desrcicao )";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", Curso.descricao);
            ;


            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Curso...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Curso Curso)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Curso set  descricao=@descricao, ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Curso.id);
            cmd.Parameters.AddWithValue("@descricao", Curso.descricao);
            conexao.Open();

            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Curso");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Curso Curso)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Curso where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Curso.descricao);
            conexao.Open();

            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Curso");
            }
            finally
            {
                conexao.Close();
            }

        }


        internal List<MODEL.Curso> SelectByDescricao(int descricao)
        {
            throw new NotImplementedException();
        }
    }
}




