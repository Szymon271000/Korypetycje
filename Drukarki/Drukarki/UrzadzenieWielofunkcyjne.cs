using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    class UrzadzenieWielofunkcyjne : Urzadzenie, IDrukowanie, ISkanowanie
    {
        private int szybkosc;
        private string rodzajPolaczenia;
        private int iloscTuszu;

        public UrzadzenieWielofunkcyjne(string marka, string model, string rodzajPolaczenia, int szybkosc, int iloscTuszu): base (marka, model)
        {
            this.rodzajPolaczenia = rodzajPolaczenia;
            this.rodzajPolaczenia = rodzajPolaczenia;
            this.iloscTuszu = iloscTuszu;
        }

        public void Drukuj()
        {
            if (iloscTuszu <= 0)
            {
                throw new BrakTuszuException();
            }
            else
            {
                iloscTuszu--;
                Console.WriteLine("Drukarka moze drukowac 100000 razy");
            }
        }

        public void Skanuj()
        {
            if (szybkosc <= 0)
            {
                throw new SzybkoscUjemnaException();
            }
            else
            {
                Console.WriteLine($"Drukarka moze skanowac kartke w {szybkosc} sekundach");
            }
        }

        public override string ToString()
        {
            return $"Urzadzenie wielofunkcyjne: {Marka}, {Model}, {rodzajPolaczenia}";
        }
    }
}
