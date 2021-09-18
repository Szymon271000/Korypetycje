using System;
using System.IO;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = File.ReadAllText(@"C:\Users\huber\OneDrive\Desktop\Dane2.txt");
            string[] Users = info.Split("\n");
            int counter = 0;
            int counter2 = 0;
            for(int i = 0; i < Users.Length; i++)
            {
                string[] user = Users[i].Split(",");

                    if (user[4] == "Female")
                    {
                        counter++;
                    }
                
                if (user[1].StartsWith("A") && user[2].StartsWith("T"))
                {
                    Console.WriteLine(user[1] + " "+ user[2]);
                }
                if (user[3].EndsWith(".pl"))
                {
                    counter2++;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine();

            Console.WriteLine(counter2);
            Console.WriteLine();

        }
    }
}
