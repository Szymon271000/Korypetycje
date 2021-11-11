using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    class Katalog
    {
        private string dzialTematyczny;
        private List<Pozycja> position = new List<Pozycja>();

        public void AddPosition (Pozycja p)
        {
            position.Add(p);
        }
        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

        public Pozycja ZnajdzPozycje(string tytul)
        {
            for (int i = 0; i < position.Count; i++)
            {
                if (position[i].Tytul == tytul)
                {
                    return position[i];
                }
            }
            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            for (int i = 0; i < position.Count; i++)
            {
                Console.WriteLine(position[i]);
            }
        }
    }
}
