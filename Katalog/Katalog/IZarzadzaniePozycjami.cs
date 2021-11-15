using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    interface IZarzadzaniePozycjami
    {
         Pozycja ZnajdzPozycjepoTytule(string tytul);
         Pozycja ZnajdzPozycjePoId(int id);
         void WypiszWszystkiePozycje();
    }
}
