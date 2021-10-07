using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatDoKawy
{
    class Automat
    {
        List<Moneta> monetas = new List<Moneta>();
        private int counter;

        public void Wrzuc(Moneta u)
        {
            monetas.Add(u);
        }

        public int IleMonet()
        {
            int suma = 0;
            for (int i = 0; i < monetas.Count; i++)
            {
                suma = suma + monetas[i].wartosc;
            }
            return suma;
        }

        public void zamowKawe(string rozmiar)
        {
            if ((rozmiar == "duza") && (IleMonet() < 3))
            {
                Console.WriteLine($"Nie mozna zamowic duza kawe, potrzebujesz {3 - IleMonet()} monet");
            }
            else if ((rozmiar == "duza") && (IleMonet() >= 3))
            {
                Console.WriteLine("Zamowiono duza kawe");
                monetas.Clear();
                counter++;

            }
            else if ((rozmiar == "mala") && (IleMonet() < 2))
            {
                Console.WriteLine($"Nie mozna zamowic mala kawe, potrzebujesz {2 - IleMonet()}");
            }
            else if ((rozmiar == "mala") && (IleMonet() >= 2))
            {
                Console.WriteLine("Zamowiono mala kawe");
                monetas.Clear();
                counter++;

            }
        }

        public override string ToString()
        {
            return $"Automat wydal {counter} kawy";
        }
    }
}
