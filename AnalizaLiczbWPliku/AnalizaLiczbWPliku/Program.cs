using System;
using System.Collections.Generic;
using System.IO;

namespace AnalizaLiczbWPliku 
{ 
    
    class Program
    {
        static void Main(string[] args)
        {
            string info = File.ReadAllText(@"C:\Users\huber\OneDrive\Desktop\Liczby.txt");
            string[] linie = info.Split("\r\n");
            long[] Numbers = new long[linie.Length];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = long.Parse(linie[i]);
            }

            int Counter1000000 = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == 1000000)
                {
                    Counter1000000++;
                }
            }

            Console.WriteLine(Counter1000000);

            int CounterPrzedzial = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if ((Numbers[i] > 500000) && (Numbers[i] < 1000000))
                {
                    CounterPrzedzial++;
                }
            }

            Console.WriteLine(CounterPrzedzial);

            long min = long.MaxValue;
            long max = long.MinValue;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < min)
                {
                    min = Numbers[i];
                }
                if (Numbers[i] > max)
                {
                    max = Numbers[i];
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);

            bool czyDodatnie = true;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < 0)
                {
                    czyDodatnie = false;
                    break;
                }
            }

            Console.WriteLine(czyDodatnie);


            List<long> ListaOdDO = new List<long>();

            for (int i = 0; i < Numbers.Length; i++)
            {
                if ((Numbers[i] > 100000) && (Numbers[i] < 1000000))
                {
                    ListaOdDO.Add(Numbers[i]);
                }
            }

            List<long> ListOdDoPrzez3 = new List<long>();

            for (int i = 0; i < ListaOdDO.Count; i++)
            {
                if (ListaOdDO[i] % 3 == 0)
                {
                    ListOdDoPrzez3.Add(ListaOdDO[i]);
                }
                else
                {
                    break;
                }
            }

            bool Right = true;
            bool False = false;

            if (ListaOdDO.Count == ListOdDoPrzez3.Count)
            {
                Console.WriteLine(Right);
            }
            else
            {
                Console.WriteLine(False);
            }

            long SumaParzystych = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] % 2 == 0)
                {
                    SumaParzystych = SumaParzystych + Numbers[i];
                }
            }

            Console.WriteLine(SumaParzystych);

            List<long> ZJedynka = new List<long>();

            for (int i = 0; i < Numbers.Length; i++)
            {
                if(Numbers[i].ToString().Contains("1"))
                {
                    ZJedynka.Add(Numbers[i]);
                }
            }

            Console.WriteLine(ZJedynka.Count);


            long MaxPrzedzial = long.MinValue;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if ((Numbers[i] > 100000) && (Numbers[i] < 200000))
                {
                    
                    if (Numbers[i] > MaxPrzedzial)
                    {
                        MaxPrzedzial = Numbers[i];  
                    }
                }
            }

            Console.WriteLine(MaxPrzedzial);
            

        }
    }
}