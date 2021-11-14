using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    interface IZarzadzaniePozycjami
    {
        public Pozycja ZnajdzPozycjepoTytule(string tytul);
        public Pozycja ZnajdzPozycjePoId(int id);
        public void WypiszWszystkiePozycje();
    }
}
