using System;
using System.Collections.Generic;

namespace FiltracjaImion
{
    class Program
    {
        static List<string> FiltracjaImion(List<string> StaraLista,string slowo)
        {
            List<string> NowaLista = new List<string>();
            for (int i = 0; i < StaraLista.Count; i++)
            {
                if (StaraLista[i] != slowo)
                {
                    NowaLista.Add(StaraLista[i]);
                }
            }
            return NowaLista;
        }
        static void Main(string[] args)
        {
            Console.Write("Lista: ");
            List<string> Imiona = new List<string>() { "Ada", "Ola", "Ada", "Kola", "Tola", "Ala", "Ada" };
            for (int i = 0; i < Imiona.Count; i++)
            {
                Console.Write(Imiona[i] + " ");
            }
            Console.WriteLine();
            string Wyraz = Console.ReadLine();

            List<string> NowaLista = FiltracjaImion(Imiona, Wyraz);

            for (int i = 0; i < NowaLista.Count; i++)
            {
                Console.Write(NowaLista[i] + " ");
            }
        }
    }
}
