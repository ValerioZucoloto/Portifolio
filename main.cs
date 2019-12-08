using System;

class MainClass {
  public static void Main (string[] args) {
    Funcionario F = new Funcionario();

    Console.WriteLine ("Nome: ");
    F.Nome = Console.ReadLine();

    Console.WriteLine ("Salário bruto: ");
    F.SalarioBruto = double.Parse (Console.ReadLine());

    Console.WriteLine ("Imposto: ");
    F.Imposto = double.Parse (Console.ReadLine());

    Console.WriteLine ("Funcionario: " + F.Nome + "," + " $ " + F.SalarioLiquido());
    Console.WriteLine();

    Console.WriteLine ("Digite a porcentagem para aumentar o salário: ");
    int qte = int.Parse (Console.ReadLine());
    F.AumentarSalario(qte);
    Console.WriteLine();

    Console.WriteLine ("Dados atualizados: " + F);
  }
}