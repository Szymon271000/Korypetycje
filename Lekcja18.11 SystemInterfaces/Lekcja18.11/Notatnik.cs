using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._11
{
    class Notatnik : IDisposable
    {
        private string text = string.Empty;

        public void Dispose() //wywoluje sie w momencie kasowania obiektu
        {
            Console.WriteLine("Zapis..");
            File.WriteAllText("dane.txt", text);
        }

        public void DodajLinie(string linia)
        {
            text += linia + "\n";
        }


    }
}
