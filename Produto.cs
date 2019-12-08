using System;
using System.Collections.Generic;
using System.IO;

namespace Ifood {
    public class Produto {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        private static string ListaProdutos = "ListaProdutos.txt";

        public Produto(string nome, double valor, int quantidade) {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public Produto() { }

        public static void VerLista() {
            try {

                using(StreamReader sr = File.OpenText(ListaProdutos)) {

                    while(!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }

            }
            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }

        public string exibir() {
            return "\nNome: " + Nome
                + "\nValor: " + Valor
                + "Quantidade: " + Quantidade;
        }
    }
}
