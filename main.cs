using System;

class MainClass {
  public static void Main (string[] args) {
    int a,b,c;
    int Maior;
    Console.WriteLine ("A:");
    a = int.Parse (Console.ReadLine());
        Maior=a;
    Console.WriteLine ("B:");
    b = int.Parse (Console.ReadLine());
        if (Maior < b) {
                Maior = b;
    }
    Console.WriteLine ("C:");
    c = int.Parse (Console.ReadLine());
        if (Maior < c) {
                Maior = c;
        }

        Console.WriteLine ("O maior valor de {0} e {1} e {2} é {3}", a,b,c, Maior);












  }
}