using InterfaceTributavel;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente c = new ContaCorrente(2300);
        SeguroDeVida s = new SeguroDeVida();

        TotalizadorDeTributos tz = new TotalizadorDeTributos();
        tz.Add(c);
        tz.Add(s);

        Console.WriteLine($"Total de impostos: R${tz.Total}");
    }
}