using System;
using System.Collections.Generic;
using System.Globalization;


class MainClass {
        public static void Main (string[] args) {

                List <FuncionarioProprio> list = new List <FuncionarioProprio>();
                Console.Write ("Informe a quantidade de funcionários: ");
                int n = int.Parse (Console.ReadLine());

               
                for (int i = 1; i <= n; i++) {
                        Console.WriteLine ("Funcionário #" + i);
                        Console.WriteLine ("Terceiro ? [S/N]");
                        char ch = char.Parse (Console.ReadLine());
                        if (ch == 'S' || ch == 's') {
                                Console.Write ("Nome: ");
                                string nome = Console.ReadLine();
                                Console.Write ("Horas trabalhadas: ");
                                int horas = int.Parse (Console.ReadLine());
                                Console.Write ("Valor por hora: ");
                                double valorPorHora = double.Parse (Console.ReadLine());
                                Console.WriteLine ("Despesa Adicional: ");
                                double despesa = double.Parse (Console.ReadLine());
                                list.Add (new FuncionarioTerceiro (nome, horas, valorPorHora, despesa));
                                Console.WriteLine();
                        }
                        else if (ch == 'N' || ch == 'n') {
                                Console.Write ("Nome: ");
                                string nome = Console.ReadLine();
                                Console.Write ("Horas trabalhadas: ");
                                int horas = int.Parse (Console.ReadLine());
                                Console.Write ("Valor por hora: ");
                                double valorPorHora = double.Parse (Console.ReadLine());
                                list.Add (new FuncionarioProprio (nome, horas, valorPorHora));
                                Console.WriteLine();
                        }        
                }

                Console.WriteLine();

                Console.Write ("Pagamentos: ");
                foreach (FuncionarioProprio func in list) {
                        Console.WriteLine (func.Nome + " - $ " + func.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
                }
        }

}