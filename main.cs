using System;

class MainClass {
  public static void Main (string[] args) {
    int x, soma=0;

    Console.WriteLine("Entre com um número: ");
    x = int.Parse (Console.ReadLine());
    soma = soma + x;

    while (soma < 200) {
      Console.WriteLine ("Entre com um número: ");
      x = int.Parse (Console.ReadLine());

      soma = soma + x;


    }


  }
}