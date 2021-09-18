using System;

namespace TranslatorLiczbowy
{
    class Program
    {
        static string TranslatorLiczbowy(int Number)
        {
            string Slowa = string.Empty;
            while (Number != 0)
            {
                int Cyfra = Number % 10;
                if (Cyfra == 0)
                {
                    Slowa =  "zero" + Slowa;
                }
                if (Cyfra == 1)
                {
                    Slowa =  "jeden " + Slowa;
                }
                if (Cyfra == 2)
                {
                    Slowa =  "dwa " + Slowa;
                }
                if (Cyfra == 3)
                {
                    Slowa =  "trzy " + Slowa;
                }
                if (Cyfra == 4)
                {
                    Slowa =  "cztery " + Slowa;
                }
                if (Cyfra == 5)
                {
                    Slowa = "piec " + Slowa;
                }
                if (Cyfra == 6)
                {
                    Slowa = "szesc " + Slowa;
                }
                if (Cyfra == 7)
                {
                    Slowa = "siedem " + Slowa;
                }
                if (Cyfra == 8)
                {
                    Slowa = "osiem " + Slowa;
                }
                if (Cyfra == 9)
                {
                    Slowa =  "dziewiec " + Slowa;
                }

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
