using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        private int qtdHrsSemana;

        public Mensalista() : base()
        {
        }

        public Mensalista(int codigo, string nome, double salario, int qtdHrsSemana) : base(codigo, nome, salario)
        {
            QtdHrsSemana = qtdHrsSemana;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("| Qtd de Horas Semanais: "+QtdHrsSemana);
        }
        
        public int QtdHrsSemana{
            get{return qtdHrsSemana;}
            set{qtdHrsSemana = value;}
        }
    }
}