using System;

class MainClass {
  public static void Main (string[] args) {
    

    ContaBancaria conta;

    Console.WriteLine ("Entre o número da conta: ");
    int numero = int.Parse (Console.ReadLine());

    Console.WriteLine("Entre o titular da conta: ");
    string nome = Console.ReadLine();

    Console.WriteLine ("Haverá depósito inicial (s/n) ?");
    char resp = char.Parse (Console.ReadLine());
    if (resp == 's' || resp == 'S') {
            Console.WriteLine ("Entre o valor do depósito inicial: ");
            double DepositoInicial = double.Parse (Console.ReadLine());
            conta = new ContaBancaria (numero, nome, DepositoInicial);
    }
    else {
            conta = new ContaBancaria (numero, nome);
    }

    Console.WriteLine();

    Console.WriteLine ("Dados da conta: ");
    Console.WriteLine (conta);
    Console.WriteLine();

    Console.WriteLine("Entre um valor para depósito: ");
    double quantia = double.Parse (Console.ReadLine());
    conta.Deposito(quantia);

    Console.Write ("Dados da conta atualizados: ");
    Console.WriteLine (conta);

    Console.WriteLine ("Entre um valor para saque: ");
    double valor = double.Parse (Console.ReadLine());
    conta.Saque(valor);

    Console.WriteLine ("Dados atualizados: ");
    Console.WriteLine (conta);


  }
}