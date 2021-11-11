using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    class Ksiazka: Pozycja
    {
        private int liczbaStron;
        private List<Autor> autors = new List<Autor>();

        public int LiczbaStron { get => liczbaStron; set => liczbaStron = value; }

        public void AddAutor(Autor a)
        {
            autors.Add(a);
        }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron): base (tytul, id, wydawnictwo, rokWydania)
        {
            this.LiczbaStron = liczbaStron;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine($"Ksiazka: {Tytul} {Id} {Wydawnictwo} {RokWydania} {LiczbaStron}");
            foreach (var autor in autors)
            {
                Console.WriteLine(autor);
            }
        }
    }
}
