using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.HerancaFuncionario
{
    public class Horista : Funcionario
    {
        private int qtdHrsTrab;

        public Horista() : base()
        {
        }

        public Horista(int codigo, string nome, double salario, int qtdHrsTrab) : base(codigo, nome, salario)
        {
            QtdHrsTrab = qtdHrsTrab;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("| Qtd de Horas Trabalhadas: "+QtdHrsTrab);
        }
        
        public int QtdHrsTrab{
            get{return qtdHrsTrab;}
            set{qtdHrsTrab = value;}
        }
    }
}