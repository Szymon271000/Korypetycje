using System;

namespace Auto_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SportowySamochod sportowy1 = new SportowySamochod();
            Komis komis1 = new Komis();
            komis1.MakeCar(sportowy1);
            Console.WriteLine(sportowy1.Samochod);

            RodzinnySamochod rodzinny1 = new RodzinnySamochod();
            komis1.MakeCar(rodzinny1);
            Console.WriteLine(rodzinny1.Samochod);

            SUV suv1 = new SUV();
            komis1.MakeCar(suv1);
            Console.WriteLine(suv1.Samochod);
        }
    }    
}
