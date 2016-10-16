using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Itens_Locacao
    {
        public List<MODEL.Itens_Locacao> Select()
        {
            DAL.Itens_Locacao dalItLoc = new DAL.Itens_Locacao();

            return dalItLoc.Select();
        }

        public List<MODEL.Itens_Locacao> SelectByLocacao(int idLocacao)
        {
            DAL.Itens_Locacao dalItLoc = new DAL.Itens_Locacao();

            return dalItLoc.SelectByLocacao(idLocacao);
        }

        public void Insert(MODEL.Itens_Locacao item_locacao)
        {
            DAL.Itens_Locacao dalItLoc = new DAL.Itens_Locacao();
            //
            dalItLoc.Insert(item_locacao);
        }

        public void Update(MODEL.Itens_Locacao item_locacao)
        {
            DAL.Itens_Locacao dalItLoc = new DAL.Itens_Locacao();
            dalItLoc.Update(item_locacao);
        }

        public void Delete(MODEL.Itens_Locacao item_locacao)
        {
            DAL.Itens_Locacao dalItLoc = new DAL.Itens_Locacao();

            dalItLoc.Delete(item_locacao);
        }
    }
}


