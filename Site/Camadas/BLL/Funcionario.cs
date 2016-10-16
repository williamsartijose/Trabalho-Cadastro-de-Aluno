using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Funcionario
    {
        // criando os 3 select para id  para nome  e um select  
        public List<MODEL.Funcionario> Select()
        {
            DAL.Funcionario dalFuncionario = new DAL.Funcionario();

            return dalFuncionario.Select();
        }

        public List<MODEL.Funcionario> SelectById(int id)
        {
            DAL.Funcionario dalFuncionario = new DAL.Funcionario();

            return dalFuncionario.SelectById(id);
        }/// id 

        public List<MODEL.Funcionario> SelectByNome(string nome)
        {
            DAL.Funcionario dalFuncionario = new DAL.Funcionario();

            return dalFuncionario.SelectByNome(nome);
        }// nome 

        public void Insert(MODEL.Funcionario  funcionario)
        {
            DAL.Funcionario dalFuncionario = new DAL.Funcionario();
            
            dalFuncionario.Insert(funcionario);
        }///insert para inserir 

        public void Update(MODEL.Funcionario funcionario)
        {
            DAL.Funcionario dalFuncionario = new DAL.Funcionario();
            dalFuncionario.Update(funcionario);
        }/// um update para atualizar 

        public void Delete(MODEL.Funcionario funcionario)
        {
            DAL.Funcionario dalFuncionario = new DAL.Funcionario();

            dalFuncionario.Delete(funcionario);
        }//um para deletar as informaçoes
    }
}



