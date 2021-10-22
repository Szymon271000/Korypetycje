using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadTrip
{
    class Silnik : ICzujnik
    {
        private int aktualnaMoc;
        private int aktualnyCzasPracy;

        public Silnik(int aktualnaMoc, int aktualnyCzasPracy)
        {
            this.aktualnaMoc = aktualnaMoc;
            this.aktualnyCzasPracy = aktualnyCzasPracy;
        }

        public int Policz()
        {
            int temperatura = aktualnaMoc / 10 * aktualnyCzasPracy * 100;
            return temperatura;
        }
        
        public bool Alarm(int temperatura)
        {
            temperatura = Policz();
            if (temperatura > 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
