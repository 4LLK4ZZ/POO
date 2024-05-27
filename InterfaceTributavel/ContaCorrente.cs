using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
{
    private double saldo;

    public ContaCorrente(double saldo)
    {
        this.saldo = saldo;
    }

    public double CalculaTributos()
    {
        return saldo * 0.05;
    }
}
}