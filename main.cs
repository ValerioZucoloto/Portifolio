using System;

class MainClass {
  public static void Main (string[] args) {

    Robo r1 = new Robo("r1", 25, 100, 100, "normal");
    Robo r2 = new Robo("r2", 30, 100, 100, "normal");

    Console.WriteLine(r1.RealizarAtaque(r2));
    // r1.RealizarAtaque(r2);
    // r1.RealizarAtaque(r2);
    // r1.RealizarAtaque(r2);
    // r1.RealizarAtaque(r2);
    // r1.RealizarAtaque(r2);
    // r1.RealizarAtaque(r2);
    // r1.RealizarAtaque(r2);
    // Console.WriteLine();

    // Robo r3 = new Robo("r3", 25, 100, 100, "indefeso");
    // Robo r4 = new Robo("r3", 25, 100, 100, "normal");

    // r3.RealizarAtaque(r4);
    r1.DoarForcaDefesa(r2, 30);




    
    

  }
}