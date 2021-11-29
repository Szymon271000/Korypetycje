using System;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            CarContext carcontex1 = new CarContext();
            Car c1 = new Car
            {
                Marka = "Audi",
                Model = "A4"
            };

            for (int i = 0; i < 5; i++)
            {
               
                string Input = Console.ReadLine();
                string[] carsdata = Input.Split(" ");
                Car c = new Car();
                c.Marka = carsdata[0];
                c.Model = carsdata[1];
                carcontex1.Add(c);
            }
            carcontex1.SaveChanges();
        }
    }
}
