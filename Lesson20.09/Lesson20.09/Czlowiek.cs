using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20._09
{
    class Czlowiek
    {
        public int Wzrost;
        public string Zawod;
        public char Plec;
        public string Narodowosc;
        public string Imie;

        public Czlowiek()
        {
            Wzrost = 175;
            Zawod = "Programista";
            Plec = 'M';
            Narodowosc = "Polska";
            Imie = "Lukasz";
        }

        public Czlowiek(int Wzrost, string Za, char Pl, string Naro, string Im)
        {
            //Wzrost = Wzrost; //to nie zadziala bo nazwa Wzrost przyslania pole o takiej samej nazwie
            this.Wzrost = Wzrost; //slowo this pozwala na odroznienie argumentu od pola klasy, this - wziete z obiektu
            Zawod = Za;
            Plec = Pl;
            Narodowosc = Naro;
            Imie = Im;
        }
        public string PrzedstawSie()
        {
            return $"Nazywam sie {Imie} i pracuje jako: {Zawod}";
        }

    }
}
