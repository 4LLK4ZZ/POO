class Produto
{
    private static int codigoInicial = 500;

    private int codigo;
    private string nome;
    private double preco;

    public Produto(string nome, double preco)
    {
        this.codigo = codigoInicial++;
        this.nome = nome;
        Preco = preco;
    }

    public double Preco
    {
        get { return preco; }
        set
        {
            if (value >= 0)
                preco = value;
            else
                preco = 0;
        }
    }

    public void MostrarAtributos()
    {
        Console.WriteLine($"Código: {codigo}, Nome: {nome}, Preço: {preco}");
    }
}
