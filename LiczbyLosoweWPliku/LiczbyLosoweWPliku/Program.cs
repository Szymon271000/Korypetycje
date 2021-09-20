using System;
using System.Collections.Generic;
using System.IO;

namespace LiczbyLosoweWPliku
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

        static string Wyraz(List<int> ListIntow)
        {
            string Slowo = string.Empty;
            for (int i = 0; i < ListIntow.Count; i++)
            {
                Slowo += ListIntow[i] + " ";
            }
            return Slowo;
        }

        static void Main(string[] args)
        {
            string info = File.ReadAllText(@"C:\Users\huber\OneDrive\Desktop\LiczbyLosoweWplikuDane.txt");
            Console.WriteLine(info);
            string[] NumbersInfo = info.Split(" ");
            int[] Numbers = new int[NumbersInfo.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(NumbersInfo[i]);
            }

            List<int> Lista1 = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < Numbers[0]; i++)
            {
                int Number = rnd.Next(Numbers[1], Numbers[2]);
                Lista1.Add(Number);
            }


            Pokaz(Lista1);
            Console.WriteLine();



            string Lista1Intow = Wyraz(Lista1);

            File.WriteAllText(@"C:\Users\huber\OneDrive\Desktop\losowe.txt", Lista1Intow);
        }
    }
}
