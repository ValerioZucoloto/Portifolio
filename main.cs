using System;

class MainClass {
  public static void Main (string[] args) {
    int porta, chute;

    Console.WriteLine ("Informe a porta: ");
    porta = int.Parse (Console.ReadLine());

    


    for (int i=0; i < 5; i++) {
      
      Console.WriteLine ("Primeiro jogador, digite um chute: ");
      chute = int.Parse (Console.ReadLine());
      if (chute == porta) {
        Console.WriteLine ("Você me achou !");
        break;
      }

      if (chute < porta) {
        Console.WriteLine ("Estou mais a direita !");
      }

      if (chute > porta) {
        Console.WriteLine ("Estou mais a esquerda !");
      }

      Console.WriteLine ("Segundo jogador, digite um chute: ");
      chute = int.Parse (Console.ReadLine());

      if (chute == porta) {
        Console.WriteLine ("Você me achou !");
        break;
      }

      if (chute < porta) {
        Console.WriteLine ("Estou mais a direita !");
      }

      if (chute > porta) {
        Console.WriteLine ("Estou mais a esquerda !");
      }
    
    }
  }
}