using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Curso
    {


        public List<MODEL.Curso> Select()
        {

            DAL.Curso dalCurso = new DAL.Curso();

            return dalCurso.Select();
        }

        public List<MODEL.Curso> SelectById(int id)
        {
            DAL.Curso dalCurso = new DAL.Curso();
            return dalCurso.SelectById(id);
        }

        public List<MODEL.Curso> SelectByDescricao(string descricao)
        {
            DAL.Curso dalCurso = new DAL.Curso();

            return dalCurso.SelectByDescricao(descricao);
        }

        public void Insert(MODEL.Curso Curso)
        {
            DAL.Curso dalCurso = new DAL.Curso();
            dalCurso.Insert(Curso);
        }

        public void Update(MODEL.Curso Curso)
        {
            DAL.Curso dalCurso = new DAL.Curso();
            dalCurso.Update(Curso);
        }

        public void Delete(MODEL.Curso Curso)
        {
            DAL.Curso dalCurso = new DAL.Curso();
            dalCurso.Delete(Curso);
        }
    }
}



