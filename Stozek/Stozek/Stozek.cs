using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stozek
{
    class Stozek
    {
        public int Promien;
        public int Wysokosc;

        public Stozek()
        {
            Promien = 4;
            Wysokosc = 7;
        }

        public Stozek(int promien, int wysokosc)
        {
            Promien = promien;
            Wysokosc = wysokosc;
        }

        public double PolePodstawowe => Math.PI * Promien * Promien; //to dziala jak get

        public double Objetosc { get => (PolePodstawowe * Wysokosc) / 3; }

        public double L { get => Math.Sqrt((Promien * Promien) + (Wysokosc * Wysokosc)); }

        public double PoleBoczne { get => Math.PI * Promien * L; }

        public double PoleCalkowite { get => PolePodstawowe + PoleBoczne; }

        public override string ToString()
        {
            return $"Wzorek o promieniu {Promien} i o wysokosci {Wysokosc} ma pole podstawowe: {PolePodstawowe} , pole boczne: {PoleBoczne} , pole calkowite {PoleCalkowite} , tworzacza {L} i objetosc {Objetosc}";
        }
    }
}
