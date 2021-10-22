using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class Circle : ElementSVG
    {
        private int cx;
        private int cy;
        private int r;
        private string stroke;
        private string strwidth;
        private string fill;

        public Circle(int cx, int cy, int r, string stroke, string strwidth, string fill)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r;
            this.stroke = stroke;
            this.strwidth = strwidth;
            this.fill = fill;
        }

        public override string Draw()
        {
            return $"<circle cx=\"{cx}\" cy=\"{cy}\" r=\"{r}\" fill=\"{fill}\" />";
        }
    }
}
