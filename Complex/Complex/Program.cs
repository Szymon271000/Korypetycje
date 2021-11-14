using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(4, -5);
            Console.WriteLine(c1 / c2);
        }
    }
}
