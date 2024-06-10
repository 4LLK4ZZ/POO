using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    public class Pagamento
    {
        public DateTime Data { get; set; }
        public Venda Venda { get; set; }
        public double Total => Venda.Total;

        public Pagamento(Venda venda)
        {
            Venda = venda;
            Data = DateTime.Now;
        }
    }
}