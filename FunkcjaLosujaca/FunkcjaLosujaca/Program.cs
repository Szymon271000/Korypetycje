using System;

namespace FunkcjaLosujaca
{
    class Program
    {
        static int FunkcjaLosujaca(int poczatek, int koniec)
        {
            Random rnd = new Random();
            int Numerpomiedzy = rnd.Next(poczatek, koniec);
            return Numerpomiedzy;
        }
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            string[] Elements = Input.Split();
            int[] Dane = new int[Elements.Length];
            for (int i = 0; i < Dane.Length; i++)
            {
                Dane[i] = int.Parse(Elements[i]);
            }
            int result = FunkcjaLosujaca(Dane[0], Dane[1]);
            Console.WriteLine(result);
        }
    }
}
