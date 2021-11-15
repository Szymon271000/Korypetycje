using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franki2._0
{
    class Historia : IZainteresowany
    {
        private List<double> historiaKursow = new List<double>();
        public void ZmianaKursu(double kurs)
        {
            historiaKursow.Add(kurs);
        }

        public void PokazHistorieKursow()
        {
            foreach (var item in historiaKursow)
            {
                Console.WriteLine(item);
            }
        }
    }
}
