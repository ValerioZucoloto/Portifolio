using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {

        Console.WriteLine ("Digite um texto: ");
        string texto = Console.ReadLine();  

        try {
                StreamWriter escritor = File.AppendText("Nome.txt");
                escritor.WriteLine (texto);
                Console.WriteLine ("Arquivo gerado !"); 
        }
        catch (IOException e) {
                Console.WriteLine ("Erro !");
                Console.WriteLine (e.Message);
        }

        StreamReader leitor = new StreamReader ("Nome.txt");
        string lido = leitor.ReadToEnd();

        Console.WriteLine(lido);

    
    } 
}
