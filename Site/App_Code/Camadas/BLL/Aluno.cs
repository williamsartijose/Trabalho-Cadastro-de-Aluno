using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Aluno
    {


        public List<MODEL.Aluno> Select()
        {

            DAL.Aluno dalAluno = new DAL.Aluno();

            return dalAluno.Select();
        }

        public List<MODEL.Aluno> SelectById(int id)
        {
            DAL.Aluno dalAluno = new DAL.Aluno();
            return dalAluno.SelectById(id);
        }

        public List<MODEL.Aluno> SelectByNome(string nome)
        {
            DAL.Aluno dalAluno = new DAL.Aluno();

            return dalAluno.SelectByNome(nome);
        }

        public void Insert(MODEL.Aluno Aluno)
        {
            DAL.Aluno dalAluno = new DAL.Aluno();
            dalAluno.Insert(Aluno);
        }

        public void Update(MODEL.Aluno Aluno)
        {
            DAL.Aluno dalAluno = new DAL.Aluno();
            dalAluno.Update(Aluno);
        }

        public void Delete(MODEL.Aluno Aluno)
        {
            DAL.Aluno dalAluno = new DAL.Aluno();
            dalAluno.Delete(Aluno);
        }
    }
}


