using System;
using System.Collections.Generic;

namespace Inicjaly
{
    class Program
    {
        static List<string> LiteryImion (List<string> Imiona)
        {
            List<string> ListZDuzej = new List<string>();
            for (int i = 0; i < Imiona.Count; i++)
            {
                ListZDuzej.Add(Imiona[i][0] + "");
            }
            return ListZDuzej;
        }
        static void Main(string[] args)
        {
            List<string> Imiona = new List<string>() { "Ada", "Ola", "Ania", "Tomasz", "Janusz" };
            List<string> Result = LiteryImion(Imiona);
            for (int i = 0; i < Result.Count; i++)
            {
                Console.WriteLine(Result[i]);
            }
        }
    }
}
