using System;

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 5;
            int b = 0;

            if(b == 100 && (a == 8 || a == 5))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Błąd!");
            }

            //Console.WriteLine("Hello World!");*/

            int liczba = 1254;
            int sum = 0;
            while(liczba != 0)
            {
                int module = liczba % 10;
                int quotient = liczba / 10;
                sum = sum + module;
                liczba = quotient;
            }
            Console.WriteLine(sum);

            int[] numbers = new int[10];
            //indeksy sa od 0 do rozmiar tablicy - 1
            numbers[4] = 71;
            numbers[5] = 6;
            numbers[7] = 15;
            numbers[8] = 111;
            numbers[2] = 18;
            Console.WriteLine(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                Console.WriteLine(numbers[i * 2]);
            }

            //Console.Write("Podaj index: ");
            //int index = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Wartosc pod indeksem {index} : {numbers[index]}");
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i += 2 )
            {
                int one = 1;
                numbers[i] = one;
            }

            //numbers[0] = 1;
            //numbers[1] = 1;
            //numbers[2] = 1;
            //numbers[3] = 1;
            //numbers[4] = 1;
            //numbers[5] = 1;
            //numbers[6] = 1;
            //numbers[7] = 1;
            //numbers[8] = 1;
            //numbers[9] = 1;


        }
    }
}
