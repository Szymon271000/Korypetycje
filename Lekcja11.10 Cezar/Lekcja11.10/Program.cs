using System;

namespace Lekcja11._10
{
    class Program
    {

        static string Cezar(string UserText,int k)
        {
            string Alfabet = "aąbcćdeęfghijklłmnńoóprsśtuwyzźż";
            k = k % Alfabet.Length;
            string NoweSlowo = string.Empty;
            for (int i = 0; i < UserText.Length; i++)
            {
                if (Alfabet.Contains(UserText[i]))
                {
                    int Index = Alfabet.IndexOf(UserText[i]);
                    int IndexSum = (Index + k) % Alfabet.Length;
                    char NowaLiterka = Alfabet[IndexSum];
                    NoweSlowo = NoweSlowo + NowaLiterka;
                }
                else
                {
                    NoweSlowo = NoweSlowo + UserText[i];
                }
            }
            return NoweSlowo;
        }

        static string ReverseCezar(string UserText, int k)
        {
            string Alfabet = "aąbcćdeęfghijklłmnńoóprsśtuwyzźż";
            k = k % Alfabet.Length;
            string NoweSlowo = string.Empty;
            for (int i = 0; i < UserText.Length; i++)
            {
                if (Alfabet.Contains(UserText[i]))
                {
                    int Index = Alfabet.IndexOf(UserText[i]);
                    int IndexDiff = (Alfabet.Length + Index - k) % Alfabet.Length;
                    char NowaLiterka = Alfabet[IndexDiff];
                    NoweSlowo = NoweSlowo + NowaLiterka;
                }
                else
                {
                    NoweSlowo = NoweSlowo + UserText[i];
                }
            }
            return NoweSlowo;
        }
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            int Index = int.Parse(Console.ReadLine());
            string Wynik = Cezar(Input, Index);
            Console.WriteLine($"Szyfrowany string: {Wynik}");
            string SecondWynik = ReverseCezar(Wynik, Index);
            Console.WriteLine($"Poczatkowy string: {SecondWynik}");
            
        }
    }
}
