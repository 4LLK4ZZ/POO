using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class Cliente //TODO:Não pode instanciar
    {
        protected int codigo;
        protected string nome;
        protected string endereco;

        public Cliente()
        {
        }

        public Cliente(int codigo, string nome, string endereco)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
        }

        public int Codigo{
            get{return codigo;}
            set{codigo = value;}
        }

        public string Nome{
            get{return nome;}
            set{nome = value;}
        }

        public string Endereco{
            get{return endereco;}
            set{endereco = value;}
        }

        public abstract void Mostrar();
        //{
        //    
        //}

    }
}