using System;

namespace ByteBank {

    class Cliente {

        private string _Nome { get; set; }
        private string _Cpf { get; set; }
        private string _Email { get; set; }
        private string _Senha { get; set; }

        public string Senha
        {
            get {return _Senha;}
            set {_Senha = value;}
        }

        public string Cpf
        {
            get {return _Cpf;}
            set {_Cpf = value;}
        }

        public string Nome
        {
            get {return _Nome;}
            set{_Nome = value;}
        }

        public string Email
        {
            get {return _Email;}
            set {_Email = value;}
        }

        public Cliente (string Nome, string Cpf, string Email) {
            this._Nome = Nome;
            this._Cpf = Cpf;
            this._Email = Email;
        }

        public bool TrocaSenha (string Senha) {
            if (Senha.Length > 6 && Senha.Length < 16) {
                this._Senha = Senha;
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
        private double _Saldo;

        public double Saldo
        {
            get {return  _Saldo;}
            //set {_Saldo = value;}
        }

        public ContaCorrente (int Agencia, int Numero, Cliente Titular) 
        {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this._Saldo = 0;
        }

        public bool Deposito(double valor)
        { 
            if(valor >= 1)
            {
                this._Saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Saque(double valor)
        {
        if(valor >=0)
        { 
            if(this._Saldo >= valor)
            {
                this._Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
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