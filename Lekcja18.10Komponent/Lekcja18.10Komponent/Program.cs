using System;

namespace Lekcja18._10Komponent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stworz plecak nr 1 i dodaj tam tarcze i miecz
            //Stworz plecak nr 2 i dodaj tam dwie tarcze
            //Stworz plecak nr 3 i dodaj tam plecak nr 1 i nr 2
            //Policz ile wazy plecak nr 3
            Backpack backpack1 = new Backpack();
            Sword sword1 = new Sword(20);
            Shield shield1 = new Shield();
            backpack1.Add(sword1);
            backpack1.Add(shield1);

            Backpack backpack2 = new Backpack();
            Shield shield2 = new Shield();
            Shield shield3 = new Shield();
            backpack2.Add(shield2);
            backpack2.Add(shield3);

            Backpack backpack3 = new Backpack();
            backpack3.Add(backpack1);
            backpack3.Add(backpack2);

            int SumaWag = backpack3.Waga();
            Console.WriteLine(SumaWag);

            Console.WriteLine("Cudzyslow: \" \\");

        }
    }
}
