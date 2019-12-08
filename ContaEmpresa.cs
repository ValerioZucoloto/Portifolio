using System;

class ContaEmpresa : ContaUsuario {
        public double LimiteEmprestimo {get; set;}

        public ContaEmpresa(){

        }

        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo) : base (numero, titular, saldo) {
                LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo (double quantia) {
                if (quantia <= LimiteEmprestimo )
                {
                        Saldo  = Saldo + quantia;
                }
        }


}