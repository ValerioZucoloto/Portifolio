using System;

class MainClass {
  public static void Main (string[] args) {
    int n1, n2, n3, pesoN1, pesoN2, pesoN3;
   float media;

   
   Console.WriteLine("Informe a primeira nota: ");
   n1 = int.Parse (Console.ReadLine());
   Console.WriteLine ("Informe o peso da N1: ");
   pesoN1 = int.Parse (Console.ReadLine());


   Console.WriteLine("Informe a segunda nota: ");
   n2 = int.Parse (Console.ReadLine());
   Console.WriteLine ("Informe o peso da N2: ");
   pesoN2 = int.Parse (Console.ReadLine());

   Console.WriteLine("Informe a terceira nota: ");
   n3 = int.Parse (Console.ReadLine());
   Console.WriteLine ("Informe o peso da N3: ");
   pesoN3 = int.Parse (Console.ReadLine());

   media = (n1*pesoN1 + n2*pesoN2 + n3*pesoN3);
   media /= 100;

   Console.WriteLine("A média ponderada das notas do aluno é: " + media.ToString("F2"));
   
  }
}