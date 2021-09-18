using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImionaZDuzej
{
    class Program
    {
        public static List<string> PrawidloweImiona(List<string> imiona)
        {
            List<string> ImionaZDuzej = new List<string>();
            for (int i = 0; i < imiona.Count; i++)
            {
                if (Char.IsUpper(imiona[i], 0))
                {
                    ImionaZDuzej.Add(imiona[i]);
                }
            }
            return ImionaZDuzej;
        }
        static void Main(string[] args)
        {
            List<string> Imiona = new List<string>() { "Jan", "bob", "Krzysztof", "Szymon", "radek", "Andrzej" };
            List<string> ImionaZDuzej = PrawidloweImiona(Imiona);
            for (int i = 0; i < ImionaZDuzej.Count; i++)
            {
                Console.Write(ImionaZDuzej[i] + " ");
            }
        }
    }
}
