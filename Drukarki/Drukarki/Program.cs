using System;

namespace Drukarki
{
    class Program
    {
        static void Main(string[] args)
        {
            Drukarka drukarka1 = new Drukarka("Epson", "Pohoto21312", 4);
            Skaner skaner1 = new Skaner("HP", "RCTY65", 1);
            try
            {               
               drukarka1.Drukuj();
            }
            catch (BrakTuszuException)
            {
                Console.WriteLine("Brak tuszu");
            }
        }
    }
}
