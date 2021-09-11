using System;

namespace SamogloskiISpacje
{
    class Program
    {
        static int Spacje(string tekst)
        {
            int counterSp = 0;
            
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == ' ')
                {
                    counterSp++;
                }
            }
            return counterSp;
        }

        static int Samogloski(string tekst)
        {
            int counterSa = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                if ((tekst[i] == 'A') || (tekst[i] == 'a') || (tekst[i] == 'E') || (tekst[i] == 'e') || (tekst[i] == 'I') || (tekst[i] == 'i') || (tekst[i] == 'O') || (tekst[i] == 'o') || (tekst[i] == 'U') || (tekst[i] == 'u'))
                {
                    counterSa++;
                }
            }
            return counterSa;
        }
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            int resultsa = Samogloski(Input);
            Console.WriteLine($"Samogloski: {resultsa}");
            int resultsp = Spacje(Input);
            Console.WriteLine($"Spacje: {resultsp}");
        }
    }
}
