using System;

class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
                return SalarioBruto - Imposto;
        }

        public void AumentarSalario (double porcentagem) {
                SalarioBruto = (SalarioBruto + (SalarioBruto*porcentagem/100)) - Imposto;
        }

        public override string ToString() {
                return Nome + "," + " $ " + SalarioBruto;
        }
}