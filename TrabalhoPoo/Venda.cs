using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
        public double Total
        {
            get
            {
                double total = 0;
                int quantidadeTotal = 0;
                foreach (var item in Itens)
                {
                    total += item.Subtotal;
                    quantidadeTotal += item.Quantidade;
                }
                if (quantidadeTotal >= 50)
                {
                    total *= 0.8;
                }
                return total;
            }
        }
        public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
        }
    }
}