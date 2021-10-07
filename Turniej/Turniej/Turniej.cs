using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Turniej
{
    public class Turniej
    {
        private List<Gracz> gracze;
        private string Imie;

        public Turniej(string imie)
        {
            this.Imie1 = imie;
            Gracze1 = new List<Gracz>();
        }
        public Turniej()
        {

        }

        public List<Gracz> Gracze { get => Gracze1;}
        public List<Gracz> Gracze1 { get => gracze; set => gracze = value; }
        public string Imie1 { get => Imie; set => Imie = value; }

        public override string ToString()
        {
            string text = $"Turniej {Imie1} \n";
            for (int i = 0; i < Gracze.Count; i++)
            {
                text += Gracze[i] + "\n";
            }
            return text;
        }

        public void AddGracz(Gracz u)
        {
            Gracze.Add(u);
        }

        public Gracz Zwyciezca()
        {
            int max = 0;
            Gracz maxGracz = null;
            for (int i = 0; i < Gracze.Count; i++)
            {
                if (Gracze[i].Punkty1 >= max)
                {
                    max = Gracze[i].Punkty1;
                    maxGracz = Gracze[i];
                }
            }
            return maxGracz;
        }

        public void SaveXML(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Turniej));
            TextWriter textWriter = new StreamWriter(fileName);
            xml.Serialize(textWriter, this);
            textWriter.Close();
        }
    }
}
