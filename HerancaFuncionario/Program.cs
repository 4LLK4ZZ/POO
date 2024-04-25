//método Main
using POO.HerancaFuncionario;

Funcionario f = new Funcionario();
f.Codigo = 1;
f.Nome = "Luíza";
f.Salario = 3200;

Horista h = new Horista();
h.Codigo = 11;
h.Nome = "Cléber";
h.Salario = 2750;
h.QtdHrsTrab = 10;
h.Mostrar();

Horista h2 = new Horista(12, "Júlio", 2900, 12);
h2.Mostrar();

Mensalista m = new Mensalista();
m.Codigo = 21;
m.Nome = "Gabriela";
m.Salario = 3100;
m.QtdHrsSemana = 42;
m.Mostrar();

Mensalista m2 = new Mensalista(22, "Arthur", 3000, 40);
m2.Mostrar();

