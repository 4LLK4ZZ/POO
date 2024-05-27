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

        public List<Dependente> Dependentes { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Dependentes = new List<Dependente>();

        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Código: "+Codigo+ " | Nome: "+Nome+ " | Salário: "+Salario);
        }

        public abstract double CalcularSalario(int diasUteis);
        //Assinatura de método, sabemos o que o método faz pelo nome dele, 
        //sabemos se precisa de valor externo para atender o desenvolvimento da lógica (parâmetro) 
        //e se ocorrerá a saída de valor (return).

        public void AdicionarDependente(Dependente dependente)
        {
            Dependentes.Add(dependente);
        }

        public void RemoverDependente(string nome)
        {
            Dependente dependente = Dependentes.Find(d => d.Nome == nome);
            if (dependente != null)
            {
                Dependentes.Remove(dependente);
            }
        }

        public void ListarDependentes()
        {
            Console.WriteLine($"Dependentes do funcionário {Nome}:");
            foreach (var dependente in Dependentes)
            {
                Console.WriteLine($"Nome: {dependente.Nome}, Idade: {dependente.Idade}");
            }
        }

        public int CalcTotalDep()
        {
            return Dependentes.Count;
        }
    }
}