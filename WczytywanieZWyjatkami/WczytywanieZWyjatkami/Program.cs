using System;

namespace WczytywanieZWyjatkami
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int i = 0;
            try
            {
                Console.Write("Podaj liczbe: ");
                string Input = Console.ReadLine();
                int number1 = int.Parse(Input);
                suma += number1;

                while (true)
                {
                    Console.Write("Podaj liczbe: ");
                    Input = Console.ReadLine();
                    int number = int.Parse(Input);
                    suma = suma + number;
                    i++;
                }
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Zly format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Liczba za duza");
            }

            if (i != 0)
            {
                int srednia = suma / i;
                Console.WriteLine(srednia);
            }
            

        }
    }
}
