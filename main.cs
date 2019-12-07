using System;

class MainClass {
  public static void Main (string[] args) {
    //Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem inversa.
        float y = 0;
        float[] x = new float [4];

        for (int i=0; i < x.Length; i++) {
                Console.WriteLine("Informe um número: ");
                x[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine();


        for(int i = 3; i >= 0; i--){
                Console.WriteLine(x[i]);
        }

  }
}