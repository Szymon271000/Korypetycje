using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lekcja05._10
{
    public class Punkt
    {
        private int x;
        private int y;

        public Punkt()
        {

        }
        public Punkt(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
