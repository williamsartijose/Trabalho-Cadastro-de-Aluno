using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Cliente
    {


        public List<MODEL.Cliente> Select()
        {

            DAL.Cliente dalCli = new DAL.Cliente();

            return dalCli.Select();
        }

        public List<MODEL.Cliente> SelectById(int id)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.SelectById(id);
        }

        public List<MODEL.Cliente> SelectByNome(string nome)
        {
            DAL.Cliente dalCli = new DAL.Cliente();

            return dalCli.SelectByNome(nome);
        }

        public void Insert(MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dalCli.Insert(cliente);
        }

        public void Update(MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dalCli.Update(cliente);
        }

        public void Delete(MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dalCli.Delete(cliente);
        }
    }
}

           
    
