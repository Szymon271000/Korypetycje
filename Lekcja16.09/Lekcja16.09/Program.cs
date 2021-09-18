using System;
using System.Collections.Generic;

namespace Lekcja16._09
{
    class Program
    {
        static void Pokaz<T>(List<T> lista) //tak mozna przekazac liste do funkcji
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine();
        }

        //Napisz funkcje ktora jako argument przyjmuje liczbe calkowita (rozmiar) i zwraca liste wypelniona losowymi liczbami o ilosci takiej ten rozmiar
        
        static List<int> Losowanie (int Rozmiar)
        {
            List<int> Liczby = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < Rozmiar; i++)
            {
                int Liczba = rnd.Next(0, 100);
                Liczby.Add(Liczba); 
            }
            return Liczby;
        }

        static List<int> LiczbyParzyste(List<int> ListaStara)
        {
            List<int> Parzyste = new List<int>();
            for (int i = 0; i < ListaStara.Count; i++)
            {
                if (ListaStara[i] % 2 ==0)
                {
                    Parzyste.Add(ListaStara[i]);
                }
            }
            return Parzyste;
        }
        //napisz funkcje ktora jako argument przyjmuje liste liczb i zwraca nowa liste ale liczb parzystych

        static void Main(string[] args)
        {
            //czym sie rozni lista od tablicy?
            //tablica na starcie ma zdefiniowana stała długość
            //lista na starcie ma długość zero i rozszerza się z każdym elementem

            //Tworzenie listy:
            //List<nazw typu danych> nazwa_zmiennej = new List<nazwa typu danych>();
            List<int> liczby = new List<int>();

            Console.WriteLine($"Rozmiar listy przed dodaniem elementow wynosi: {liczby.Count}");

            //dodawanie elementu do listy
            liczby.Add(10); //dodaj wartosc 10 do listy
            liczby.Add(100);
            liczby.Add(200);
            liczby.Add(1000);
       
            //jak sprawdzic rozmiar listy?
            Console.WriteLine($"Rozmiar listy po dodaniu elementow wynosi: {liczby.Count}");
            liczby.Add(1);
            Console.WriteLine($"Rozmiar listy po dodaniu elementu wynosi: {liczby.Count}");

            //jak dostac sie do elementow listy
            Console.WriteLine(liczby[0]);
            Console.WriteLine(liczby[1]);
            Console.WriteLine(liczby[2]);
            //Console.WriteLine(liczby[5]); //System.ArgumentOutOfRangeException - nie ma takiego elementu

            liczby[0] = -1; //edycja aktualnej wartosci w liscie

            //usuwanie elementu
            liczby.RemoveAt(1); //usuwa element pod indeksem nr 1

            Console.WriteLine();
            //uzywanie w petli tak samo jak w tablicach
            for (int i = 0; i < liczby.Count; i++)
            {
                Console.WriteLine(liczby[i]);
            }

            var wyrazy = new List<string>() { "ala", "ma", "kota" }; //tworzy sie lista ktora na starcie ma 3 elementy
            Pokaz(wyrazy);

            var Liczby = Losowanie(6);
            Pokaz(Liczby);
            Liczby = LiczbyParzyste(Liczby);
            Pokaz(Liczby);
            
        }
    }
}
