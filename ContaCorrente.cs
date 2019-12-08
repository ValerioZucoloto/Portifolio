using System;

class ContaCorrente {
        private int NumeroDaConta;
        private string Nome;
        private double Saldo;

        public double GetSaldo() {
                return Saldo;                
        }

        public void SetSaldo (double S) {
                Saldo = S;
        }

        public int GetNumeroDaConta() {
                return NumeroDaConta;
        }

        public void SetNumeroDaConta(int N) {
                NumeroDaConta = N;
        }

        public string GetNome() {
                return Nome;
        }

        public void SetNome(string name) {
                Nome = name;
        }

        public void AlterarNome(string novo) {
                Nome = novo;
        }

        
        public void Deposito(double dep) {
                Saldo = Saldo + dep;
        }

        public void Saque(double sac) {
                Saldo = Saldo - sac;
        }

        public override string ToString() {
                return Nome + " , " + "Número da conta: " + NumeroDaConta +  " , "  + " Saldo: $ " + Saldo;
        }

        

        
}