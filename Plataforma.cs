using System;
using System.Collections.Generic;

class Plataforma {
        public string Fabricante {get; set;}
        public double Alcance {get; set;}
        public string Modelo {get; set;}
        public double Capacidade {get; set;}
		public Cliente ClienteObj {get; set;}
        public List <Cliente> list;

        public Plataforma (string fabricante, double alcance, string modelo, double capacidade) {
                Fabricante = fabricante;
                Alcance = alcance;
                Modelo = modelo;
                Capacidade = capacidade;
                list = new List <Cliente>();
        }

		public Plataforma (string modelo, Cliente cliente) {
            Modelo = modelo;
			ClienteObj = cliente;
        }

        public Plataforma() {
                
        }

        // Reservar a plataforma para o serviço
        public void reservarPlataforma (string model) {
                Modelo = model;
        }

        public void addCliente(Cliente cliente) {
                list.Add (cliente);
        }
        
        

        public void exibirCliente() {
			foreach (Cliente obj in list){
				Console.WriteLine(obj.exibe());
				Console.WriteLine();
			}
        }

        public string exibe()  {
                return "\nFabricante: " + Fabricante 
                + "\nAlcance: " + Alcance
                + "\nModelo: " + Modelo
                + "\nCapacidade: " + Capacidade;
        }



}