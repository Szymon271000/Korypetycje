using System;
using System.Collections.Generic;
namespace ListaZer
{
    class Program
    {
        static List<int> Zera (int Rozmiar)
        {
            List<int> ListaZer = new List<int>();
            for (int i = 0; i < Rozmiar; i++)
            {
                ListaZer.Add(0);
            }
            return ListaZer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar:");
            int Liczba = int.Parse(Console.ReadLine());
            List<int> NewLista = Zera(Liczba);
            Console.WriteLine("Wynik:");
            for (int i = 0; i < NewLista.Count; i++)
            {
                Console.Write(NewLista[i] + " ");
            }
        }
    }
}
