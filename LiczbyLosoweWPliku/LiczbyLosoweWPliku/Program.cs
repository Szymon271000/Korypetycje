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
            List<int> Lista2 = new List<int>(); 
            List<int> Lista3 = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < Numbers[0]; i++)
            {
                int Number = rnd.Next(0, Numbers[0]);
                Lista1.Add(Number);
            }

            for (int i = 0; i < Numbers[1]; i++)
            {
                int Number = rnd.Next(0, Numbers[1]);
                Lista2.Add(Number);
            }

            for (int i = 0; i < Numbers[2]; i++)
            {
                int Number = rnd.Next(0, Numbers[2]);
                Lista3.Add(Number);
            }

            Pokaz(Lista1);
            Console.WriteLine();
            Pokaz(Lista2);
            Console.WriteLine();
            Pokaz(Lista3);
            Console.WriteLine();


            File.WriteAllText(@"C:\Users\huber\OneDrive\Desktop\losowe.txt", Lista1);
            File.WriteAllText(@"C:\Users\huber\OneDrive\Desktop\losowe.txt", Lista2);
            File.WriteAllText(@"C:\Users\huber\OneDrive\Desktop\losowe.txt", Lista3);

        }
    }
}
