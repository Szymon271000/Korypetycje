using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = "Wybierz operacje: 0. Wyjscie. 1. Dodawanie 2.Odejmowanie 3. Mnozenie 4. Dzielenie";
            Console.WriteLine(entry);
            string option = Console.ReadLine();
            while (option != "0")
            {
                if (option == "1")
                {
                    Console.Write("Podaj liczbe: ");
                    int first_number = int.Parse(Console.ReadLine());
                    Console.Write("Podaj liczbe: ");
                    int second_number = int.Parse(Console.ReadLine());
                    int sum = first_number + second_number;
                    Console.WriteLine($"Wynik: {sum}");
                }
                else if (option == "2")
                {
                    Console.Write("Podaj liczbe: ");
                    int first_number = int.Parse(Console.ReadLine());
                    Console.Write("Podaj liczbe: ");
                    int second_number = int.Parse(Console.ReadLine());
                    int difference = first_number - second_number;
                    Console.WriteLine($"Wynik: {difference}");
                }
                else if (option == "3")
                {
                    Console.Write("Podaj liczbe: ");
                    int first_number = int.Parse(Console.ReadLine());
                    Console.Write("Podaj liczbe: ");
                    int second_number = int.Parse(Console.ReadLine());
                    int product = first_number * second_number;
                    Console.WriteLine($"Wynik: {product}");
                }
                else if(option == "4")
                {
                    Console.Write("Podaj liczbe: ");
                    int first_number = int.Parse(Console.ReadLine());
                    Console.Write("Podaj liczbe: ");
                    int second_number = int.Parse(Console.ReadLine());
                    int quotient = first_number / second_number;
                    Console.WriteLine($"Wynik: {quotient}");
                }
                Console.WriteLine(entry);
                option = Console.ReadLine();
            }
            Console.WriteLine("Wyjscie! Koniec programu");
        }
    }
}
