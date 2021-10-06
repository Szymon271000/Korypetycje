using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turniej
{
    class Turniej
    {
        private List<Gracz> gracze;
        private string Imie;

        public Turniej(string imie)
        {
            this.Imie = imie;
            gracze = new List<Gracz>();
        }

        public List<Gracz> Gracze { get => gracze;}

        public override string ToString()
        {
            string text = $"Turniej {Imie} \n";
            for (int i = 0; i < Gracze.Count; i++)
            {
                text += Gracze[i] + "\n";
            }
            return text;
        }

        public void AddGracz(Gracz u)
        {
            Gracze.Add(u);
        }

        public Gracz Zwyciezca()
        {
            int max = 0;
            Gracz maxGracz = null;
            for (int i = 0; i < Gracze.Count; i++)
            {
                if (Gracze[i].Punkty1 >= max)
                {
                    max = Gracze[i].Punkty1;
                    maxGracz = Gracze[i];
                }
            }
            return maxGracz;
        }
    }
}
