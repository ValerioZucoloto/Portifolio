using System;
using System.Globalization;
class MainClass {
  public static void Main (string[] args) {
    double n1, n2, soma;
    

    Console.WriteLine ("Informe as duas notas: ");
    n1 = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
    n2 = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

    soma = n1 + n2;
    Console.WriteLine ("Nota final = " + soma.ToString("F1",CultureInfo.InvariantCulture));

   
    if (n1+n2 < 60) {
      Console.WriteLine ("Reprovado !");
    }
    else{
      Console.WriteLine ("Aprovado !");
    }
     
    
    
  }
}