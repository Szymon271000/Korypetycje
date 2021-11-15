using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    class Biblioteka:IZarzadzaniePozycjami
    {
        private string adres;
        private List<Bibliotekarz> bibliotekarzs;
        private List<Katalog> Katalog;

        public Biblioteka(string adres)
        {
            this.adres = adres;
        }

        public void Add (Bibliotekarz b)
        {
            bibliotekarzs.Add(b);
        }

        public void WypiszBibliotekarzy()
        {
            for (int i = 0; i < bibliotekarzs.Count; i++)
            {
                Console.WriteLine(bibliotekarzs[i]);
            }
        }

        public void DodajKatalog(Katalog k)
        {
            Katalog.Add(k);
        }

        public void DodajPozycje(Pozycja pozycja, string dzialTematyczny) 
        {
            foreach (var katalog in Katalog)
            {
                if(katalog.DzialTematyczny == dzialTematyczny)
                {
                    katalog.AddPosition(pozycja);
                    break;
                }
            }
        }


        public override string ToString()
        {
            return $"Biblioteka ma adres {adres}";
        }

        public Pozycja ZnajdzPozycjepoTytule(string tytul)
        {
            for (int i = 0; i < Katalog.Count; i++)
            {
                var pozycja = Katalog[i].ZnajdzPozycjepoTytule(tytul);
                if (pozycja != null)
                {
                    return pozycja;
                }
            }
            return null;
        }

        /*
         * {
                for (int i = 0; i < position.Count; i++)
                {
                    if (position[i].Tytul == tytul)
                    {
                        return position[i];
                    }
                }
                return null;
            }
          */

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            for (int i = 0; i < Katalog.Count; i++)
            {
                var pozycja = Katalog[i].ZnajdzPozycjePoId(id);
                if(pozycja != null)
                {
                    return pozycja;
                }
            }
            //for (int i = 0; i < Pozycja.Count; i++)
            //{
            //    if (Pozycja[i].Id == id)
            //    {
            //        return Pozycja[i];
            //    }
            //}
            return null;
        }

        /*
         *             for (int i = 0; i < position.Count; i++)
            {
                if (position[i].Id == id)
                {
                    return position[i];                }
            }
            return null;
         */
        public void WypiszWszystkiePozycje()
        {
            for (int i = 0; i < Katalog.Count; i++)
            {
                Katalog[i].WypiszWszystkiePozycje();
            }
            //for (int i = 0; i < Pozycja.Count; i++)
            //{
            //    Console.WriteLine(Pozycja[i]);
            //}
        }
    }
}
