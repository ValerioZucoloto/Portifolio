using System;

 sealed class ContaPoupanca : ContaUsuario {
        public double TaxaDeJuros {get; set;}

        public ContaPoupanca() {

        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaDeJuros) : base (numero, titular, saldo) {
                TaxaDeJuros = taxaDeJuros;
        }

        public void SaldoAtualizado() {
                Saldo = Saldo * TaxaDeJuros;
        }

        public override void Saque (double quantia) {
                base.Saque (quantia);
                Saldo = Saldo - 2;
        }
}