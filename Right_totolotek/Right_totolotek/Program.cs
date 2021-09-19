using System;

namespace Right_totolotek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_numbers = new int[6];
            Console.WriteLine("Podaj swoje typy: ");
            for (int i = 0; i < my_numbers.Length; )
            {
                int x = Convert.ToInt32(Console.In.ReadLine());
                bool znajdujeSie = false;
                for(int j = 0; j < i; j++)
                {
                    if(x == my_numbers[j])
                    {
                        znajdujeSie = true;
                        Console.WriteLine("Podales ta sama wartosc");
                        break;
                    }
                }
                if(znajdujeSie == false)
                {
                    my_numbers[i] = x;
                    i++;
                }
            }
            int[] computer_numbers = new int[6];
            Random rnd = new Random();
            Console.WriteLine("Wylosowano: ");
            for (int i = 0; i < computer_numbers.Length; i++)
            {
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
