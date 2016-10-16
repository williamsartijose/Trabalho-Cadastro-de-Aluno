using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.MODEL
{
   public class Itens_Locacao
    {
        public int id { get; set; }
        public int locacao_id { get; set; }
        public int Livro_id { get; set; }
        public char status { get; set; }
    }
}


