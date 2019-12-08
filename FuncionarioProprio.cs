using System;

class FuncionarioProprio {
        public string Nome {get; set;}
        public int HorasTrabalhadas {get; set;}
        public double ValorPorHora {get; set;}

        public FuncionarioProprio (string nome, int horasTrabalhadas, double valorporhora) {
                Nome = nome;
                HorasTrabalhadas = horasTrabalhadas;
                ValorPorHora = valorporhora;
        }

        public FuncionarioProprio(){

        }

        public virtual double Pagamento() {
               return ValorPorHora * HorasTrabalhadas;
        }
}