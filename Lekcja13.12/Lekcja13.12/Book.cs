using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja13._12
{
    class Book
    {
        private string author;
        private int rok;
        private string title;

        public Book(string author, int rok, string title)
        {
            this.author = author;
            this.rok = rok;
            this.title = title;
        }

        public string Author { get => author; set => author = value; }
        public int Rok { get => rok; set => rok = value; }
        public string Title { get => title; set => title = value; }

        public override string ToString()
        {
            return $"Ksiazka ma tytul {title} zostala napisana przez {author} i jest z {rok} roku";
        }
    }
}
