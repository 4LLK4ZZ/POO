using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    //Classe DERIVADA : Classe BASE
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        public ClienteJuridico() : base()
        {
            
        }
        public ClienteJuridico(int codigo, string nome, string endereco, int cnpj) : base(codigo, nome, endereco)
        {
            Cnpj = cnpj;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("| CNPJ: "+Cnpj);
        }

        public int Cnpj{
            get{return cnpj;}
            set{cnpj = value;}
        }
    }
}