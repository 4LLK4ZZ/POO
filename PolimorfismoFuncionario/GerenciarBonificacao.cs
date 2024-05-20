using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciarBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void RegistrarBonificacoes(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.CalcularBonificacao();
        }

        public void RegistrarBonificacoes(Secretario secretario)
        {
            this.TotalBonificacao += secretario.CalcularBonificacao();
        }

        public void RegistrarBonificacoes(Gerente gerente)
        {
            this.TotalBonificacao += gerente.CalcularBonificacao();
        }

        public void RegistrarBonificacoes(Diretor diretor)
        {
            this.TotalBonificacao += diretor.CalcularBonificacao();
        }
    }
}