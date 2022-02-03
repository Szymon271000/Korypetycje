using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja03._02
{
    class KsiazkaAdresow
    {
        List<Adres> adresy = new List<Adres>();

        public delegate bool Pred(Adres adres);
        public delegate void AdresyEventHandler(Adres adres);

        public event AdresyEventHandler OnAdresAdded;

        public void Dodaj (Adres adres)
        {
            adresy.Add(adres);
            if(OnAdresAdded != null)
            {
                OnAdresAdded(adres);
            }
        }

        public override string ToString()
        {
            return adresy.ElementsToString();
        }

        public List<Adres> FindAll (Pred pred)
        {
            List<Adres> adresyzmiasta = new List<Adres>();
            for (int i = 0; i < adresy.Count; i++)
            {
                if (pred(adresy[i]))
                {
                    adresyzmiasta.Add(adresy[i]);
                }
            }
            return adresyzmiasta;
        }
    }
}
