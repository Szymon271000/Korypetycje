using System;

namespace Samogloska
{
    class Program
    {
        static bool Samogloska(char litera)
        {
            if ((litera == 'A') || (litera == 'E') || (litera == 'I') || (litera == 'O') || (litera == 'U') || (litera == 'a') || (litera == 'e') || (litera == 'i') || (litera == 'o') || (litera == 'u'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool result = Samogloska('t');
            Console.WriteLine(result);
        }
    }
}
