using System;
using System.Collections.Generic;
using System.IO;

namespace MaksymalneZarzadzanieSoba
{

    class Program
    {
        static void Dodawanie(PolaZadan p1)
        {
            Console.Write("Wpisz tresc zadania: ");
            string input = Console.ReadLine();
            Console.Write("Wpisz date: ");
            DateTime datazadanie = DateTime.Parse(Console.ReadLine());
            Console.Write("Wpisz status: ");
            string status = Console.ReadLine();
            Zadanie z1 = new Zadanie(input, datazadanie, status);
            p1.DodajZadanie(z1);
            Console.WriteLine(p1);
        }
        static void Main(string[] args)
        {
            var filename = @"C:\Users\huber\OneDrive\Desktop\tasks.txt";
            PolaZadan polaZadan = new PolaZadan();
            polaZadan.Wczytaj(filename);
            Dodawanie(polaZadan);
            string input = "0";
            while (input != "2")
            {
                Console.WriteLine("Co chcesz zrobic?: 1. Dodaj zadanie 2. Koniec");
                Console.WriteLine("Wpisz numerek:");
                input = Console.ReadLine();
                if(input == "1")
                {
                    Dodawanie(polaZadan);
                }
                else if (input == "2")
                {
                    polaZadan.Zapisz(filename);
                }
            }
            
            //uzytkownik powinien moc w nieskoczonosc dodawac zadania i sprawdzac liste zadan, dodatkowo powinna byc opcja wyjscia z programu
            //program na starcie laduje zadania z pliku i pod koniec zapisuje zadania do pliku (tego samego:
        }
    }
}
