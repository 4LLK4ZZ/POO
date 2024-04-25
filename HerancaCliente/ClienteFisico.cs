using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    //Classe DERIVADA : Classe BASE
    public class ClienteFisico : Cliente
    {
        private int rg;

        public ClienteFisico() : base()
        {
            
        }
        public ClienteFisico(int codigo, string nome, string endereco, int rg) : base(codigo, nome, endereco)
        {
            Rg = rg;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("| RG: "+Rg);
        }
        
        public int Rg{
            get{return rg;}
            set{rg = value;}
        }
    }
}