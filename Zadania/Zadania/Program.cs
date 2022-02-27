using System;

namespace Zadania
{
    public static class StringExtension
    {
        public static int WordCounter(this string str)
        {
            int counter = 0;
            string[] userText = str.Split(' ');
            foreach (var item in userText)
            {
                counter += item.Length;
            }
            return counter;
        }
    }

    class Program
    {
        static int Add(int a, int b)
        {
            while (a > 0)
            {
                b++;
                a--;
            }

            while (a < 0)
            {
                b--;
                a++;
            }

            return b;
        }

        static void Main(string[] args)
        {
            //string Text = Console.ReadLine();
            //int TotalWords = 0;
            //TotalWords = Text.WordCounter();
            //Console.WriteLine($"Total wrods: {TotalWords}");
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            var sum = Add(FirstNumber, SecondNumber);
            Console.WriteLine(sum);
        }
    }
}
