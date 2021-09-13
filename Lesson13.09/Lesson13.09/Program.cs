using System;

namespace Lesson13._09
{
    class Program
    {
        static bool Samogloska(char znak)
        {
            return "aAoOeEiIyYuU".Contains(znak);
            //if ((znak == 'A') || (znak == 'a') || (znak == 'e') || (znak == 'E') || (znak == 'I') || (znak == 'i') || (znak == 'o') || (znak == 'O') || (znak == 'u') || (znak == 'U'))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        static bool Palindrom(string text)
        {
            for(int i = 0; i < text.Length / 2; i++)
            {
                if(text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static int FunkcjaLosujaca(int poczatek, int koniec)
        {
            Random rnd = new Random();
            int Numerpomiedzy = rnd.Next(poczatek, koniec);
            return Numerpomiedzy;
        }

        static int[] WczytajLiczby()
        {
            string Input = Console.ReadLine();
            string[] Elements = Input.Split();
            int[] Dane = new int[Elements.Length];
            for (int i = 0; i < Dane.Length; i++)
            {
                Dane[i] = int.Parse(Elements[i]);
            }
            return Dane;
        }
        static void Main(string[] args)
        {
            int[] Dane = WczytajLiczby();
            int result = FunkcjaLosujaca(Dane[0], Dane[1]);
            Console.WriteLine(result);
        }

    }
}
