//Método main()
using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Alberto", 2000);
Assalariado a2 = new Assalariado(2, "Camila", 2500);

Comissionado c1 = new Comissionado(3, "Luana", 1700, 20);
Comissionado c2 = new Comissionado(3, "Matheus", 1800, 20);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();

d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();

Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionarios();

Dependente dep1 = new Dependente("Maria", 25);
Dependente dep2 = new Dependente("João", 18);

a1.AdicionarDependente(dep1);
a2.AdicionarDependente(dep2);

a1.ListarDependentes();
a2.ListarDependentes();

int totalDependentesD1 = CalcTotalDepDepart(d1);
int totalDependentesD2 = CalcTotalDepDepart(d2);

Console.WriteLine($"Total de dependentes no departamento {d1.Nome}: {totalDependentesD1}");
Console.WriteLine($"Total de dependentes no departamento {d2.Nome}: {totalDependentesD2}");

int CalcTotalDepDepart(Departamento departamento)
{
    int totalDependentes = 0;
    foreach (var funcionario in departamento.VetF)
    {
        totalDependentes += funcionario.CalcTotalDep();
    }
    return totalDependentes;
}