using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int Agencia, int NumeroConta, string Titular) : base(Agencian, NumeroConta, Titular)
        {

        }

        public override bool Saque(double Valor)//estou usando override pois sou obrigado a sobrescrever o codigo/ override sobrescreve um metodo abstract
        {
            if(Valor >= 0)
            {
                if(Valor <= this.Saldo)
                {
                    this.Saldo -= Valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}