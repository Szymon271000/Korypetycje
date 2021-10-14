using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja11._10Dziecinienie
{
    class ProductsList
    {
        public List<Telefon> telefons = new List<Telefon>();
        public List<Monitor> monitors = new List<Monitor>();

        public void Add (Telefon u)
        {
            telefons.Add(u);
        }
        public void Add(Monitor u)
        {
            monitors.Add(u);
        }

        public override string ToString()
        {
            string wynik = "Lista: \n";
            for (int i = 0; i < telefons.Count; i++)
            {
                wynik += telefons[i] + "\n";
            }
            for (int i = 0; i < monitors.Count; i++)
            {
                wynik += monitors[i] + "\n";
            }
            return wynik;
        }
    }
}
