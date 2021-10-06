using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszyk
{
    class Koszyk
    {
        private List<Telefon> telefonies;

        public Koszyk()
        {
            telefonies = new List<Telefon>();
        }

        public List<Telefon> Telefonies { get => telefonies;}

        public void AddTelefon(Telefon u)
        {
            Telefonies.Add(u);
        }

        public override string ToString()
        {
            string Wynik = "Moj Koszyk: \n";
            for (int i = 0; i < Telefonies.Count; i++)
            {
                Wynik += Telefonies[i] + "\n";
            }
            return Wynik;
        }

        public float Suma()
        {
            float suma = 0;
            for (int i = 0; i < Telefonies.Count; i++)
            {
                suma = suma + Telefonies[i].Cena1;
            }

            return suma;
        }
    }
}
