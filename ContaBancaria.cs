using System;

class ContaBancaria {
        private int NumeroConta;
        private string Titular;
        private double Saldo;

        public int GetNumeroConta() {
                return NumeroConta;
        }

        public string GetTitular() {
                return Titular;
        }

        public double GetSaldo() {
                return Saldo;
        }

        public void SetSaldo (double valor) {
                Saldo = valor;
        }

        public ContaBancaria (int numeroConta, string titular, double saldo) {
                NumeroConta = numeroConta;
                Titular = titular;
                Saldo = saldo;
        }

        public ContaBancaria (int numeroConta, string titular) {
                this.NumeroConta = numeroConta;
                this.Titular = titular;
                
        }

        public void Saque (double quantia) {
                Saldo = Saldo - quantia - 5;
        }

        public void Deposito (double quantia) {
                Saldo = Saldo + quantia;
        }

        public override string ToString() {
                return "Conta: " + NumeroConta + " , Titular: " + Titular + " , Saldo:  " + Saldo;

        }
        

        
}