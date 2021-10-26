using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    class Drukarka: Urzadzenie, IDrukowanie
    {
        private int iloscTuszu;

        public Drukarka(string marka, string model, int iloscTuszu): base(marka,model)
        {
            this.IloscTuszu = iloscTuszu;
        }

        public int IloscTuszu
        {
            get => iloscTuszu;
            set
            {
                if (value > 0)
                {
                    value = iloscTuszu;
                }
            }
        }

        public void Drukuj()
        {
            if (iloscTuszu <= 0 )
            {
                throw new BrakTuszuException();
            }
            else
            {
                iloscTuszu--;
                Console.WriteLine("Drukarka moze drukowac 100000 razy");
            }
            
        }

        public override string ToString()
        {
            return $"Drudarka: {Marka}, {Model}, {IloscTuszu}";
        }
    }
}
