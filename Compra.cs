using System;
using System.IO;
using System.Collections.Generic;

namespace Ifood {
    public class Compra {

        private static string vendas = "vendas.txt";

        public double Total { get; set; }
        public List<Produto> Produtos = new List<Produto>();
        public Cliente ClienteObj = new Cliente();


        public Compra(List<Produto> produtos, Cliente cliente) {
            Produtos = produtos;
            ClienteObj = cliente;
        }

        public double GetTotal() {

            foreach(Produto produto in Produtos) {
                Total += produto.Valor;
            }

            return Total;

        }

        public static void SalvarVenda(Compra compra) {

            try {
            
                using(StreamWriter sw = File.AppendText(vendas)) {

                    foreach(Produto obj in compra.Produtos) {
                        sw.WriteLine("Cliente: " + compra.ClienteObj.Nome);
                        sw.WriteLine("Produto: " + obj.Nome);
                        sw.WriteLine("Preço: " + obj.Valor.ToString("F2"));
                        sw.WriteLine();
                    }

                }

            }catch(IOException e) {
                Console.WriteLine(e.Message);
            }

        }

        public Compra() { }

    }
}