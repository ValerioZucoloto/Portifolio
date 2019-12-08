using System;
using System.IO;
using System.Collections.Generic;

namespace Ifood {
    class MainClass {
        public static void Main(string[] args) {

            //Exibe todos os produtos cadastrados
            Produto.VerLista();

            //Local onde é salvo as vendas
            string vendas = "vendas.txt";

            Console.WriteLine();

            List<Produto> produtos = new List<Produto>();
            Compra compra;

            //Inicialização do Objeto Cliente
            Cliente cliente = new Cliente("Valério");

            //Inicialização do Objeto produto
            Produto produto1 = new Produto("REFRIGERANTE 100ML", 9.90, 10);
            Produto produto2 = new Produto("Leite 300ML", 5.80, 5);

            //Adiciona produtos na lista
            produtos.Add(produto1);
            produtos.Add(produto2);

            //instanciação do objeto da compra
            compra = new Compra(produtos, cliente);

            //Salva a venda no arquivo
            Compra.SalvarVenda(compra);


            Console.WriteLine(cliente.exibir());
            Console.WriteLine(compra.GetTotal().ToString("F2"));

            Console.ReadKey();

        }
    }
}
