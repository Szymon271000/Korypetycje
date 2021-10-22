using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja21._10Interface
{
    class Wieza : IObrona, IAtak
    {
        private int wytrzymalosc;

        public Wieza()
        {
            wytrzymalosc = 1000;
        }

        public void Atakuj(IObrona obronca)
        {
            obronca.PrzyjmijCios(10);
        }

        public void PrzyjmijCios(int ile)
        {
            wytrzymalosc -= ile;
            if(wytrzymalosc < 0)
            {
                wytrzymalosc = 0;
            }
        }
    }
}
