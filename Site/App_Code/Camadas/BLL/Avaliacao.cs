using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Avaliacao
    {


        public List<MODEL.Avaliacao> Select()
        {

            DAL.Avaliacao dalAvaliacao = new DAL.Avaliacao();

            return dalAvaliacao.Select();
        }

        public List<MODEL.Avaliacao> SelectByNota(int nota)
        {
            DAL.Avaliacao dalAvaliacao = new DAL.Avaliacao();
            return dalAvaliacao.SelectByNota(nota);
        }

        public List<MODEL.Avaliacao> SelectByAno(string ano)
        {
            DAL.Avaliacao dalAvaliacao = new DAL.Avaliacao();

            return dalAvaliacao.SelectByAno(ano);
        }

        public void Insert(MODEL.Avaliacao avaliacao)
        {
            DAL.Avaliacao dalAvaliacao = new DAL.Avaliacao();
            dalAvaliacao.Insert(avaliacao);
        }

        public void Update(MODEL.Avaliacao avaliacao)
        {
            DAL.Avaliacao dalAvaliacao = new DAL.Avaliacao();
            dalAvaliacao.Update(avaliacao);
        }

        public void Delete(MODEL.Avaliacao avaliacao)
        {
            DAL.Avaliacao dalAvaliacao = new DAL.Avaliacao();
            dalAvaliacao.Delete(avaliacao);
        }
    }
}

      
