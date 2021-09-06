using System;

namespace Right_totolotek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_numbers = new int[6];
            Console.WriteLine("Podaj swoje typy: ");
            for (int i = 0; i < my_numbers.Length; i++)
            {
                my_numbers[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            int[] computer_numbers = new int[6];
            Console.WriteLine("Wylosowano: ");
            for (int i = 0; i < computer_numbers.Length; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 43);
                computer_numbers[i] = number;
            }
            for (int i = 0; i < computer_numbers.Length; i++)
            {
                Console.Write(computer_numbers[i] + " ");
            }
            Console.WriteLine();
            int counter = 0;
            for (int i = 0; i < my_numbers.Length; i++)
            {
                for (int j = 0; j < computer_numbers.Length; j++)
                {
                    if (my_numbers[i] == computer_numbers[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Trafiles nastepujaca ilosc numerkow: {counter}");
            
        }
    }
}
