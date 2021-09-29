using System;

namespace Koszyk
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefony T1 = new Telefony(model: "13", producent: "Apple", cena: 1499.99f);
            Telefony T2 = new Telefony(model: "12", producent: "Apple", cena: 1299.99f);
            Telefony T3 = new Telefony(model: "11", producent: "Apple", cena: 1099.99f);
            Telefony T4 = new Telefony(model: "X", producent: "Apple", cena: 999.99f);
            Telefony T5 = new Telefony(model: "8", producent: "Apple", cena: 749.99f);

            Koszyk Koszyk1 = new Koszyk();
            Koszyk1.Telefonies.Add(T1);
            Koszyk1.Telefonies.Add(T2);
            Koszyk1.Telefonies.Add(T3);
            Koszyk1.Telefonies.Add(T4);
            Koszyk1.Telefonies.Add(T5);
            Console.WriteLine(Koszyk1);

            float Suma = Koszyk1.Suma();
            Console.WriteLine(Suma);
            
        }
    }
}
