using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.DAL
{
   public  class Livro
    {

        private string strCon = Conexao.getConexao();

        public List<MODEL.Livro> Select()
        {
            List<MODEL.Livro> lstLivro = new List<MODEL.Livro>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Livro";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Livro liv = new MODEL.Livro();
                    liv.id = Convert.ToInt32(reader[0].ToString());
                    liv.titulo = reader["titulo"].ToString();
                    liv.edicao = Convert.ToInt32(reader[0].ToString());
                    liv.genero = reader["genero"].ToString();
                    liv.quantidade = Convert.ToInt32(reader[0].ToString());
                    liv.autor = reader["autor"].ToString();
                    lstLivro.Add(liv);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção do livro");
            }
            finally
            {
                conexao.Close();
            }

            return lstLivro;
        }



         public List<MODEL.Livro> SelectById(int id)
        {
             List<MODEL.Livro> lstLivro = new List<MODEL.Livro>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Livro where id=@id ;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Livro livro = new MODEL.Livro();
                   livro.id = Convert.ToInt32(reader[0].ToString());
                     livro.titulo= reader["titulo"].ToString();
                    livro.edicao = Convert.ToInt32(reader.ToString());
                    livro.quantidade = Convert.ToInt32(reader.ToString());
                    livro.genero  = reader["genero"].ToString();
                    livro.autor = reader["autor"].ToString();

                   

                    
                   lstLivro.Add(livro);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de livro por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstLivro;
        }


        public List<MODEL.Livro> SelectByNome(string titulo)
        {
            List<MODEL.Livro> lstLivro = new List<MODEL.Livro>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Livro where (titulo like @titulo);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@titulo", titulo.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Livro livro = new MODEL.Livro();
                    livro.id = Convert.ToInt32(reader[0].ToString());
                    livro.titulo = reader["titulo"].ToString();
                    livro.edicao = Convert.ToInt32(reader.ToString());
                    livro.quantidade = Convert.ToInt32(reader.ToString());
                    livro.genero = reader["genero"].ToString();
                    livro.autor = reader["autor"].ToString();

                    
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de livro por Nome...");
            }
            finally
            {
                conexao.Close();
            }

            return lstLivro;
        }

        public void Insert(MODEL.Livro liv)
        {

     
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Livro values (@titulo, @edicao, @quantidade,  @genero, @autor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@titulo", liv.titulo);
            cmd.Parameters.AddWithValue("@edicao ", liv.edicao);
            cmd.Parameters.AddWithValue("@quantidade", liv.quantidade);
            cmd.Parameters.AddWithValue("@genero", liv.genero);
            cmd.Parameters.AddWithValue("@autor", liv.autor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Livros...");
            }
            finally
            {
                conexao.Close();
            }
        }
           

        public void Update(MODEL.Livro liv)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Livro set id=@id,";
            sql += " titulo=@titulo,edicao=@edicao,";
            sql += "quantidade=@quantidade,genero=@genero,";
            sql += "autor=@autor,";
            sql += " where id_livro=@id_livro;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", liv.id);
            cmd.Parameters.AddWithValue("@titulo", liv.titulo);
            cmd.Parameters.AddWithValue("@edicao", liv.edicao);
            cmd.Parameters.AddWithValue("@quantidade", liv.quantidade);
            cmd.Parameters.AddWithValue("@genero", liv.genero);
            cmd.Parameters.AddWithValue("@autor", liv.autor);
            

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização do Livro");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Livro liv)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Livro where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", liv.id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção dos Livros");
            }
            finally
            {
                conexao.Close();
            }

        }



     
        }
    }




