using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {
    ContaCorrente Nova = new ContaCorrente();

    Console.WriteLine ("Informe o número da conta: ");
    Nova.SetNumeroDaConta(int.Parse (Console.ReadLine()));

    Console.WriteLine ("Informe o nome do correntista: ");
    Nova.SetNome (Console.ReadLine());

    Console.WriteLine ("Informe o saldo em conta: ");
    Nova.SetSaldo (double.Parse (Console.ReadLine()));
    Console.WriteLine();

    Console.WriteLine ("Dados apresentados: " + Nova);
    Console.WriteLine();

    Console.WriteLine("Altere o nome do correntista: ");
    string X = Console.ReadLine();
    Nova.AlterarNome(X);

    Console.WriteLine("Dados atualizados: " + Nova);
    Console.WriteLine();

    Console.WriteLine("Informe o valor do depósito: ");
    double Y = double.Parse(Console.ReadLine());
    Nova.Deposito(Y);

    Console.WriteLine("Dados atualizados: " + Nova);
    Console.WriteLine();

    Console.WriteLine("Informe o valor a retirar: ");
    double Z = double.Parse(Console.ReadLine());
    Nova.Saque(Z);

    Console.WriteLine("Dados atualizados: " + Nova);
    Console.WriteLine();

    
  }
}