using System;
using System.Collections.Generic;

namespace Drukarki
{
    class Program
    {
        static void Main(string[] args)
        {
            Drukarka drukarka1 = new Drukarka("Epson", "Pohoto21312", 4);
            Drukarka drukarka2 = new Drukarka("Epson", "XCTUT56", 0);
            Drukarka drukarka3 = new Drukarka("Epson", "2245FG", -2);

            Skaner skaner1 = new Skaner("HP", "RCTY65", 2);
            Skaner skaner2 = new Skaner("HP", "RTY678", 0);
            Skaner skaner3 = new Skaner("HP", "ASGB57", 2);

            UrzadzenieWielofunkcyjne u1 = new UrzadzenieWielofunkcyjne("Canon", "TY567", "Wifi", 0, 0);
            UrzadzenieWielofunkcyjne u2 = new UrzadzenieWielofunkcyjne("Canon", "TY567", "Wifi", 1, 5);
            UrzadzenieWielofunkcyjne u3 = new UrzadzenieWielofunkcyjne("Canon", "TY567", "Wifi", 0, 5);

            List<IDrukowanie> drukowanies = new List<IDrukowanie>();
            drukowanies.Add(drukarka1);
            drukowanies.Add(drukarka2);
            drukowanies.Add(drukarka3);
            drukowanies.Add(u1);
            drukowanies.Add(u2);

            List<ISkanowanie> skanowanies = new List<ISkanowanie>();
            skanowanies.Add(skaner1);
            skanowanies.Add(skaner2);
            skanowanies.Add(skaner3);
            skanowanies.Add(u3);

            

            try
            {
                for (int i = 0; i < drukowanies.Count; i++)
                {
                    drukowanies[i].Drukuj();
                }
            }
            catch (BrakTuszuException)
            {
                Console.WriteLine("Brak tuszu");
            }

            try
            {
                for (int i = 0; i < skanowanies.Count; i++)
                {
                    skanowanies[i].Skanuj();
                }
            }
            catch (SzybkoscUjemnaException)
            {
                Console.WriteLine("Szybkosc nie moze byc rowna 0 lub ujemna");
            }

        }
    }
}
