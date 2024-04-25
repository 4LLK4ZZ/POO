class Comprador
{
    public double Verba { get; private set; }

    public Comprador(double verbaInicial)
    {
        Verba = verbaInicial;
    }

    public void SubtrairVerba(double valor)
    {
        Verba -= valor;
    }

    public void MostrarAtributos()
    {
        Console.WriteLine("Verba do comprador: " + Verba);
    }
}
