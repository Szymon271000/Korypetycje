using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja04._11
{
    class HpInfo : IObserwator
    {
        public void ZmianaHp(int hp)
        {
            Console.WriteLine($"Hp: {hp}");
        }
    }
}
