using System;
using System.Linq;
using System.Collections.Generic;


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

        public static int LetterCounter (this string word, char letter)
        {
             
            int counter = word.Count(x => x == letter);
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //    {
            //        counter++;
            //    }
            //}
            return counter;
        }
    }



    class Program
    {
        static PunktS punktSSSSS;
        static DateTime date; //domyslnie powstanie jakis obiekt
        static string text; //domyslnie null

        public class Punkt
        {
            private int x;
            private int y;

            public Punkt(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }

            public override string ToString()
            {
                return "Punkt ma wspolrzedne" + x + " " + y; 
            }
        }

        public struct PunktS : IComparable<PunktS>
        {
            private int x;
            private int y;

            public PunktS(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }

            public int CompareTo(PunktS other)
            {
                return Math.Sqrt(x * x + y * y).CompareTo(Math.Sqrt(other.x * other.x + other.y * other.y));
            }

            public override string ToString()
            {
                return "Punkt ma wspolrzedne" + x + " " + y;
            }

        }
        static int Add(int a, int b)
        {
            int[] sum = new int[]
            {
                a, b
            };
            int sum1 = sum.Sum();
            return sum1;
            //while (a > 0)
            //{
            //    b++;
            //    a--;
            //}

            //while (a < 0)
            //{
            //    b--;
            //    a++;
            //}

            //return b;
        }

        static void Main(string[] args)
        {
            //string Text = Console.ReadLine();
            //int TotalWords = 0;
            //TotalWords = Text.WordCounter();
            //Console.WriteLine($"Total wrods: {TotalWords}");


            //int FirstNumber = int.Parse(Console.ReadLine());
            //int SecondNumber = int.Parse(Console.ReadLine());
            //var sum = Add(FirstNumber, SecondNumber);
            //Console.WriteLine(sum);

            List<int> numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 1, 1, 1, 1, 1, 4, 4, 4, 5, 5, 5, 5, 6, 6, 7, 6
            };

            var pairednumbers = numbers.GroupBy(x => x % 2 == 0).ToDictionary(x => x.Key ? "parzyste" : "nieparzyste", y => y.ToList().Count);

            foreach (var n in pairednumbers)
            {
                Console.WriteLine(n);
            }

            var grouped = numbers.GroupBy(x => x).OrderByDescending(x => x.ToList().Count).Take(3).Select(x => x.Key).ToList();

            foreach (var g in grouped)
            {
                Console.WriteLine(g);
            }

            List<string> imiona = new List<string>
            {
                "ala", "ola", "aleksandra", "martyna", "ania", "monika", "ada", "alicja"
            };

            //var grupy = imiona.GroupBy(x => x.Length);

            var grupy = imiona.GroupBy(x => x[0]);
            foreach(var grupa in grupy)
            {
                Console.WriteLine("Klucz : " + grupa.Key + " ilosc: " + grupa.ToList().Count);
                foreach(var item in grupa)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("ala ma kota".LetterCounter('a'));

            string zdanie = "Dzisiaj jest fajna pogoda";
            var group = zdanie.GroupBy(x => Char.ToLower(x)).ToDictionary(x => x.Key, y => y.ToList().Count);

            foreach (var literka in group)
            {
                Console.WriteLine(literka);
            }

            Console.WriteLine("date: " + date);
            Console.WriteLine("text: " + text);

            Punkt p = new Punkt(5, 6);
            Punkt p2 = p; //w klasach kopiowane jest jedynie odniesienie
            p2.X = 100;
            Console.WriteLine(p);
            Console.WriteLine(p2);

            PunktS s = new PunktS(1, 2);
            PunktS s2 = s; //w strukturach obiekt zawsze jest kopiowany
            s2.X = 100;
            Console.WriteLine(s);
            Console.WriteLine(s2);

            Punkt p3; //sznurek bez balonika
            PunktS s3; //sznurek z balonikiem, struktura nigdy nie jest null, trzeba przed uzyciem jej cos przypisac

            Console.WriteLine(punktSSSSS);

            DateTime? dt = null;
            int? value = null;
            value = 5;
            value = null;

        }
    }
}
