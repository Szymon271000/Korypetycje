using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franki2._0
{
    class KursFranka: IZainteresowany
    {
        private float przelicznik;
        List<Person> person = new List<Person>();

        public KursFranka(float przelicznik)
        {
            this.Przelicznik = przelicznik;
        }

        public float Przelicznik { get => przelicznik; 
            set 
            {
                {
                    if (value != przelicznik)
                    {
                        przelicznik = value;
                        ZmianaKursu();
                    }
                }
            }
            
        }

        public void DodajZainteresowanego(Person p)
        {
            person.Add(p);
        }

        public void ZmianaKursu()
        {
            for (int i = 0; i < person.Count; i++)
            {
                Console.WriteLine($"Zmiana wartosci na {Przelicznik}, aktualna wartosc kredytu w zl dla {person[i].Imie} {person[i].Nazwisko} to : {person[i].Kwota * Przelicznik} zl");
            }
        }
    }
}
