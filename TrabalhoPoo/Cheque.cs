using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }
        public int Situacao { get; set; }

        public Cheque(Venda venda, long numero, DateTime dataDeposito, int situacao) : base(venda)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = situacao;
        }
    }
}