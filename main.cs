using System;

class MainClass {
  public static void Main (string[] args) {
    int hora;

    Console.WriteLine ("Quantas horas ?");
    hora= int.Parse (Console.ReadLine());

    if (hora < 12) {
      Console.WriteLine ("Bom dia !");
    }
    else{
      if (hora < 18){
        Console.WriteLine ("Boa tarde !");
      }
      else{
        Console.WriteLine ("Boa noite !");
      }
    }
    
  }
}