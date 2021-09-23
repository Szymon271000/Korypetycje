using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20._09
{
    class Prostokat //to jest definicja obiektu (przepis jak zbudowac obiekt)
    {
        public int dlugosc; //to jest pole klasy
        public int szerokosc; //to jest pole klasy
        public string kolor; //to jest pole klasy

        //konstruktor - to funkcja ktora uruchamia sie jednorazowo podczas tworzenia obiektu
        //konsturktor odpowiada za inicjalizacje czyli wypelnienie danymi obiektu
        //konstruktor moze byc wiele ale musza sie roznica argumentami

        //konstruktor domyslny (bezargumentowy)
        public Prostokat()
        {
            dlugosc = 1;
            szerokosc = 1;
            kolor = "red";
            Console.WriteLine("Tworzne nowy prostokat!");
        }

        //to jest konstruktor argumentowy
        public Prostokat(int dl, int szer, string kol)
        {
            dlugosc = dl;
            szerokosc = szer;
            kolor = kol;
        }

        public int Pole()
        {
            return dlugosc * szerokosc;
        }

        public int Obwod()
        {
            return dlugosc * 2 + szerokosc * 2;
        }

        public override string ToString()
        {
            return $"Prostokat ma dlugosc: {dlugosc}, szerokosc: {szerokosc} i kolor: {kolor}";
        }
    }
}
