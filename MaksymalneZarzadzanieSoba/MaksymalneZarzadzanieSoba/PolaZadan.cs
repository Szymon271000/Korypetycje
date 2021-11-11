using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymalneZarzadzanieSoba
{
    class PolaZadan
    {
        private List<Zadanie> zadania;

        public PolaZadan()
        {
            zadania = new List<Zadanie>();
        }

        public void DodajZadanie(Zadanie z)
        {
            zadania.Add(z);
        }

        public void UsunZadanie(Zadanie z)
        {
            zadania.Remove(z);
        }
        public void UsunZadanieZListy(int number)
        {
            zadania.RemoveAt(number);
        }

        public void Wczytaj(string nazwaPliku)
        {
            string text = File.ReadAllText(nazwaPliku);
            string[] linie = text.Replace("\r", "").Split("\n");
            foreach (var linia in linie)
            {
                if(linia == "")
                {
                    break;
                }
                var elementy = linia.Split(";");
                string[] dataandstatus = new string[] { elementy[0], elementy[1], elementy[2] };
                Zadanie z = new Zadanie(dataandstatus[0], DateTime.Parse(dataandstatus[1]), dataandstatus[2]); // data jest 000000000
                zadania.Add(z);
            }
        }
        // ask
        public void Zapisz(string nazwaPliku)
        {
            for (int i = 0; i < zadania.Count; i++)
            {
                File.WriteAllText(nazwaPliku, ToString());
            }
            
        }

        public void ZmienStatusZListy(string Inputstatus, int number)
        {
            zadania[number].Status = Inputstatus;
        }

        public void Sprawdz()
        {
            for (int i = 0; i < zadania.Count; i++)
            {
                if (zadania[i].Status == "Niewykonane" && zadania[i].Data < DateTime.Now)
                {
                    Console.WriteLine(zadania[i]);
                }
            }
        }



        public override string ToString()
        {
            string wynik = string.Empty;
            for (int i = 0; i < zadania.Count; i++)
            {
                wynik += zadania[i].ToCSV() + "\n";
            }
            return wynik;
        }
    }

}
