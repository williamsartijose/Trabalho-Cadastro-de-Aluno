using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.MODEL
{
   public class Locacao
    {
         public int id { get; set; }
        public DateTime data { get; set; }
        public int cliente_id { get; set; }
    }
}
