// Método Main()
using PolimorfismoFuncionario;
using System;

Funcionario f1 = new Funcionario(1, "Ana", 1000);
Console.WriteLine("Bonificação do funcionário: " + f1.CalcularBonificacao());

Secretario s1 = new Secretario(2, "Bel", 1000);
Console.WriteLine("Bonificação do secretario: " + s1.CalcularBonificacao());

Gerente g1 = new Gerente(3,"Bia",1000);
Console.WriteLine("Bonificação do gerente: " + g1.CalcularBonificacao());

Diretor d1 = new Diretor(4, "Leo", 1000);
Console.WriteLine("Bonificação do diretor: " + d1.CalcularBonificacao());

Funcionario f2 = new Funcionario(1, "Thiago", 1000);
Secretario s2 = new Secretario(2, "Bianca", 1000);
Gerente g2 = new Gerente(3, "Carla", 1000);
Diretor d2 = new Diretor(4, "Lucas", 1000);

GerenciarBonificacao gerenciador = new GerenciarBonificacao();

gerenciador.RegistrarBonificacoes(f2);
gerenciador.RegistrarBonificacoes(s2);
gerenciador.RegistrarBonificacoes(g2);
gerenciador.RegistrarBonificacoes(d2);

Console.WriteLine("Total de Bonificações: " + gerenciador.TotalBonificacao);