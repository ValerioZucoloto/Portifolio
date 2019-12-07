using System;

class MainClass {
  public static void Main (string[] args) {
    int entrada, maior = -9999;

    for (int i=0; i < 3; i++) {
        Console.WriteLine("Digite um número: ");
        entrada = int.Parse (Console.ReadLine());
        if (entrada > maior) {
                maior = entrada;
        }

        Console.WriteLine ("O maior valor é {0}", maior);
    }
  }
}