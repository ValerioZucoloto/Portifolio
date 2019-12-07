using System;

class MainClass {
  public static void Main (string[] args) {

          double[] salto;

          double media = 0.0;

          string[] posicao = new string[]{"Primeiro Salto: ", "Segundo Salto: ", "Terceiro salto: ", "Quarto salto: ", "Quinto salto: "};
          
          Console.WriteLine ("Informe a quantidade de saltos: ");
          int N;
          N = int.Parse (Console.ReadLine());
          salto = new double[N];      
          Console.WriteLine ("Informe o nome do atleta: ");
          string nome = Console.ReadLine();         

          

          if (nome != "") {
                Console.WriteLine ("Informe as ditâncias dos saltos: ");
               
                

                for (int i=0; i < N; i++) {
                        
                        salto[i] = double.Parse (Console.ReadLine());
                }
                        
                        Console.WriteLine ("Atleta: " + nome);

                        for (int j=0; j < N; j++) {
                            Console.WriteLine (posicao[j] + salto[j]);
                        }
                        
          } 

          else  {
                  Console.WriteLine ("Programa encerrado!");
          } 

          Console.WriteLine ("Resultado final: ");
          Console.WriteLine ("Atleta: " + nome);
          
          for (int i=0; i < N; i++) {
                  if (salto[i] != N) {
                          Console.Write (salto[i] + " - ");
                  }else{
                        Console.Write (salto[i]);
                        
                  }
          }

          Console.WriteLine();



          double soma =0;

          for (int i=0; i < N; i++) {
              soma = soma + salto[i];    
          }

          media = soma / N;

          Console.WriteLine ("Média = " + media.ToString("F2"));      
                       
  }
}