using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja27._01
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime DataDodania { get; set; } = DateTime.Now;

        public int Wartosc { get; set; }

    }
}
