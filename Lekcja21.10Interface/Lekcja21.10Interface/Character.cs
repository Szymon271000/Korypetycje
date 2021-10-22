using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja21._10Interface
{
    class Character : IObrona
    {
        protected int hp;

        public Character()
        {
            hp = 50;
        }
        public virtual void PrzyjmijCios(int ile)
        {
            if(ile > 0)
            {
                hp = 0; 
            }
        }
    }
}
