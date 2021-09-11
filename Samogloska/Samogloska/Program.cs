using System;

namespace Samogloska
{
    class Program
    {
        static bool Samogloska(string znak)
        {
            if ((znak == "A") || (znak == "a") || (znak == "E") || (znak == "e") || (znak == "I") || (znak == "i") || (znak == "O") || (znak == "o") || (znak == "U") || (znak == "u"))
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
            string slowo = Console.ReadLine();
            bool result = Samogloska(slowo);
            Console.WriteLine(result);
        }
    }
}
