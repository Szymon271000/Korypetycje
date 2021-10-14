using System;
using System.Collections.Generic;

namespace Lekcja11._10Dziecinienie
{
    class Program
    {
        enum TypFilamentu { PLA, ABS, Drewno, Beton, Rubber, PET }
        static void Main(string[] args)
        {
            /*TypFilamentu typ = TypFilamentu.PLA;

            //......
            if(typ == TypFilamentu.ABS)
            {
                Console.WriteLine("ABS smierdzi :(");
            }

            switch (typ)
            {
                case TypFilamentu.PLA:
                    break;
                case TypFilamentu.ABS:
                    break;
                case TypFilamentu.Drewno:
                    break;
                case TypFilamentu.Beton:
                    break;
                case TypFilamentu.Rubber:
                    break;
                case TypFilamentu.PET:
                    break;
            }*/
            Telefon t1 = new Telefon("Samsung", 799.99f, "A50", 1, 2, Procesor.SamsungExynos2100, "Android", 4, 64, 64);
            Telefon t2 = new Telefon("Apple", 1399.99f, "Iphone13", 2, 2, Procesor.AppleA14Bionic, "IOS", 8, 128, 32);
            Telefon t3 = new Telefon("Huawei", 899.99f, "P50", 3, 2, Procesor.HuaweiHiSiliconKirin90005G, "Android", 4, 64, 64);

            Monitor k4 = new Monitor("Lenovo", 499.99f, "GamePro", 4, 2, "Gaming", 48.99f, TypMatrycy.IPS);
            Monitor k5 = new Monitor("Acer", 699.99f, "OfficePro", 4, 2, "Office", 78.99f, TypMatrycy.MVA);
            Monitor k6 = new Monitor("Asus", 699.99f, "GameDreamer", 4, 2, "Gaming", 58.99f, TypMatrycy.VA);

            ProductsList p1 = new ProductsList();
            p1.Add(t1);
            p1.Add(t2);
            p1.Add(t3);
            p1.Add(k4);
            p1.Add(k5);
            p1.Add(k6);

            Console.WriteLine(p1);
        }
    }
}
