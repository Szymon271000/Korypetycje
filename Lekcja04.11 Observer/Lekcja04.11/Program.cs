using System;

namespace Lekcja04._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            HpInfo hpInfo = new HpInfo();
            p1.Add(hpInfo);
            int value = 20;
            Logger logger = new Logger();
            p1.Add(logger);

            p1.Hp -= value;
            p1.Hp -= value;
            p1.Hp -= value;

            Console.WriteLine(logger);


        }
    }
}
