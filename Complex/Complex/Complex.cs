using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        private int liczbaRzeczywista;
        private int liczbaUrojona;
        public Complex()
        {
            liczbaRzeczywista = 1;
            liczbaUrojona = 1;
        }

        public Complex(int liczbaRzeczywista, int liczbaUrojona)
        {
            this.liczbaRzeczywista = liczbaRzeczywista;
            this.liczbaUrojona = liczbaUrojona;
        }

        public override string ToString()
        {
            return $"{liczbaRzeczywista}, {liczbaUrojona}i";
        }

        public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex(c1.liczbaRzeczywista + c2.liczbaRzeczywista, c1.liczbaUrojona + c2.liczbaUrojona);
        }

        public static Complex operator - (Complex c1, Complex c2)
        {
            return new Complex(c1.liczbaRzeczywista - c2.liczbaRzeczywista, c1.liczbaUrojona - c2.liczbaUrojona);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.liczbaRzeczywista * c2.liczbaRzeczywista - c1.liczbaUrojona * c2.liczbaUrojona, c1.liczbaRzeczywista * c2.liczbaUrojona + c1.liczbaUrojona * c2.liczbaRzeczywista);
        }

        public static bool operator ==(Complex u1, Complex u2)
        {
            return u1.liczbaRzeczywista == u2.liczbaRzeczywista && u1.liczbaUrojona == u2.liczbaUrojona;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c1temp;
            int x;
            if (c2.liczbaUrojona < 0)
            {
                x = c2.liczbaUrojona * -1;
                c1temp = new Complex(c1.liczbaRzeczywista * c2.liczbaRzeczywista - c1.liczbaUrojona * c2.liczbaUrojona, c1.liczbaRzeczywista * x + c1.liczbaUrojona * c2.liczbaRzeczywista);
            }
            else
            {
                c1temp = new Complex(c1.liczbaRzeczywista * c2.liczbaRzeczywista - c1.liczbaUrojona * c2.liczbaUrojona, c1.liczbaRzeczywista * c2.liczbaUrojona + c1.liczbaUrojona * c2.liczbaRzeczywista);
            }
            int y;
            Complex c2temp;
            if (c2.liczbaUrojona < 0)
            {
                y = c2.liczbaUrojona * -1;
                c2temp = new Complex(c2.liczbaRzeczywista * c2.liczbaRzeczywista + c2.liczbaUrojona * c2.liczbaUrojona, c2.liczbaRzeczywista * y + c2.liczbaUrojona * c2.liczbaRzeczywista);
            }
            else
            {
                c2temp = new Complex(c2.liczbaRzeczywista * c2.liczbaRzeczywista - c2.liczbaUrojona * c2.liczbaUrojona, c2.liczbaRzeczywista * c2.liczbaUrojona + c2.liczbaUrojona * c2.liczbaRzeczywista);
            }

            return new Complex(c1temp.liczbaRzeczywista / c2temp.liczbaRzeczywista, c1temp.liczbaUrojona / c2temp.liczbaRzeczywista);
           
        }

    }
}
