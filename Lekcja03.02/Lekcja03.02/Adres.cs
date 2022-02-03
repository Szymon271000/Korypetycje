using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja03._02
{
    class Adres
    {
        private string ulica;
        private int nrMieszkania;
        private string miasto;

        public Adres(string ulica, int nrMieszkania, string miasto)
        {
            this.ulica = ulica;
            this.nrMieszkania = nrMieszkania;
            this.miasto = miasto;
        }

        public string Ulica { get => ulica; set => ulica = value; }
        public int NrMieszkania { get => nrMieszkania; set => nrMieszkania = value; }
        public string Miasto { get => miasto; set => miasto = value; }

        public override string ToString()
        {
            return $"{nameof(ulica)}: {ulica}, {nameof(nrMieszkania)}: {nrMieszkania}, {nameof(miasto)}: {miasto}";
        }
    }
}
