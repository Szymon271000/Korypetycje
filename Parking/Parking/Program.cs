
using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod("BMW", "X1", DateTime.Parse("05/11/2020"));
            Samochod s2 = new Samochod("Mercedes", "A-120", DateTime.Parse("06/10/2011"));
            Samochod s3 = new Samochod("Audi", "A4", DateTime.Parse("06/11/2018"));
            Samochod s4 = new Samochod("Peugeout", "370", DateTime.Parse("01/02/2020"));
            Samochod s5 = new Samochod("Renault", "Clio", DateTime.Parse("06/12/2019"));
            Samochod s6 = new Samochod("Alfa_Romeo", "Stelvio", DateTime.Parse("04/03/2021"));

            PlacParkingowy p1 = new PlacParkingowy("A");
            PlacParkingowy p2 = new PlacParkingowy("B");
            PlacParkingowy p3 = new PlacParkingowy("C");
            PlacParkingowy p4 = new PlacParkingowy("D");
            PlacParkingowy p5 = new PlacParkingowy("E");
            PlacParkingowy p6 = new PlacParkingowy("F");

            Parking p = new Parking();

            try
            {
                p.Add(s1, p2);
                p.Add(s2, p1);
                p.Remove(s1);
                p.Add(s3, p2);
                p.Add(s6, p4);
            }
            catch (ZajetyMiejsceException)
            {
                Console.WriteLine($"Miejsce jest zajete");
            }
            Console.WriteLine(p);
        }
    }
}
