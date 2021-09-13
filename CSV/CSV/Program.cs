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
            for(int i = 0; i < Users.Length; i++)
            {
                string[] user = Users[i].Split(",");
                Console.WriteLine(user[1]);
            }
            
        }
    }
}
