using System;

namespace SVG
{
    class Program
    {
        static void Main(string[] args)
        {
            Obrazek o = new Obrazek();
            Circle c1 = new Circle(50, 50, 40, "black", "3", "red");
            Line l1 = new Line(0, 0, 200, 200, "stroke:rgb(0,0,0);stroke-width:2");
            Obrazek x = new Obrazek();
            x.Add(o);
            
            o.Add(c1);
            o.Add(l1);
            string napis = o.Draw();
            Console.WriteLine(napis);

            Console.WriteLine(x.Draw());
        }
    }
}
