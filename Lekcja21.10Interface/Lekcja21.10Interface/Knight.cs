using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja21._10Interface
{
    class Knight : Character, IAtak
    {
        private int atak;
        private int obrona;

        public Knight(int atak, int obrona)
        {
            this.atak = atak;
            this.obrona = obrona;
        }

        public void Atakuj(IObrona obronca)
        {
            obronca.PrzyjmijCios(atak);
        }

        public override void PrzyjmijCios(int ile)
        {
            hp -= ile / obrona;
            if(hp < 0)
            {
                hp = 0;
            }
        }
    }
}
