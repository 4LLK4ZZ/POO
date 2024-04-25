// função Main()
using ConstrutorAluno;

Aluno a1 = new Aluno("João", 7.5, 8.0);
a1.MostrarAtributos();

Aluno a2 = new Aluno("Maria", 6.0, 9.0);
a2.MostrarAtributos();

Aluno a3 = new Aluno("Arthur");
a3.P1 = 8.0;
a3.P2 = 7.0;
a3.CalcularMedia();
a3.MostrarAtributos();

Aluno a4 = new Aluno("Letícia");
a4.P1 = 9.0;
a4.P2 = 9.5;
a4.CalcularMedia();
a4.MostrarAtributos();
