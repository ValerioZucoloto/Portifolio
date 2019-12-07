using System;
using System.Collections.Generic;

class Cliente {
        public string Nome {get; set;}
        public string Cpf {get; set;}
        public int Idade {get; set;}
        public Plataforma Plat;
        public List <Plataforma> recursos;

        public Cliente (string nome, string cpf, int idade, Plataforma plataforma) {
                Nome = nome;
                Cpf = cpf;
                Idade = idade;
                Plat = plataforma;
        }

        public Cliente () {

        }

		public Cliente (string nome) {
			Nome = nome;
		}

        public void AddPlataforma(Plataforma plataforma) {
                recursos.Add (plataforma);
        }

        public void exibirPlataforma() {
                foreach (Plataforma obj in recursos){
                Console.WriteLine(obj.exibe());
                Console.WriteLine();
                }
        }

         public string exibe(){
                return "\nNome: " + Nome 
                + "\nCPF: " + Cpf
                + "\nIdade: " + Idade
                + "\nPlataforma: " + Plat.exibe();  
        }

}