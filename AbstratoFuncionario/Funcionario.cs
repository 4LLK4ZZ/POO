using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Código: "+Codigo+ " | Nome: "+Nome+ " | Salário: "+Salario);
        }

        public abstract double CalcularSalario(int diasUteis);
        //Assinatura de método, sabemos o que o método faz pelo nome dele, 
        //sabemos se precisa de valor externo para atender o desenvolvimento da lógica (parâmetro) 
        //e se ocorrerá a saída de valor (return).
    }

}