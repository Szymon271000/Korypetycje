using System;

namespace Kamien__papier_i_nozyce
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] options;
                options = new string[] { "Rock", "Paper", "Scissors" };
                for (int i = 0; i < options.Length; i++)
                {
                    Console.Write($"{i} {options[i]} ");
                }
                Console.WriteLine();
                int user_option = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int index = rnd.Next(options.Length);
                Console.WriteLine($"Komputer wybral: {options[index]}");
                if (user_option == 0 && index == 0 || user_option == 1 && index == 1 || user_option == 2 && index == 2)
                {
                    Console.WriteLine("Tie");
                }
                else if (user_option == 0 && index == 2 || user_option == 1 && index == 0 || user_option == 2 && index == 1)
                {
                    Console.WriteLine("Won");
                }
                else
                {
                    Console.WriteLine("Lost");
                    Console.WriteLine("End of programm");
                    break;
                }
            }    
        }
    }
}
