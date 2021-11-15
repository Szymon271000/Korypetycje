using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franki2._0
{
    class KursFranka
    {
        private double przelicznik;
        private List<IZainteresowany> person = new List<IZainteresowany>();

        public KursFranka(float przelicznik)
        {
            this.Przelicznik = przelicznik;
        }

        public double Przelicznik { get => przelicznik; 
            set 
            {
                
                    if (value != przelicznik)
                    {
                        przelicznik = value;
                        ZmianaKursu();
                    }
                
            }
            
        }

        public void DodajZainteresowanego(IZainteresowany p)
        {
            person.Add(p);
        }

        public void ZmianaKursu()
        {
            for (int i = 0; i < person.Count; i++)
            {
                person[i].ZmianaKursu(przelicznik);
            }
        }
    }
}
