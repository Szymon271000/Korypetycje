using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class PytaniaRepository
    {
        private List<Pytanie> pytania;

        public PytaniaRepository()
        {
            pytania = new List<Pytanie>();
        }

        public void DodajPytanie(Pytanie p)
        {
            pytania.Add(p);
        }

        public Pytanie WylosujPytanie()
        {
            Random rand = new Random();
            return pytania[rand.Next(0, pytania.Count)];
        }

        public void Wczytaj(string nazwaPliku)
        {
            string text = File.ReadAllText(nazwaPliku);
            string[] linie = text.Split("\r\n");
            foreach (var linia in linie)
            {
                var elementy = linia.Split(";");
                string[] odpowiedzi = new string[] { elementy[1], elementy[2], elementy[3], elementy[4] };
                Pytanie p = new Pytanie(elementy[0], odpowiedzi, int.Parse(elementy[5]));
                pytania.Add(p);
            }
        }
    }
}
