using System;

namespace AutomatDoKawy
{
    class Program
    {
        static void Main(string[] args)
        {
            Automat a = new Automat();
            a.Wrzuc(new Moneta());
            a.Wrzuc(new Moneta());
            a.zamowKawe("duza");
            a.zamowKawe("mala");
            a.Wrzuc(new Moneta());
            a.Wrzuc(new Moneta());
            a.Wrzuc(new Moneta());
            a.zamowKawe("duza");
            Console.WriteLine(a);
        }
    }
}
