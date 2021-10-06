using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlytaGlowna
{
    public class PlytaGlowna
    {
        private List<Ram> rams;
        private string Producent;
        private int MaksymalnyRozmiar;

        public PlytaGlowna(string producent, int maksymalnyRozmiar)
        {
            Producent = producent;
            MaksymalnyRozmiar = maksymalnyRozmiar;
            rams = new List<Ram>();
        }
        public PlytaGlowna()
        {

        }

        public void AddRam(Ram u)
        {
            if(IleGB() + u.Pojemnosc1 <= MaksymalnyRozmiar)
            {
                Rams.Add(u);
            }
            else
            {
                Console.WriteLine("NIe mozna dodac wiecej ramu!");
            }
        }
        public int IleGB()
        {
            int suma = 0;
            for (int i = 0; i < Rams.Count; i++)
            {
                suma = suma + Rams[i].Pojemnosc1;
            }
            return suma;
        }

        public List<Ram> Rams { get => rams; }
        
        public override string ToString()
        {
            string Text = "Plyta Glowna \n ";
            for (int i = 0; i < Rams.Count; i++)
            {
                Text += Rams[i] + "\n";
            }
            return Text;

        }
        public void SaveXML(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(PlytaGlowna));
            TextWriter textWriter = new StreamWriter(fileName);
            xml.Serialize(textWriter, this);
            textWriter.Close();
        }
    }
}
