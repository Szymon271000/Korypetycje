using System;

namespace Lekcja21._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //wyjatek = blad

            try //miejsce gdzie wkladamy kod ktory generuje wyjatki, jesli zostanie wykryty wyjatek to try jest przerywany i przechodzi do catch
            {
                int liczba = int.Parse(Console.ReadLine());
                Console.WriteLine("Moja liczba to: " + liczba);
                Console.WriteLine("Wynik=" + (10 / liczba));
            }
            catch(FormatException ex) //tutaj zostanie przechwycony konkretny wyjatek
            {
                //Console.WriteLine(ex);
                Console.WriteLine("Podana wartość nie jest liczba");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Podales wartosc 0, blad!");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Podales zbyt duza liczbe");
            }


            Console.WriteLine("Podaj imie");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj telefon");
            string telefon = Console.ReadLine();

            try
            {
                Klient k = new Klient(imie, nazwisko, telefon);
            }
            catch(TelFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Koniec programu!");


        }
    }
}
