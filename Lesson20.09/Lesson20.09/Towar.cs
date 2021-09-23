using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20._09
{
    class Towar
    {
        public int NrProduktu;
        public string Nazwa;
        public double CenaBrutto;

        public double CenaNetto { get => CenaBrutto / 1.23; 
            set
            {
                if(value >= 0)
                {
                    CenaBrutto = value * 1.23;
                }
            }
        }

        //1. Zaznacz wszystkie pola ktore chcesz wypelnic w konstruktorze
        //2. Kliknij na ikonke przelacznika i wybierz "Create contructor (... )"

        public Towar(int nrProduktu, string nazwa, double cenaBrutto)
        {
            NrProduktu = nrProduktu;
            Nazwa = nazwa;
            CenaBrutto = cenaBrutto;
        }



        //1. Kliknij pusta linie w klasie
        //2. Kliknij w ikone przelacznika i wybierz "generate overrides"
        //3. Odznacz wszystkie opcje poza ToString()

        public override string ToString() // ta metoda sluzy do zamiany obiektu na string, musimy zdefiniowac ta zamiane
        {
            return $"Towar: {Nazwa} nr: {NrProduktu} cena brutto: {CenaBrutto} cena netto: {CenaNetto}"; 
        }
    }
}
