using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Comprador comprador = new Comprador(1000);

        Vendedor vendedor = new Vendedor();

        Produto produto1 = new Produto("Produto 1", 500);
        Produto produto2 = new Produto("Produto 2", 100);

        Venda venda = new Venda(comprador, vendedor);
        venda.AdicionarProduto(produto1);
        venda.AdicionarProduto(produto2);

        venda.MostrarAtributos();
        Console.WriteLine();

        Produto produto3 = new Produto("Produto3", -30);
        produto3.MostrarAtributos();

        Venda segundaVenda = new Venda(comprador, vendedor);
        Produto produto3SegundaVenda = new Produto("Produto 3", 400);
        Produto produto4SegundaVenda = new Produto("Produto 4", 75);
        segundaVenda.AdicionarProduto(produto3SegundaVenda);
        segundaVenda.AdicionarProduto(produto4SegundaVenda);
        segundaVenda.MostrarAtributos();

        comprador.MostrarAtributos();
    }
}
