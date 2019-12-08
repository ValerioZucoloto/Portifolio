using System;

class  ContaUsuario {
        public int NumeroDaConta {get; set;}
        public string Titular {get; set;}
        public double Saldo {get; protected set;}

        public ContaUsuario (int numero, string titular, double saldo) {
                NumeroDaConta = numero;
                Titular = titular;
                Saldo = saldo;
        }

        public ContaUsuario() {

        }

        public virtual void Saque (double quantia) {
                Saldo = Saldo - quantia - 5;
        }

        public void Deposito (double quantia) {
                Saldo = Saldo + quantia;
        }


} 