using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public static int Contador { get; set; }
        public Conta()//construtor padrão
        {
            Contador ++;
        }

        static Conta()//Valor estático prevalece em caso de mais de um contador, 
        //Construtores estáticos prevalecem de qualquer construtor
        {
            Contador = 2220;
        }
        public Conta(int numero)
        {
            Numero = numero;
            Contador ++;
        }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
            Contador ++;
        }
        public Conta(int numero, double saldo, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Contador ++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero +
            "\tTitular: " + Titular + "\tSaldo: "+ Saldo);
        }
    }
}