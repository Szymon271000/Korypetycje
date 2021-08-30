using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wage:");
            int waga = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost:");
            float wzrost = float.Parse(Console.ReadLine());
            double BMI = (waga / (wzrost*wzrost));
            if (BMI >= 18.5 && BMI <= 24.9){
                Console.WriteLine("Prawidlowa waga");
            }
            else if (BMI >= 25 && BMI <= 29.9 )
            {
                Console.WriteLine("Nadwaga");
            }
            else if (BMI >= 30 && BMI <= 34.9)
            {
                Console.WriteLine("I stopien otylosci");
            }
            else if (BMI >= 35 && BMI <= 39.9)
            {
                Console.WriteLine("II stopien otylosci");
            }
            else if (BMI > 40 && BMI <= 49.9)
            {
                Console.WriteLine("III stopien otylosci");
            }
        }
    }
}
