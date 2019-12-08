using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

        // Instanciação de uma lista
        List <string> list = new List <string> ();
        
        // Adicionar elementos a uma lista
        list.Add ("Maria");
        list.Add ("Alex");
        list.Add ("Bob");
        list.Add ("Ana");

        // Insert serve para adicionar um valor em uma posição escolhida
        list.Insert(2, "Marco");

        // Mostrar na tela a lista
        foreach (string obj in list) {
                Console.WriteLine (obj);
        }

        // Tamanho da lista
        Console.WriteLine ("List count: " + list.Count);

        // Encontrar o primeiro ou último elementos da lista que satisfaça um predicado

        string s1 = list.Find (x => x[0] == 'A');
        Console.WriteLine ("First A: "  + s1);

        string s2 = list.FindLast (x => x [0] == 'A');
        Console.WriteLine ("Last A: " + s2);

        // Encontrar a primeira ou a última posição de elemento da lista 

        int pos1 = list.FindIndex (x => x[0] == 'A');
        Console.WriteLine ("First Position 'A': " + pos1);

        int pos2 = list.FindLastIndex (x => x[0] == 'A');
        Console.WriteLine ("Last Position 'A': " + pos2);

        //Filtrar a lista

        List <string> list2 = list.FindAll (x => x.Length == 5);
        Console.WriteLine ("------------------------");

        foreach (string obj in list2) {
                Console.WriteLine (obj); 
        }

        // Remover elementos da lista
        list.Remove ("Alex");
        Console.WriteLine ("------------------------");
        foreach (string obj in list) {
                Console.WriteLine (obj);
        }

        list.RemoveAll (x => x[0] == 'M');
        Console.WriteLine ("------------------------");
        foreach (string obj in list) {
                Console.WriteLine (obj);
        }




        }
}