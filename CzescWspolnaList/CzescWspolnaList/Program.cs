using System;
using System.Collections.Generic;

namespace CzescWspolnaList
{
    class Program
    {
        static void Pokaz (List<int> ListaDoPokazania)
        {
            for (int i = 0; i < ListaDoPokazania.Count; i++)
            {
                Console.Write(ListaDoPokazania[i] + " ");
            }
        }
        static List<int> CzescWspolnaList (List<int> List1, List<int> List2)
        {
            List<int> WspolnaLista = new List<int>();
            for (int i = 0; i < List1.Count; i++)
            {

                for (int j = 0; j < List2.Count; j++)
                {
                    if (List1[i] == List2[j] && !WspolnaLista.Contains(List1[i]))
                    {
                        WspolnaLista.Add(List1[i]);
                    }
                }
            }
            return WspolnaLista;
        }
        static void Main(string[] args)
        {
            List<int> Lista1 = new List<int> { 5, 6, 1, 5, 100 };
            List<int> Lista2 = new List<int> { 9, 10, 5, 4, 1, 6, 8 };
            List<int> Result = CzescWspolnaList(Lista1, Lista2);
            Pokaz(Result);
        }
    }
}
