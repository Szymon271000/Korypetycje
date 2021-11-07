using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Parking
    {
        Dictionary<Samochod, PlacParkingowy> parking = new Dictionary<Samochod, PlacParkingowy>();

        public void Add (Samochod s, PlacParkingowy p)
        {
            if (parking.ContainsValue(p))
            {
                throw new ZajetyMiejsceException();
            }
            else
            {
                parking.Add(s, p);
                p.Status = false;
            }     
        }

        public void Remove (Samochod s)
        {
            parking.Remove(s);
        }

        public override string ToString()
        {
            string wynik = string.Empty;
            foreach (var plac in parking)
            {
                wynik += plac + "\n";
            }
            return wynik;
        }
    }
}
