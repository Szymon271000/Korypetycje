using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacjenciZLINQ
{
    class BazaPacjentow
    {
        List<Pacjent> pacjenci = new List<Pacjent>();

        public void Add(Pacjent p)
        {
            pacjenci.Add(p);
        }

        public void Remove(Pacjent p)
        {
            pacjenci.Remove(p);
        }

        public List<Pacjent> StarsiNiz(int wiek)
        {
            List<Pacjent> pstarsiod = pacjenci.FindAll(x => x.Wiek > wiek);
            return pstarsiod;
        }

        public bool Znajdz(string imie, string nazwisko)
        {
            bool result = pacjenci.Any(x => x.Imie == imie && x.Nazwisko == nazwisko);
            return result;
        }

        public int PoliczNieubezpieczonych()
        {
            int NieUbezpieczonych = pacjenci.Count(x => x.NumerUbezpieczenia == string.Empty);
            return NieUbezpieczonych;
        }

        public override string ToString()
        {
            string result = string.Empty;
            pacjenci.ForEach(x => result += x + "\n");
            return result;
        }
    }
}
