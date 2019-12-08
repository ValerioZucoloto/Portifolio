using System;

class FuncionarioTerceiro : FuncionarioProprio {
        public double DespesaAdicional {get; set;}


        public FuncionarioTerceiro (string nome, int horasTrabalhadas, double valorporhora, double despesaAdicional) : base(nome, horasTrabalhadas, valorporhora) {
                DespesaAdicional = despesaAdicional;
        }


        public override double Pagamento() {
                return base.Pagamento() + 1.1 * DespesaAdicional;
        }
}