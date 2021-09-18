using System;
using System.Collections.Generic;

namespace PorownajListy
{
    class Program
    {
        //Funkcja jako argument przyjmuje dwie listy i sprawdza czy sa takie same pod katem posiadanych elementow:
        //np {1, 4, 5 } i {1, 4, 5 } sa takie same
        //ale {3, 1, 7} i {1, 7, 3} to juz rozne listy
        public static bool PorownajListy(List<int> listaA, List<int> listaB)
        {
            for (int i = 0; i < listaA.Count; i++)
            {
                if (listaA[i] == listaB[i])
                {
                    return true;
                }        
            }
            return false;
        }
        static void Main(string[] args)
        {
            List<int> Liczby = new List<int>() { 3, 1, 7 };
            List<int> Liczby2 = new List<int>() { 1, 7, 3 };
            bool result = PorownajListy(Liczby, Liczby2);
            Console.WriteLine(result);
        }
    }
}
