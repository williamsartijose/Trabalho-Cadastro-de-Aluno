using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
   public class Locacao
    {
        public List<MODEL.Locacao> Select()
        {
            DAL.Locacao Locacao = new DAL.Locacao();

            return Locacao.Select();
        }

        public void Insert(MODEL.Locacao locacao)
        {
            DAL.Locacao Locacao = new DAL.Locacao();
            //
            Locacao.Insert(locacao);
        }

        public void Update(MODEL.Locacao locacao)
        {
            DAL.Locacao Locacao = new DAL.Locacao();
            Locacao.Update(locacao);
        }

        public void Delete(MODEL.Locacao locacao)
        {
            DAL.Locacao Locacao = new DAL.Locacao();

            Locacao.Delete(locacao);
        }
    }
}
