using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

// nesses metodo criarei 3 select um para buscar por todos , por nome e por codigo tudo dentro do formulario buscar

       

        

        public List<MODEL.Cliente> Select()
        {

            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            
            try
            {
              
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection); //chama as informacoes do banco
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(reader[0].ToString());
                    cliente.nome = reader["nome"].ToString();
                    cliente.aniversario = Convert.ToDateTime(reader["aniversario"].ToString());
                    cliente.cpf = Convert.ToString(reader["cpf"].ToString());
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.bairro = reader["bairro"].ToString();
                    cliente.numero = Convert.ToInt32(reader["numero"].ToString());
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                  
                   
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cliente");
            }
            finally
            {
                conexao.Close();     
            }
            
            return lstCliente; 
        }

        
        
        public List<MODEL.Cliente> SelectById(int id)
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);// parametros por id 
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(reader[0].ToString());
                    cliente.nome = reader["nome"].ToString();
                     cliente.aniversario = Convert.ToDateTime(reader["aniversario"].ToString());
                    cliente.cpf = Convert.ToString(reader["cpf"].ToString());
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.bairro = reader["bairro"].ToString();
                    cliente.numero = Convert.ToInt32(reader["numero"].ToString());
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                   
                    lstCliente.Add(cliente);

                    
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cliente por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }// int id 


        public List<MODEL.Cliente> SelectByNome(string nome)
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");// parametros por nome
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(reader[0].ToString());
                    cliente.nome = reader["nome"].ToString();
                    cliente.aniversario = Convert.ToDateTime(reader["aniversario"].ToString());
                     cliente.cpf = Convert.ToString(reader["cpf"].ToString());
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.bairro = reader["bairro"].ToString();
                    cliente.numero = Convert.ToInt32(reader["numero"].ToString());
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    
               
                   
                    lstCliente.Add(cliente);

                   
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cliente por Nome...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }// string nome 

        
        public void Insert (MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values (@nome, @aniversario, @cpf , @endereco, @bairro , @numero, @cidade, @estado )";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@aniversario", cliente.aniversario);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            
          
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Cliente...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome, ";
            sql += " aniversario=@aniversario, cpf=@cpf,  ";
            sql += " endereco=@endereco, bairro=@bairro,    ";
            sql += " numero=@numero, cidade=@cidade, estado=@estado ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@aniversario", cliente.aniversario);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            conexao.Open(); 
          
            try
            {
              
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Cliente cliente) {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            conexao.Open();
            
            try
            {
                
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Cliente");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}




