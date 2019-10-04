using System;

namespace ByteBank {

    class Cliente {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Cliente (string Nome, string Cpf, string Email) {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        public bool TrocaSenha (string Senha) {
            if (Senha.Length > 6 && Senha.Length < 16) {
                this.Senha = Senha;
                return true;
            } else {
                return false;
            }
        }
    }

    class ContaCorrente {

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (int Agencia, int Numero, Cliente Titular) 
        {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0;
        }

        public double Deposito(double valor)
        {
            return this.Saldo += valor;
        }
        public bool Saque(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferencia(ContaCorrente contaDestino, double valor)
        {
            if(this.Saque(valor))
            {
                contaDestino.Deposito(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}