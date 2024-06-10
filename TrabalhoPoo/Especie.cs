using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    public class Especie : Pagamento
    {
        public double Quantia { get; set; }
        public double Troco => Quantia - Total;

        public Especie(Venda venda, double quantia) : base(venda)
        {
            Quantia = quantia;
        }
    }
}