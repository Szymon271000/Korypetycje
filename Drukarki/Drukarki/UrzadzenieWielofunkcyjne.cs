using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    class UrzadzenieWielofunkcyjne : Urzadzenie, IDrukowanie, ISkanowanie
    {
        private string rodzajPolaczenia;

        public UrzadzenieWielofunkcyjne(string marka, string model, string rodzajPolaczenia): base (marka, model)
        {
            this.rodzajPolaczenia = rodzajPolaczenia;
        }

        public void Drukuj()
        {
            throw new NotImplementedException();
        }

        public void Skanuj()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Urzadzenie wielofunkcyjne: {Marka}, {Model}, {rodzajPolaczenia}";
        }
    }
}
