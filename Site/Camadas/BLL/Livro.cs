using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Livro
    {
       
        public List<MODEL.Livro> Select()
        {
            DAL.Livro dallivro = new DAL.Livro();

            return dallivro.Select();
        }

        public List<MODEL.Livro> SelectById(int id_livro)
        {
            DAL.Livro dallivro = new DAL.Livro();
            return dallivro.SelectById(id_livro);
        }



        public List<MODEL.Livro> SelectByNome(string titulo)
        {
            DAL.Livro dallivro = new DAL.Livro();

            return dallivro.SelectByNome(titulo);
        }


         
        public void Insert(MODEL.Livro liv)
        {
            DAL.Livro dallivro = new DAL.Livro();


            dallivro.Insert(liv);
        }

        public void Update(MODEL.Livro liv)
        {
            DAL.Livro dallivro = new DAL.Livro();
            dallivro.Update(liv);
        }

        public void Delete(MODEL.Livro liv)
        {
            DAL.Livro dallivro = new DAL.Livro();

            dallivro.Delete(liv);
        }

        
    }
}



