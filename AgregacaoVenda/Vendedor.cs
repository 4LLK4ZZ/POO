class Vendedor
{
    public double Comissao { get; private set; }

    public Vendedor()
    {
        Comissao = 0;
    }

    public void CalcularComissao(double valorProduto)
    {
        Comissao += 0.02 * valorProduto;
    }

    public void MostrarAtributos()
    {
        Console.WriteLine("Comissão do vendedor: " + Comissao);
    }
}
