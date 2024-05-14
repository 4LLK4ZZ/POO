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