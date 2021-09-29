using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlytaGlowna
{
    class PlytaGlowna
    {
        private List<Ram> rams;
        private string Producent;
        private int MaksymalnyRozmiar;

        public PlytaGlowna(string producent, int maksymalnyRozmiar)
        {
            Producent = producent;
            MaksymalnyRozmiar = maksymalnyRozmiar;
            rams = new List<Ram>();
        }

        public void AddRam(Ram u)
        {
            int suma = 0;
            for (int i = 0; i < Rams.Count; i++)
            {
                suma = suma + Rams[i].Pojemnosc1;
                if (suma < MaksymalnyRozmiar)
                {
                    Rams.Add(u);
                }
            }
        }

        public List<Ram> Rams { get => rams; }
        
        public override string ToString()
        {
            string Text = "Plyta Glowna \n ";
            for (int i = 0; i < Rams.Count; i++)
            {
                Text += Rams[i] + "\n";
            }
            return Text;
        }
    }
}
