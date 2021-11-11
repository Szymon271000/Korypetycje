using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    abstract class Pozycja
    {
        private string tytul;
        private int id;
        private string wydawnictwo;
        private int rokWydania;

        protected Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.Tytul = tytul;
            this.Id = id;
            this.Wydawnictwo = wydawnictwo;
            this.RokWydania = rokWydania;
        }

        public string Tytul { get => tytul; set => tytul = value; }
        public int Id { get => id; set => id = value; }
        public string Wydawnictwo { get => wydawnictwo; set => wydawnictwo = value; }
        public int RokWydania { get => rokWydania; set => rokWydania = value; }

        public virtual void WypiszInfo()
        {
            Console.WriteLine($"{tytul} {id} {wydawnictwo} {rokWydania}");
        }
    }
}
