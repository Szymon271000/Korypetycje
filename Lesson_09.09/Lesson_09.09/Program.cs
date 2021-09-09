using System;

namespace Lesson_09._09
{
    class Program
    {
        //definicja funkcji = naglowek + cialo
        //ta funkcja nie ma argumentow i nie zwraca wyniku
        static void Hello() //To jest naglowek funkcji
        { //to jest cialo funkcji
            Console.WriteLine("Hello world");

        } //tu sie konczy cialo funkcji

        //funkcja ktora nie zwraca wyniku ale ma dwa argumenty
        //void - funkcja nie daje zadanego wyniku
        static void Pokaz(string napis, int ile) //w nawiasie mamy argumenty funkcji
        {
            for (int i = 0; i < ile; i++)
            {
                Console.Write(napis);
            }
            Console.WriteLine();
        }

        //funkcja ktora przyjmuje jeden argument i daje wynik typu liczbowego
        static int Modul(int liczba)
        {
            if (liczba < 0)
            {
                return -liczba; //zakoncz dzialanie funkcji i oddaj wynik ktory jest zapisany po slowie return
            }
            else
            {
                return liczba; //zakoncz dzialanie funkcji i oddaj wynik ktory jest zapisany po slowie return
            }
        }

        static void suma(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            Hello(); //to jest wywolanie (uruchomienie) funkcji 
            Hello(); //to jest wywolanie (uruchomienie) funkcji 
            Hello(); //to jest wywolanie (uruchomienie) funkcji 
            //Math.Sqrt(9)

            Pokaz("la", 10);
            Pokaz("*", 20);
            Pokaz("(╯°□°）╯︵ ┻━┻", 3);

            suma(5, 20);

            int wynik = Modul(-5);
            Console.WriteLine(wynik);

            Console.WriteLine(Modul(-100));

            int x = Modul(8) * Modul(-2);
            Console.WriteLine(x);
            bool result = ParzystaCzyNie(20);
            Console.WriteLine(result);

            //Napisz funkcje ktora jako argument przyjmuje liczbe calkowita i zwraca true jesli ta liczba jest parzysta lub false jesli ta liczba jest nieparzysta
            int b = int.Parse(Console.ReadLine());
            result = ParzystaCzyNie(b);
            if (result)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nieparzysta");
            }

            int[] nums = new int[] { 5, 10, 20 }; //stworzy tablice o rozmiarze 3 z elementami 5 10 20
            Tablica(nums);

            Tablica(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            //napisz funkcje ktora jako argument przyjmuje tablice liczb i wyswietla te liczby na ekran, funkcja nic nie zwraca
            int[] wynikFunkcji = Jedynki(20);
            Tablica(wynikFunkcji);

            
            int result2 = IleA("appleaaaaa");
            Console.WriteLine(result2);
            //napisz funkcje ktora jako argument przyjmuje napis (string) i zwraca ilosc literek 'a' w tym napisie
        }
        static int IleA( string slowo)
        {
            int counter = 0;
            for (int i = 0; i < slowo.Length; i++)
            {
                if (slowo[i] == 'a')
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Tablica(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
        //funkcja ktora jako argument przyjmuje liczbe i zwraca nowa tablice jedynek o rozmiarze takim jak argument
        static int[] Jedynki(int rozmiar)
        {
            int[] nowaTablica = new int[rozmiar];
            for (int i = 0; i < nowaTablica.Length; i++)
            {
                nowaTablica[i] = 1;
            }
            return nowaTablica;
        }
        static bool ParzystaCzyNie(int a)
        {
            if(a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
