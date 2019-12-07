using System;

class MainClass {
  public static void Main (string[] args) {
          Console.WriteLine("Digite um número: ");
                double x = double.Parse (Console.ReadLine());

        double raiz = Math.Sqrt (x);

        Console.WriteLine (raiz.ToString ("F3"));
        
        while (x >= 0.0 ) {
                Console.Write("Digite outro número: ");
                        x = double.Parse (Console.ReadLine());

                        raiz = Math.Sqrt (x);
                        Console.WriteLine (raiz.ToString ("F3"));

         }

         Console.WriteLine ("Número negativo!");




  }
}