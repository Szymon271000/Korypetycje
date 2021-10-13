using System;

namespace KontoBankowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto(0.05f);
            k.SetDebet(500);
            k.SetPin("1234");
            Console.WriteLine("Podaj PIN: ");
            int odp = int.Parse(Console.ReadLine());
            if (k.SprawdzPin(odp))
            {
                k.PozazStan();
                k.Wyplac(300);
                k.PozazStan();
                k.Wyplac(500);
                k.PozazStan();
                k.Wplac(1000);
                k.PozazStan();
            }
            k.Kapitalizacja();
            k.PozazStan();
            k.SetPin("123");
            
        }
    }
}
