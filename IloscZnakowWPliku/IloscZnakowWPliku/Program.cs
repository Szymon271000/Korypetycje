using System;
using System.IO;
namespace IloscZnakowWPliku
{
    class Program
    {
        static int IloscZnakow (string tekst)
        {
            int number = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                number++;
            }
            return number;
        }
        static void Main(string[] args)
        {
            
            string info = File.ReadAllText(@"C:\Users\huber\OneDrive\Desktop\dane.txt");
            int ilosc = IloscZnakow(info);
            Console.WriteLine($"Wynik : {ilosc}");
        }
    }
}
