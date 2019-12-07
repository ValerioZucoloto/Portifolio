using System;

class MainClass {
  public static void Main (string[] args) {
    
    int num1= 0, num2= 0;

    Console.WriteLine ("Informe um número: ");
    string entrada = Console.ReadLine();
    num1 = Convert.ToInt32(entrada);

    Console.WriteLine ("Informe um número: ");
    entrada = Console.ReadLine();
    num2 = Convert.ToInt32(entrada);

    int soma = num1 + num2;
    Console.WriteLine ("Soma: {0}", soma);

  }
}