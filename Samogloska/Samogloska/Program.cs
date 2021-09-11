using System;

namespace Samogloska
{
    class Program
    {
        static bool Samogloska(char znak)
        {
            if ((znak == 'A') || (znak == 'a') || (znak == 'e') || (znak == 'E') || (znak == 'I') || (znak == 'i') || (znak == 'o') || (znak == 'O') || (znak == 'u') || (znak == 'U'))
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
