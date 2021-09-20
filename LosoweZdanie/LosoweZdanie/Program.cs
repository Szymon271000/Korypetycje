using System;
using System.Collections.Generic;

namespace LosoweZdanie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MojaLista = new List<string>();
            string NewSentence = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj slowo: ");
                string slowo = Console.ReadLine();
                MojaLista.Add(slowo);
            }

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int slowo = rnd.Next(0, MojaLista.Count);
                NewSentence = NewSentence + MojaLista[slowo] + " ";
            }

            NewSentence = Char.ToUpper(NewSentence[0]) + NewSentence.Substring(1);
            Console.WriteLine(NewSentence);
        }
    }
}
