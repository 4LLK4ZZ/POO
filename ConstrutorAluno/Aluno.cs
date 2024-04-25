using System;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private static int gerarMatricula = 15723220;

        public string Nome { get; set; }
        public int Matricula { get; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        private double media;

        public Aluno()
        {
            Matricula = GerarMatricula();
            Nome = "";
        }

        public Aluno(string nome)
        {
            Matricula = GerarMatricula();
            Nome = nome;
        }

        public Aluno(string nome, double p1)
        {
            Matricula = GerarMatricula();
            Nome = nome;
            P1 = p1;
        }

        public Aluno(string nome, double p1, double p2)
        {
            Matricula = GerarMatricula();
            Nome = nome;
            P1 = p1;
            P2 = p2;
            CalcularMedia();
        }

        private static int GerarMatricula()
        {
            return gerarMatricula++;
        }

        public void CalcularMedia()
        {
            media = (P1 + P2) / 2;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Matrícula: " + Matricula +
                "\tNome: " + Nome + "\tNota da P1: " + P1 +
                "\tNota da P2: " + P2 + "\tMédia Final: " + media);
        }
    }
}
