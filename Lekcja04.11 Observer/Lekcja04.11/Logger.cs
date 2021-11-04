using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja04._11
{
    class Logger : IObserwator
    {
        private Dictionary<DateTime, int> gamerInfo = new Dictionary<DateTime, int>();
        public void ZmianaHp(int hp)
        {
            gamerInfo.Add(DateTime.Now, hp);
        }

        public override string ToString()
        {
            string wynik = string.Empty;
            foreach (var gaminginfo in gamerInfo)
            {
                wynik += gaminginfo + "\n";
            }
            return wynik;
        }
    }
}
