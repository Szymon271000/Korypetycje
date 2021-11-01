using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Pytanie
    {
        private string tresc;
        private string[] odp;
        private int poprawnaNr;

        public Pytanie(string tresc, string[] odp, int poprawnaNr)
        {
            this.tresc = tresc;
            this.odp = odp;
            this.poprawnaNr = poprawnaNr;
        }

        public string Tresc { get => tresc; }
        public string[] Odp { get => odp; }
        public int PoprawnaNr { get => poprawnaNr; }

        public override string ToString()
        {
            return $"{tresc} 1. {odp[0]} 2. {odp[1]} 3. {odp[2]} 4. {odp[3]}";
        }
        
    }
}
