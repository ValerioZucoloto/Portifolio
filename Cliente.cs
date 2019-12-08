using System;
namespace Ifood
{
    public class Cliente
    {
      
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente() { }

        public string exibir()
        {
            return "Cliente: " + Nome;
        }

    }
}
