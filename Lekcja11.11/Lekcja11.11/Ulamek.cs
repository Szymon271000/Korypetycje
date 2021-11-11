using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja11._11
{
    class Ulamek
    {
        private int numerator;
        private int denominator;


        public Ulamek(int numerator = 1, int denominator = 1)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            Skroc();
        }

        private void Skroc()
        {
            int a = Liczby.NWD(Numerator, Denominator);
            Numerator = Numerator / a;
            Denominator = Denominator / a;
        }

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = value; }

        public override string ToString()
        {
            return $"Ulamek: {numerator} / {denominator}";
        }

        public static bool operator >(Ulamek u1, Ulamek u2)
        {
            return u2.denominator * u1.numerator > u1.denominator * u2.numerator;
        }

        public static bool operator <(Ulamek u1, Ulamek u2)
        {
            return u2.denominator * u1.numerator < u1.denominator * u2.numerator;
        }


        public static bool operator==(Ulamek u1, Ulamek u2)
        {
            return u1.numerator == u2.numerator && u1.denominator == u2.denominator;
        }

        public static bool operator!=(Ulamek u1, Ulamek u2)
        {
            return !(u1 == u2);
        }

        public static Ulamek operator *(Ulamek u1, Ulamek u2)
        {
            var result = new Ulamek(u1.numerator * u2.numerator, u1.denominator * u2.denominator);
            return result;
        }

        public static Ulamek operator *(Ulamek u1, int liczba)
        {
            return new Ulamek(u1.numerator * liczba, u1.denominator);
        }

        public static Ulamek operator / (Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.numerator * u2.denominator, u1.denominator * u2.numerator);
        }

        //public static implicit operator double(Ulamek u1) //konwersja na double
        //{
        //    return (double)u1.numerator / u1.denominator;
        //}

        public static explicit operator Ulamek(int liczba)
        {
            return new Ulamek(liczba);
        }
    }
}
