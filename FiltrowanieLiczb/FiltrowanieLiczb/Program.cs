using System;
using System.Collections.Generic;

namespace FiltrowanieLiczb
{

    class Program
    {
        static List<int> NowaLista(List<int> ListaStara, int Poczatek, int Koniec)
        {
            List<int> NewList = new List<int>();
            for (int i = 0; i < ListaStara.Count; i++)
            {
                if ((ListaStara[i] >= Poczatek) && (ListaStara[i] <= Koniec))
                {
                    NewList.Add(ListaStara[i]);
                }
            }
            return NewList;
        }

        static void Main(string[] args)
        {
            List<int> MojaLista = new List<int>() { 5, 9, 1, 4, 100, 1, 4, 5, 1, 5, 10, 5 };
            for (int i = 0; i < MojaLista.Count; i++)
            {
                Console.Write(MojaLista[i] + " ");
            }
            Console.WriteLine();
            string Input = Console.ReadLine();
            string[] Elements = Input.Split(" ");
            int[] Przedzialy = new int[Elements.Length];

            for (int i = 0; i < Przedzialy.Length; i++)
            {
                Przedzialy[i] = int.Parse(Elements[i]);
            }

            List<int> Result = NowaLista(MojaLista, Przedzialy[0], Przedzialy[1]);

            for (int i = 0; i < Result.Count; i++)
            {
                Console.Write(Result[i] + " ");
            }
        }
    }
}
