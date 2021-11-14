using System;

namespace Franki2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            KursFranka kurs = new KursFranka(2.7f);
            Person os1 = new Person("Jan", "Kowalski", 200000);
            Person os2 = new Person("Ada", "Nowak", 500000);

            kurs.DodajZainteresowanego(os1);
            kurs.DodajZainteresowanego(os2);

            kurs.Przelicznik = 2.8f;
        }
    }
}
