using System;

namespace Samogloski_w_tekscie
{
    class Program
    {
        static int IleSamoglowek(string tekst)
        {
            int counter = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                if ((tekst[i] == 'a') || (tekst[i] == 'A') || (tekst[i] == 'E') || (tekst[i] == 'e') || (tekst[i] == 'I') || (tekst[i] == 'i') || (tekst[i] == 'O') || (tekst[i] == 'o') || (tekst[i] == 'U') || (tekst[i] == 'u'))
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            string TekstFromUser = Console.ReadLine();
            int result = IleSamoglowek(TekstFromUser);
            Console.WriteLine(result);
        }
    }
}
