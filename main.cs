using System;

class MainClass {
  public static void Main (string[] args) {
    
    Navio x = new Navio (50, 100 , "CST", "JLG");

     Navio cst = new Navio (40, 150, "Arcelor", "GENIE");


    if (x.MaiorCapacidade(cst)){
      Console.WriteLine("O navio da " + x.Getnome() + " tem a maior capacidade com " + x.Getcarga_maxima ());
    }
    else {
      Console.WriteLine ("O navio da " + cst.Getnome() + "da fabricante JLG" + " tem a maior capacidade com " + cst.Getcarga_maxima ());
    }

    cst.Embarcar (10);

    Console.WriteLine ("Capacidade atual: " + cst.Getcarga_atual());

    
  }
}