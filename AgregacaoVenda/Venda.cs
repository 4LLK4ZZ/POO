class Venda
{
    private Comprador comprador;
    private Vendedor vendedor;
    private List<Produto> listaProdutos;

    public Venda(Comprador comprador, Vendedor vendedor)
    {
        this.comprador = comprador;
        this.vendedor = vendedor;
        listaProdutos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        listaProdutos.Add(produto);
        vendedor.CalcularComissao(produto.Preco);
        comprador.SubtrairVerba(produto.Preco);
    }

    public void MostrarAtributos()
    {
        Console.WriteLine("Detalhes da venda:");
        foreach (Produto produto in listaProdutos)
        {
            produto.MostrarAtributos();
        }
        vendedor.MostrarAtributos();
        comprador.MostrarAtributos();
    }
}