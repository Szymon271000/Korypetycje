using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Tekst
    {
        private int id;
        private string tresc;
        static int indeks = 1;

        public int Id { get => id; set => id = value; }
        public string Tresc { get => tresc; set => tresc = value; }
        public static int Indeks { get => indeks; set => indeks = value; }

        public Tekst(string tresc)
        {
            this.Id = Indeks;
            Indeks++;
            this.Tresc = tresc;
        }

        public virtual float ObliczWartosc()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Tekst id: {Id} {Tresc}";
        }

        public int IloscLiter()
        {
            int ilosc = 0;
            foreach (char letter in Tresc)
            {
                if (char.IsLetter(letter))
                {
                    ilosc++;
                }
            }
            return ilosc;
        }
    }
}
