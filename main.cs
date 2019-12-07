using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    //http://codepad.org/VwIDTKG8
    //tiny.cc/miniprojaed

        List <Plataforma> plataforma = new List <Plataforma>();
        Cliente Valerio = new Cliente ("Valério");
	Plataforma plat1 = new Plataforma ("450AJ", Valerio);
	Plataforma plat2 = new Plataforma ("600AJ", Valerio);
	Plataforma plat3 = new Plataforma ("800AJ", Valerio);
	Plataforma plat4 = new Plataforma ("1250AJP", Valerio);

	plataforma.Add (plat1);
	plataforma.Add (plat2);
	plataforma.Add (plat3);
	plataforma.Add (plat4);

	Console.WriteLine ("Escolha a plataforma: ");
		for(int i = 0; i < plataforma.Count; i++){
			Console.WriteLine("Digite " + i + " para escolher: " + plataforma[i].Modelo);
		}

	Console.WriteLine();

	Console.Write ("Escolha uma das opções acima: ");
	int escolha = int.Parse(Console.ReadLine());

	if(escolha < 0 || escolha > 3){
		Console.WriteLine("Opção Inválida!");
		        }else{
			if(escolha == 0){
			        Console.WriteLine ("Cliente: " + plat1.ClienteObj.Nome);
			        Console.WriteLine ("Plataforma escolhida: 450AJ !");
		        }else if(escolha == 1){
			        Console.WriteLine ("Plataforma escolhida: 600AJ !");
		        }else if(escolha == 2){
			        Console.WriteLine ("Plataforma escolhida: 800AJ !");
		        }else if(escolha == 5){
			        Console.WriteLine ("Plataforma escolhida: 1250AJP !");
			}
		}
    
  }
}