using System;

namespace TranslatorLiczbowy
{
    class Program
    {
        static string TranslatorLiczbowy(int Number)
        {
            string Slowa = string.Empty;
            string[] cyfry = { "zero", "jeden", "dwa", "trzy", "cztery", "pięc", "sześć", "siedem", "osiem", "dziewięć" };
            while (Number != 0)
            {
                int Cyfra = Number % 10;
                Slowa = cyfry[Cyfra] + " " + Slowa;
                Number = Number / 10;
            }
            return Slowa;
        }
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            string Result = TranslatorLiczbowy(Number);
            Console.WriteLine(Result);
        }
    }
}
