using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class Obrazek:ElementSVG
    {
        List<ElementSVG> elementSVGs = new List<ElementSVG>();

        internal List<ElementSVG> ElementSVGs { get => elementSVGs; set => elementSVGs = value;}

        public void Add(ElementSVG element)
        {
            elementSVGs.Add(element);
        }

        public override string Draw()
        {
            string opis = "<svg height: \"100\" width: \"100\">";
            string koniec = "</svg>";
            string napis = string.Empty;
            for (int i = 0; i < elementSVGs.Count; i++)
            {
                napis += elementSVGs[i].Draw() + "\n";
            }
            return opis + "\n" + napis + koniec;
        }
 
    }
}
