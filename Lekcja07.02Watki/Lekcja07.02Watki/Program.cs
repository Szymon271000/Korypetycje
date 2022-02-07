using System;
using System.IO;
using System.Threading;

namespace Lekcja07._02Watki
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\huber\Downloads\powiesc.txt";
            string data = File.ReadAllText(path);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            int ilosc = 0;
            Thread t = new Thread(() =>
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                for (int i = 0; i < data.Length/2; i++)
                {
                    if (data[i] == 'a')
                    {
                        ilosc++;
                    }
                }
            });

            int ilosc2 = 0;
            Thread t2 = new Thread(() =>
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                for (int i = data.Length / 2; i < data.Length; i++)
                {
                    if (data[i] == 'a')
                    {
                        ilosc2++;
                    }
                }
            });

            t.Start();
            t2.Start();

            t.Join(); //Join - zaczekaj na watek az sie skonczy
            t2.Join();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(ilosc + ilosc2);
            Console.WriteLine(elapsedMs + "ms");
        }
    }
}
