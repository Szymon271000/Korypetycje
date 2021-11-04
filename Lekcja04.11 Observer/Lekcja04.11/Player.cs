using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja04._11
{
    class Player
    {
        private int hp = 100;
        private List<IObserwator> obserwatorow = new List<IObserwator>();

        public int Hp
        {
            get => hp;
            set
            {
                if (value != hp)
                {
                    hp = value;
                    PowiadomZmianaHp();
                }
            }
        }
                
	         

        public void Add (IObserwator obserwator)
        {
            obserwatorow.Add(obserwator);
        }

        public void PowiadomZmianaHp()
        {
            for (int i = 0; i < obserwatorow.Count; i++)
            {
                obserwatorow[i].ZmianaHp(Hp);
            }
        }
    }
}
