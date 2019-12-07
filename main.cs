using System;

class MainClass {
  public static void Main (string[] args) {
    char caractere = ' ';
    bool ehVogal = false;

    while (ehVogal == false){
      Console.WriteLine ("Entre com uma letra: ");
      caractere = char.Parse (Console.ReadLine());

      switch (char.ToUpper(caractere)) {
        case 'A':
        case 'E':
        case 'I':
        case 'O':
        case 'U':
          ehVogal = true;
          break;

        default:
          ehVogal = false;
          break;
      }
    }
    Console.WriteLine ("Achei uma vogal: " + caractere);
    Console.ReadKey();
  }
}
