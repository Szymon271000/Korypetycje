using System;

namespace Samogloska
{
    class Program
    {
        static bool Samogloska(string litera)
        {
            if ((litera == "A") || (litera == "E") || (litera == "I") || (litera == "O") || (litera == "U") || (litera == "a") || (litera == "e") || (litera == "i") || (litera == "o") || (litera == "u"))
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
            string litera = Console.ReadLine();
            bool result = Samogloska(litera);
            Console.WriteLine(result);
        }
    }
}
