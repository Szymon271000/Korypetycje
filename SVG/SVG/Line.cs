using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class Line : ElementSVG
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private string style;

        public Line(int x1, int y1, int x2, int y2, string style)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.style = style;
        }

        public override string Draw()
        {
            return $"<line x1=\"{x1}\" y1=\"{y1}\" x2=\"{x2}\" y2=\"{y2}\" style=\"{style}\" />";
        }
    }
}
